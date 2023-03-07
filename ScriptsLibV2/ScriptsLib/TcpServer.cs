using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2
{
	public class TcpServer
	{
		private readonly TcpListener Server;
		private readonly List<Socket> ConnectedClients = new List<Socket>();
		private readonly List<Task> ClientTasks = new List<Task>();

		public bool IsRunning { get; private set; } = false;
		public bool UseAsynchronousEvents { get; set; }

		public TcpServer(IPEndPoint localEP)
		{
			Server = new TcpListener(localEP);
			Server.Start();
		}

		public TcpServer(short port) : this(new IPEndPoint(IPAddress.Any, port)) { }

		public int ConnectionTimeout { get; set; }
		public int DisconnectTimeout { get; set; }

		public delegate void ConnectionEvent(Socket client);
		public event ConnectionEvent OnClientConnect;
		public event ConnectionEvent OnClientDisconnect;

		public delegate void DataEvent(EndPoint source, byte[] data);
		public event DataEvent OnDataReceived;

		public void Start()
		{
			if (IsRunning) return;

			IsRunning = true;
			Task.Factory.StartNew(AcceptClientsAsync, TaskCreationOptions.LongRunning).GetAwaiter();
		}

		public void Stop()
		{
			if (!IsRunning) return;

			ClientTasks.ForEach((task) =>
			{
				ClientTasks.Remove(task);
				task.Dispose();
			});
		}

		public void SendObject(Socket client, object obj)
		{
			if (!client.Connected)
			{
				OnClientDisconnected(client);
			}

			try
			{
				client.SendObject(obj);
			}
			catch
			{
				OnClientDisconnected(client);
			}
		}

		private async Task AcceptClientsAsync()
		{
			try
			{
				Console.WriteLine("\tWaiting for client connection...");
				Socket socket = await Server.AcceptSocketAsync().ConfigureAwait(false);
				Console.WriteLine("\tClient connected.");
				Task.Run(async () => await ClientProcess(socket)).GetAwaiter();
				Console.WriteLine("\tHandled.");
			}
			catch
			{
				Console.WriteLine("\tError");
				return;
			}

			if (IsRunning)
			{
				Console.WriteLine("\tLooping...");
				await AcceptClientsAsync();
			}
		}

		// https://stackoverflow.com/a/11664073
		private async Task ClientProcess(Socket clientSocket)
		{
			await OnClientConnected(clientSocket);

			byte[] buffer;
			while (IsRunning)
			{
				buffer = new byte[clientSocket.ReceiveBufferSize];
				int read;

				try
				{
					read = clientSocket.Receive(buffer);
				}
				catch
				{
					break;
				}

				if (read > 0)
				{
					if (UseAsynchronousEvents)
					{
						await Task.Factory.StartNew(() => OnDataReceived?.Invoke(clientSocket.RemoteEndPoint, buffer), TaskCreationOptions.LongRunning);
					}
					else OnDataReceived?.Invoke(clientSocket.RemoteEndPoint, buffer);
				}
				else
				{
					break;
				}
			}

			if (!IsRunning)
			{
				clientSocket.Disconnect(true);
			}

			await OnClientDisconnected(clientSocket);
		}

		private async Task OnClientConnected(Socket socket)
		{
			socket.ReceiveTimeout = ConnectionTimeout;

			if (UseAsynchronousEvents)
			{
				 Task.Factory.StartNew(() => OnClientConnect?.Invoke(socket), TaskCreationOptions.LongRunning);
			}
			else OnClientConnect.Invoke(socket);

			ConnectedClients.Add(socket);
		}

		private async Task OnClientDisconnected(Socket socket)
		{
			socket?.Close(DisconnectTimeout);

			if (UseAsynchronousEvents)
			{
				 Task.Factory.StartNew(() => OnClientDisconnect?.Invoke(socket), TaskCreationOptions.LongRunning);
			}
			else OnClientDisconnect?.Invoke(socket);

			ConnectedClients.Remove(socket);
		}
	}
}