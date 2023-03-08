using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

using ScriptsLibV2.ScriptsLib.TcpClients;

namespace ScriptsLibV2
{
	public class TcpServer : TcpBase
	{
		private readonly TcpListener Server;
		private readonly List<Socket> ConnectedClients = new List<Socket>();
		private readonly List<Task> ClientTasks = new List<Task>();

		public bool IsRunning { get; private set; } = false;

		public TcpServer(IPEndPoint localEP)
		{
			Server = new TcpListener(localEP);
			Server.Start();
		}

		public TcpServer(short port) : this(new IPEndPoint(IPAddress.Any, port)) { }

		public int ConnectionTimeout { get; set; }
		public int DisconnectTimeout { get; set; }

		public delegate void ServerConnectionEvent(Socket client);
		public event ServerConnectionEvent OnClientConnect;
		public event ServerConnectionEvent OnClientDisconnect;

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

		public async void SendObject(Socket client, object obj)
		{
			if (!base.Send(client, obj))
			{
				base.TriggerEvent(() => OnClientDisconnected(client));
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

			base.ReceiveData(clientSocket);

			if (!IsRunning)
			{
				clientSocket.Disconnect(true);
			}

			await OnClientDisconnected(clientSocket);
		}

		private async Task OnClientConnected(Socket socket)
		{
			socket.ReceiveTimeout = ConnectionTimeout;

			base.TriggerEvent(() => OnClientConnect?.Invoke(socket));

			ConnectedClients.Add(socket);
		}

		private async Task OnClientDisconnected(Socket socket)
		{
			socket?.Close(DisconnectTimeout);

			base.TriggerEvent(() => OnClientDisconnect?.Invoke(socket));

			ConnectedClients.Remove(socket);
		}
	}
}