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

		private bool IsRunning = false;

		public TcpServer(IPEndPoint localEP)
		{
			Server = new TcpListener(localEP);
			Server.Start();
		}

		public TcpServer(short port) : this(new IPEndPoint(IPAddress.Any, port)) { }

		public int ConnectionTimeout { get; set; }
		public int DisconnectTimeout { get; set; }

		public delegate void ConnectionEvent(Socket client);
		public event ConnectionEvent OnClientConnected;
		public event ConnectionEvent OnClientDisconnected;

		public delegate void DataEvent(EndPoint source, byte[] data);
		public event DataEvent OnDataReceived;

		public void Start()
		{
			IsRunning = true;
			AcceptClientsAsync().FAF();
		}

		public void Stop()
		{
			ClientTasks.ForEach((task) =>
			{
				ClientTasks.Remove(task);
				task.Dispose();
			});
		}

		private async Task AcceptClientsAsync()
		{
			while (IsRunning)
			{
				Task clientTask = ClientProcess();
				await Task.Run(() => clientTask.FAF()).ConfigureAwait(false);
			}
		}

		// https://stackoverflow.com/a/11664073
		private async Task ClientProcess()
		{
			Socket socket;
			try
			{
				socket = await Server.AcceptSocketAsync().ConfigureAwait(false);
				ClientConnected(socket);
			}
			catch
			{
				return;
			}

			byte[] buffer;
			while (IsRunning)
			{
				buffer = new byte[socket.ReceiveBufferSize];
				int read;

				try
				{
					read = socket.Receive(buffer);
				}
				catch
				{
					break;
				}

				if (read > 0)
				{
					OnDataReceived?.Invoke(socket.RemoteEndPoint, buffer);
				}
				else
				{
					break;
				}
			}

			if (!IsRunning)
			{
				socket.Disconnect(true);
			}

			ClientDisconnected(socket);
		}

		private void ClientConnected(Socket socket)
		{
			socket.ReceiveTimeout = ConnectionTimeout;

			OnClientConnected?.Invoke(socket);
			ConnectedClients.Add(socket);
		}

		private void ClientDisconnected(Socket socket)
		{
			socket?.Close(DisconnectTimeout);

			OnClientDisconnected?.Invoke(socket);
			ConnectedClients.Remove(socket);
		}
	}
}