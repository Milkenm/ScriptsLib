using System;
using System.Collections.Generic;
using System.Diagnostics;
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
		private readonly List<Task> _clientTasks = new List<Task>();
		private readonly Dictionary<Socket, Task> _socketToTaskMapping = new Dictionary<Socket, Task>();
		private readonly SynchronizationContext _syncContext;

		private readonly bool _disposed = false;

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
			if (this._disposed)
			{
				return;
			}

			if (disposing)
			{
				this.Stop();

				foreach (Task clientTask in this._clientTasks)
				{
					clientTask.Dispose();
				}

				foreach (Socket socket in this._connectedClients)
				{
				}
			}
		}

		public void Start()
		{
			if (this.IsRunning) return;

			this._server.Start();
			this.IsRunning = true;
			_ = Task.Factory.StartNew(this.AcceptClientsAsync, TaskCreationOptions.LongRunning).GetAwaiter();
		}

		public void Stop()
		{
			_ = this.LogMessage("Stopping the server...").GetAwaiter();
			if (!this.IsRunning) return;

			_ = this.LogMessage($"Closing {this._connectedClients.Count} client connections...").GetAwaiter();
			foreach (Socket client in this._connectedClients)
			{
				_ = this.DisconnectClient(client).GetAwaiter();
			}
			this._server.Stop();
			this.IsRunning = false;
		}

		private async Task DisconnectClient(Socket client)
		{
			EndPoint remoteEp = client.RemoteEndPoint;
			int index = this._socketToTaskMapping.Keys.ToList().IndexOf(client);

			Task clientTask = this._socketToTaskMapping[client];
			_ = this._clientTasks.Remove(clientTask);
			clientTask.Dispose();
			client.Dispose();
			_ = this._socketToTaskMapping.Remove(client);

			await this.LogMessage($"Closed connection for client ({remoteEp}) #{index}");
		}

		public void SendObject(Socket client, object obj)
		{
			if (!client.Connected)
			{
				_ = this.OnClientDisconnected(client).GetAwaiter();
				_ = this.LogMessage($"Client ({client.RemoteEndPoint}) has disconnected before sending data.").GetAwaiter();
			}

			try
			{
				long bytesSent = client.SendObject(obj);
				_ = this.LogMessage($"Sent {bytesSent} bytes to a client ({client.RemoteEndPoint}).").GetAwaiter();
			}
			catch
			{
				_ = this.OnClientDisconnected(client).GetAwaiter();
				_ = this.LogMessage($"Client ({client.RemoteEndPoint}) has disconnected while sending data.").GetAwaiter();
			}
		}

		private async Task AcceptClientsAsync()
		{
			try
			{
				await this.LogMessage("Waiting for client connection...");
				Socket socket = await this._server.AcceptSocketAsync().ConfigureAwait(false);
				await this.LogMessage("Client connected.");

				Task clientTask = new Task(async () => await this.ClientProcess(socket));
				this._clientTasks.Add(clientTask);
				this._socketToTaskMapping.Add(socket, clientTask);
				clientTask.Start();

				await this.LogMessage("Client connection successfully handled.");
			}
			catch (Exception ex)
			{
				if (this.IsRunning)
				{
					await this.LogMessage("Error during client connection:\n" + ex.ToString());
				}
			}

			if (this.IsRunning)
			{
				await this.LogMessage("Looping connection handler...");
				await this.AcceptClientsAsync();
			}
		}

		// https://stackoverflow.com/a/11664073
		private async Task ClientProcess(Socket clientSocket)
		{
			await this.OnClientConnected(clientSocket);

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
					await this.LogMessage($"Received data from client ({clientSocket.RemoteEndPoint}) with {read} bytes.");

					await this.CallEvent(() =>
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

			await this.OnClientDisconnected(clientSocket);
		}

		private async Task OnClientConnected(Socket socket)
		{
			await this.LogMessage($"A client ({socket.RemoteEndPoint}) has connected.");
			socket.ReceiveTimeout = this.ConnectionTimeout;

			await this.CallEvent(() =>
			{
				ClientConnected.Invoke(socket);
			});

			this._connectedClients.Add(socket);
		}

		private async Task OnClientDisconnected(Socket socket)
		{
			await this.LogMessage($"A client ({socket.RemoteEndPoint}) has disconnected.");
			_ = this._connectedClients.Remove(socket);

			Socket socketRef = socket;
			socket.Close(this.DisconnectTimeout);
			socket.Dispose();

			await this.CallEvent(() =>
			{
				ClientDisconnected?.Invoke(socketRef);
			});
		}

		private async Task LogMessage(string message)
		{
			Debug.WriteLine(message);
			await this.CallEvent(() =>
			{
				Log?.Invoke(message);
			});
		}

		private async Task CallEvent(Action @event)
		{
			// Async
			if (this.UseAsynchronousEvents)
			{
				await Task.Factory.StartNew(@event, TaskCreationOptions.LongRunning);
				return;
			}

			// Main
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
}