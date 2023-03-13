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
		private readonly Dictionary<Task, Socket> TaskToSocketMapping = new Dictionary<Task, Socket>();

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

		public delegate void DataEvent(Socket client, byte[] data);
		public event DataEvent OnDataReceived;

		public delegate void Log(string log);
		public event Log OnLog;

		public void Start()
		{
			if (IsRunning) return;

			IsRunning = true;
			Task.Factory.StartNew(AcceptClientsAsync, TaskCreationOptions.LongRunning).GetAwaiter();
		}

		public void Stop()
		{
			LogMessage("Stopping the server...");
			if (!IsRunning) return;

			int startingTasks = ClientTasks.Count;
			LogMessage($"Closing {startingTasks} client connections...");
			ClientTasks.ForEach((task) =>
			{
				EndPoint remoteEp = TaskToSocketMapping[task].RemoteEndPoint;
				int clientIndex = startingTasks - ClientTasks.Count;

				ClientTasks.Remove(task);
				task.Dispose();
				TaskToSocketMapping[task].Dispose();
				TaskToSocketMapping.Remove(task);

				LogMessage($"Closed connection for client ({remoteEp}) #{clientIndex}");
			});
		}

		public void SendObject(Socket client, object obj)
		{
			if (!client.Connected)
			{
				OnClientDisconnected(client);
				LogMessage($"Client ({client.RemoteEndPoint}) has disconnected before sending data.");
			}

			try
			{
				long bytesSent = client.SendObject(obj);
				LogMessage($"Sent {bytesSent} bytes to a client ({client.RemoteEndPoint}).");
			}
			catch
			{
				OnClientDisconnected(client);
				LogMessage($"Client ({client.RemoteEndPoint}) has disconnected while sending data.");
			}
		}

		private async Task AcceptClientsAsync()
		{
			try
			{
				LogMessage("Waiting for client connection...");
				Socket socket = await Server.AcceptSocketAsync().ConfigureAwait(false);
				LogMessage("Client connected.");

				Task clientTask = new Task(async () => await ClientProcess(socket));
				ClientTasks.Add(clientTask);
				TaskToSocketMapping.Add(clientTask, socket);
				clientTask.Start();

				LogMessage("Client connection successfully handled.");
			}
			catch (Exception ex)
			{
				LogMessage("Error during client connection:\n" + ex.ToString());
				return;
			}

			if (IsRunning)
			{
				LogMessage("Looping connection handler...");
				await AcceptClientsAsync();
			}
		}

		// https://stackoverflow.com/a/11664073
		private async Task ClientProcess(Socket clientSocket)
		{
			 OnClientConnected(clientSocket);

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
					LogMessage($"Received data from client ({clientSocket.RemoteEndPoint}) with {read} bytes.");
					if (UseAsynchronousEvents)
					{
						await Task.Factory.StartNew(() => OnDataReceived?.Invoke(clientSocket, buffer), TaskCreationOptions.LongRunning);
					}
					else OnDataReceived?.Invoke(clientSocket, buffer);
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

			 OnClientDisconnected(clientSocket);
		}

		private void OnClientConnected(Socket socket)
		{
			LogMessage($"A client ({socket.RemoteEndPoint}) has connected.");
			socket.ReceiveTimeout = ConnectionTimeout;

			if (UseAsynchronousEvents)
			{
				Task.Factory.StartNew(() => OnClientConnect?.Invoke(socket), TaskCreationOptions.LongRunning).GetAwaiter();
			}
			else OnClientConnect.Invoke(socket);

			ConnectedClients.Add(socket);
		}

		private void OnClientDisconnected(Socket socket)
		{
			LogMessage($"A client ({socket.RemoteEndPoint}) has disconnected.");
			socket?.Close(DisconnectTimeout);

			if (UseAsynchronousEvents)
			{
				Task.Factory.StartNew(() => OnClientDisconnect?.Invoke(socket), TaskCreationOptions.LongRunning).GetAwaiter();
			}
			else OnClientDisconnect?.Invoke(socket);

			ConnectedClients.Remove(socket);
		}

		private void LogMessage(string message)
		{
			if (UseAsynchronousEvents)
			{
				Task.Factory.StartNew(() => OnLog?.Invoke(message)).GetAwaiter();
			}
			else OnLog?.Invoke(message);
		}
	}
}