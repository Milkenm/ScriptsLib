using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2
{
	public class TcpServer : IDisposable
	{
		public bool IsRunning { get; private set; } = false;
		public bool UseAsynchronousEvents { get; set; } = false;
		public int ConnectionTimeout { get; set; }
		public int DisconnectTimeout { get; set; }

		private readonly TcpListener _server;
		private readonly List<Socket> _connectedClients = new List<Socket>();
		private readonly Dictionary<Task, CancellationTokenSource> _clientTasks = new Dictionary<Task, CancellationTokenSource>();
		private readonly Dictionary<Socket, Task> _socketToTaskMapping = new Dictionary<Socket, Task>();
		private readonly SynchronizationContext _syncContext;

		private bool _isDisposed = false;

		public TcpServer(IPEndPoint localEP)
		{
			this._server = new TcpListener(localEP);
			this._syncContext = SynchronizationContext.Current;
		}

		public TcpServer(short port)
			: this(new IPEndPoint(IPAddress.Any, port))
		{ }

		public delegate void ClientConnectionEvent(Socket client);
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
				this.Stop();

				foreach (var clientTaskKv in this._clientTasks)
				{
					// TODO: FIX
					clientTaskKv.Value.Cancel();
					clientTaskKv.Value.Dispose();
					clientTaskKv.Key.Dispose();
					_clientTasks.Remove(clientTaskKv.Key);
				}

				foreach (Socket socket in this._connectedClients)
				{
					socket.Close();
					socket.Dispose();
					this._connectedClients.Remove(socket);
				}
			}

			this._isDisposed = true;
		}

		public void Start()
		{
			if (this.IsRunning) return;

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

			this.LogMessage($"Closing {this._connectedClients.Count} client connections...");
			foreach (Socket client in this._connectedClients)
			{
				this.DisconnectClient(client);
			}
			this._server.Stop();
			this.IsRunning = false;
		}

		private void DisconnectClient(Socket client)
		{
			try
			{
				EndPoint remoteEp = client.RemoteEndPoint;
				int index = this._socketToTaskMapping.Keys.ToList().IndexOf(client);

				Task clientTask = this._socketToTaskMapping[client];
				_ = this._clientTasks.Remove(clientTask);
				// TODO: FIX
				clientTask.Dispose();
				client.Dispose();
				_ = this._socketToTaskMapping.Remove(client);

				this.LogMessage($"Closed connection for client ({remoteEp}) #{index}");
			}
			catch (Exception ex)
			{
				this.LogMessage($"Error while disconnecting client:\n{ex.Message}");
			}
		}

		public void SendObject(Socket client, object obj)
		{
			if (!client.Connected)
			{
				this.OnClientDisconnected(client);
				this.LogMessage($"Client ({client?.RemoteEndPoint}) has disconnected before sending data.");
			}

			try
			{
				long bytesSent = client.SendObject(obj);
				this.LogMessage($"Sent {bytesSent} bytes to a client ({client.RemoteEndPoint}).");
			}
			catch
			{
				this.OnClientDisconnected(client);
				this.LogMessage($"Client ({client?.RemoteEndPoint}) has disconnected while sending data.");
			}
		}

		private async Task AcceptClientsAsync()
		{
			try
			{
				this.LogMessage("Waiting for client connection...");
				Socket socket = await this._server.AcceptSocketAsync();
				this.LogMessage("Client connected.");

				Task clientTask = new Task(() => this.ClientHandler(socket));
				this._clientTasks.Add(clientTask);
				this._socketToTaskMapping.Add(socket, clientTask);
				clientTask.Start();

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

		// https://stackoverflow.com/a/11664073
		private void ClientHandler(Socket clientSocket)
		{
			this.OnClientConnected(clientSocket);

			while (this.IsRunning)
			{
				byte[] buffer = new byte[clientSocket.ReceiveBufferSize];
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
					this.LogMessage($"Received data from client ({clientSocket.RemoteEndPoint}) with {read} bytes.");

					this.CallEvent(() =>
					{
						DataReceived?.Invoke(clientSocket, buffer);
					});
				}
				else
				{
					break;
				}
			}

			if (!this.IsRunning)
			{
				clientSocket.Disconnect(true);
			}

			this.OnClientDisconnected(clientSocket);
		}

		private void OnClientConnected(Socket socket)
		{
			this.LogMessage($"A client ({socket.RemoteEndPoint}) has connected.");
			socket.ReceiveTimeout = this.ConnectionTimeout;

			this.CallEvent(() =>
			{
				ClientConnected.Invoke(socket);
			});

			this._connectedClients.Add(socket);
		}

		private void OnClientDisconnected(Socket socket)
		{
			this.LogMessage($"A client ({socket.RemoteEndPoint}) has disconnected.");
			_ = this._connectedClients.Remove(socket);

			Socket socketRef = socket;
			socket.Close(this.DisconnectTimeout);
			socket.Dispose();

			this.CallEvent(() =>
			{
				ClientDisconnected?.Invoke(socketRef);
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
				new Task(@event).FAF();
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

		private class ClientInfo : IDisposable
		{
			private Socket _socket;
			private Task _task;
			private CancellationTokenSource _cancellationToken;
			private bool _isDisposed;

			public ClientInfo(TcpServer server, Socket socket)
			{
				this._socket = socket;
				this._cancellationToken = new CancellationTokenSource();
				this._task = new Task(() => server.ClientHandler(socket), this._cancellationToken.Token);
				_task.Start();
			}

			protected virtual void Dispose(bool disposing)
			{
				if (_isDisposed)
				{
					return;
				}
				_isDisposed = true;

				if (disposing)
				{
					_cancellationToken.Cancel();
					_cancellationToken.Dispose();
					_task.Dispose();
				}

				_socket.Close();
				_socket.Dispose();
			}

			public void Dispose()
			{
				Dispose(true);
				GC.SuppressFinalize(this);
			}
		}
	}
}