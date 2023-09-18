using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;

using MySql.Data.MySqlClient.Memcached;

using Org.BouncyCastle.Bcpg;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2
{
	public class TcpServer : /*TcpListener,*/ IDisposable
	{
		public bool IsRunning { get; private set; } = false;
		public bool UseAsynchronousEvents { get; set; } = false;
		public int ConnectionTimeout { get; set; }
		public int DisconnectTimeout { get; set; }

		private readonly TcpListener _server;
		private readonly Dictionary<ulong, ClientInfo> _clients = new Dictionary<ulong, ClientInfo>();
		private readonly SynchronizationContext _syncContext;

		private bool _isDisposed = false;

		public TcpServer(IPEndPoint localEP)
			/*: base (localEP)*/
		{
			this._server = new TcpListener(localEP);
			this._syncContext = SynchronizationContext.Current;
		}

		public TcpServer(short port)
			: this(new IPEndPoint(IPAddress.Any, port))
		{ }

		public delegate void ClientConnectionEvent(ClientInfo client);
		public event ClientConnectionEvent ClientConnected;
		public event ClientConnectionEvent ClientDisconnected;

		public delegate void DataEvent(Socket client, byte[] data);
		public event DataEvent DataReceived;

		public delegate void LogEvent(string log);
		public event LogEvent Log;

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (this._isDisposed)
			{
				return;
			}

			if (disposing)
			{

			}

			this.Stop();
			foreach (ClientInfo client in this._clients.Values)
			{
				this.DisconnectClient(client);
			}

			this._isDisposed = true;
		}

		public void Start()
		{
			if (this.IsRunning)
			{
				return;
			}

			this._server.Start();
			this.IsRunning = true;

			_ = Task.Factory.StartNew(this.AcceptClientsAsync, TaskCreationOptions.LongRunning);
		}

		public void Stop()
		{
			this.LogMessage("Stopping the server...");
			if (!this.IsRunning)
			{
				this.LogMessage("Server is already stopped.");
			}

			this.LogMessage($"Closing {this._clients.Count} client connections...");
			foreach (ClientInfo client in this._clients.Values)
			{
				this.DisconnectClient(client);
			}
			this._server.Stop();
			this.IsRunning = false;
		}

		private void DisconnectClient(ClientInfo client)
		{
			try
			{
				EndPoint remoteEp = client.Socket.RemoteEndPoint;

				client.Stop();
				_ = this._clients.Remove(client.ClientId);

				this.LogMessage($"Closed connection for client ({client.GetPrintableId()})");
			}
			catch (Exception ex)
			{
				this.LogMessage($"Error while disconnecting client:\n{ex.Message}");
			}
		}

		public void SendObject(Socket socket, object obj)
		{
			ClientInfo client = ClientInfo.GetClientBySocket(this._clients.Values.ToList(), socket);
			if (client == null)
			{
				this.LogMessage($"No {nameof(ClientInfo)} was found for the provided socket.");
				return;
			}

			if (!client.Socket.Connected || client.Socket == null)
			{
				this.OnClientDisconnected(client);
				this.LogMessage($"Client ({client.GetPrintableId()}) has disconnected before sending data.");
				return;
			}

			try
			{
				long bytesSent = client.Socket.SendObjectAsync2(obj);
				this.LogMessage($"Sent {bytesSent} bytes to a client ({client.GetPrintableId()}).");
			}
			catch
			{
				this.OnClientDisconnected(client);
				this.LogMessage($"Client ({client.GetPrintableId()}) has disconnected while sending data.");
			}
		}

		private async Task AcceptClientsAsync()
		{
			try
			{
				this.LogMessage("Waiting for client connection...");
				Socket socket = await this._server.AcceptSocketAsync();
				this.LogMessage("Client connected.");

				ClientInfo client = new ClientInfo(this, socket);
				this._clients.Add(client.ClientId, client);
				client.Start();
				this.LogMessage("Client connection successfully handled.");
			}
			catch (Exception ex)
			{
				if (this.IsRunning)
				{
					this.LogMessage("Error during client connection:\n" + ex.ToString());
				}
			}

			if (this.IsRunning)
			{
				this.LogMessage("Looping connection handler...");
				_ = this.AcceptClientsAsync();
			}
		}

		int received;
		private void OnReceive(IAsyncResult result, ClientInfo client)
		{
			received += client.Socket.EndReceive(result);
		}

		// https://stackoverflow.com/a/11664073
		internal void ClientHandler(ClientInfo client)
		{
			this.OnClientConnected(client);

			try
			{
				// Begin receiving data asynchronously
				client.Socket.BeginReceive(client.Buffer, 0, 1024, SocketFlags.None, ReceiveCallback, client);
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error while starting to receive: " + ex.Message);
				this.HandleClientDisconnect(client);
			}
		}

		/// ---------- CHAT GPT STUFF XD ---------- ///

		private void ReceiveCallback(IAsyncResult ar)
		{
			ClientInfo client = (ClientInfo)ar.AsyncState;

			try
			{
				// End the asynchronous receive operation and get the number of bytes received
				int bytesRead = client.Socket.EndReceive(ar);

				if (bytesRead > 0)
				{
					// Process the received data
					byte[] receivedData = new byte[bytesRead];
					Array.Copy(client.Buffer, receivedData, bytesRead);

					this.LogMessage($"Received {bytesRead} bytes of data from client ({client.GetPrintableId()}).");

					// Do something with receivedData
					this.CallEvent(() =>
					{
						DataReceived?.Invoke(client.Socket, client.Buffer);
					});

					// Continue receiving more data
					client.Socket.BeginReceive(client.Buffer, 0, 1024, SocketFlags.None, ReceiveCallback, client);
				}
				else
				{
					this.HandleClientDisconnect(client);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error during receive callback: " + ex.Message);

				this.HandleClientDisconnect(client);
			}
		}

		private void HandleClientDisconnect(ClientInfo client)
		{
			if (!this.IsRunning)
			{
				this.DisconnectClient(client);
			}

			this.OnClientDisconnected(client);
		}

		/// ---------- CHAT GPT STUFF XD ---------- ///

		private void OnClientConnected(ClientInfo client)
		{
			this.LogMessage($"A client ({client.GetPrintableId()}) has connected.");
			client.Socket.ReceiveTimeout = this.ConnectionTimeout;

			this.CallEvent(() =>
			{
				ClientConnected.Invoke(client);
			});
		}

		private void OnClientDisconnected(ClientInfo client)
		{
			this.LogMessage($"A client ({client.GetPrintableId()}) has disconnected.");

			Socket socketRef = client.Socket;
			this.DisconnectClient(client);

			this.CallEvent(() =>
			{
				ClientDisconnected?.Invoke(client);
			});
		}

		private void LogMessage(string message)
		{
			Debug.WriteLine(message);
			this.CallEvent(() =>
			{
				Log?.Invoke(message);
			});
		}

		private void CallEvent(Action @event)
		{
			// Async
			if (this.UseAsynchronousEvents)
			{
				Task.Run(@event).FAF();
				return;
			}

			// Main (sync)
			if (Thread.CurrentThread.ManagedThreadId == 1)
			{
				@event.Invoke();
				return;
			}
			this._syncContext.Post(_ =>
			{
				@event.Invoke();
			}, null);
		}
	}

	public class ClientInfo : IDisposable
	{
		private static ulong _NextClientId = 1;

		public ulong ClientId { get; }
		public Socket Socket { get; }
		public byte[] Buffer { get; } = new byte[1024];

		private readonly Task _task;
		private readonly CancellationTokenSource _cancellationToken;
		private bool _isDisposed;

		public ClientInfo(TcpServer server, Socket socket)
		{
			this.Socket = socket;
			this._cancellationToken = new CancellationTokenSource();

			this._task = new Task(() => server.ClientHandler(this), this._cancellationToken.Token);

			this.ClientId = _NextClientId;
			_NextClientId++;
		}

		public void Start()
		{
			if (this._task.Status == TaskStatus.Created)
			{
				this._task.Start();
			}
		}

		public void Stop()
		{
			if (!this._cancellationToken.IsCancellationRequested)
			{
				this._cancellationToken.Cancel();
				this.Socket.Disconnect(false);
				this.Socket.Dispose();
				this.Dispose();
			}
		}

		public string GetPrintableId()
		{
			if (this.Socket != null)
			{
				return $"{this.Socket?.RemoteEndPoint}#{this.ClientId}";
			}
			else
			{
				return $"?#{this.ClientId}";
			}
		}

		protected virtual void Dispose(bool disposing)
		{
			if (this._isDisposed)
			{
				return;
			}
			this._isDisposed = true;

			if (disposing)
			{
				this._cancellationToken.Cancel();
				this._cancellationToken.Dispose();
				this._task.Dispose();
			}

			this.Socket.Disconnect(false);
			this.Socket.Close();
			this.Socket.Dispose();
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		public static ClientInfo GetClientBySocket(List<ClientInfo> clientInfos, Socket socket)
		{
			return clientInfos.Where(ci => ci.Socket == socket).FirstOrDefault();
		}
	}
}