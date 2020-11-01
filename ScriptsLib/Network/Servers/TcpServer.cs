using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ScriptsLib.Network.Servers
{
	public class TcpServer
	{
		public TcpServer(IPEndPoint localEP)
		{
			Initialize(localEP);
		}

		public TcpServer(short port)
		{
			IPEndPoint localEP = new IPEndPoint(IPAddress.Any, port);
			Initialize(localEP);
		}

		private void Initialize(IPEndPoint localEP)
		{
			Server = new TcpListener(localEP);
			Server.Start();
		}

		private TcpListener Server;

		public delegate void ConnectionEvent(Socket client);
		public event ConnectionEvent OnClientConnected;
		public event ConnectionEvent OnClientDisconnected;

		public delegate void DataEvent(EndPoint source, byte[] data);
		public event DataEvent OnDataReceived;

		public void Start()
		{
			AcceptClientsAsync();
		}

		private async Task AcceptClientsAsync()
		{
			while (true)
			{
				await Task.Run(() =>
				{
					ClientProcess();
				}).ConfigureAwait(false);
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

			while (true)
			{
				byte[] buffer = new byte[socket.ReceiveBufferSize];
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

			ClientDisconnected(socket);
		}

		private readonly List<Socket> ConnectedClients = new List<Socket>();

		private void ClientConnected(Socket socket)
		{
			socket.ReceiveTimeout = 20000;

			OnClientConnected?.Invoke(socket);
			ConnectedClients.Add(socket);
		}

		private void ClientDisconnected(Socket socket)
		{
			socket?.Close(5000);

			OnClientDisconnected?.Invoke(socket);
			ConnectedClients.Remove(socket);
		}
	}
}
