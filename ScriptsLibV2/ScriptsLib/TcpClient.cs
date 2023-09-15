using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2
{
	public class TcpClient
	{
		private readonly System.Net.Sockets.TcpClient _client = new System.Net.Sockets.TcpClient();

		/// Used to reconnect
		private IPAddress _lastIp = null;
		private int? _lastPort = null;
		private int? _lastRetries = null;

		public delegate void ConnectionEvent(NetworkStream stream);
		public event ConnectionEvent Connected;
		public delegate void DisconnectionEvent();
		public event DisconnectionEvent Disconnected;
		public event DisconnectionEvent ConnectionFailed;

		public delegate void ConnectionStatusChangeEvent(ConnectionStatus newStatus);
		public enum ConnectionStatus
		{
			Connected,
			Connecting,
			ConnectionFailed,
			Disconnected,
		}
		public event ConnectionStatusChangeEvent OnConnectionStatusChange;

		public delegate void DataCallbackEvent(object dataObject);
		public delegate void DataEvent(EndPoint source, byte[] data);
		public event DataEvent DataReceived;

		public delegate void DataReceivedCallback<T>(T packet);

		public bool IsConnecting { get; private set; }
		public bool IsConnected => _client.Connected;

		private DataCallbackEvent? _waitingForResponseCallback = null;
		private bool _supressDataReceivedEvent = false;
		private Type? _expectedResponseType = null;

		public bool Connect(IPAddress ip, int port, int retries = 0)
		{
			IsConnecting = true;

			_lastIp = ip;
			_lastPort = port;
			_lastRetries = retries;

			Disconnect();
			OnConnectionStatusChange?.Invoke(ConnectionStatus.Connecting);
			try
			{
				_client.Connect(ip, port);
				if (!_client.Connected)
				{
					return RetryConnection(ip, port, retries);
				}
			}
			catch
			{
				return RetryConnection(ip, port, retries);
			}
			Task.Run(() => OnConnectedToServer(_client.GetStream()));
			return true;
		}

		public bool Connect(IPAddress ip, int port, Action afterConnectAction, int retries = 0)
		{
			bool connected = this.Connect(ip, port, retries);
			if (connected)
			{
				afterConnectAction.Invoke();
			}
			return connected;
		}

		public bool Connect()
		{
			if (_lastIp != null && _lastPort != null)
			{
				return Connect(_lastIp, (int)_lastPort, (int)_lastRetries);
			}
			else
			{
				throw new Exception("Connect method was never called.");
			}
		}

		public async Task<bool> ConnectAsync(IPAddress ip, int port, int retries = 0)
		{
			Disconnect();
			OnConnectionStatusChange?.Invoke(ConnectionStatus.Connecting);
			try
			{
				await _client.ConnectAsync(ip, port);
				if (!_client.Connected)
				{
					return await RetryConnectionAsync(ip, port, retries);
				}
			}
			catch
			{
				return await RetryConnectionAsync(ip, port, retries);
			}
			Task.Run(async () => await OnConnectedToServer(_client.GetStream()));
			return true;
		}

		private bool RetryConnection(IPAddress ip, int port, int retries)
		{
			Debug.WriteLine("Retrying connection #" + retries);
			if (retries == 0)
			{
				IsConnecting = false;
				OnConnectionStatusChange?.Invoke(ConnectionStatus.ConnectionFailed);
				ConnectionFailed?.Invoke();
				return false;
			}
			return Connect(ip, port, retries - 1);
		}

		private async Task<bool> RetryConnectionAsync(IPAddress ip, int port, int retries)
		{
			if (retries == 0)
			{
				ConnectionFailed?.Invoke();
				OnConnectionStatusChange?.Invoke(ConnectionStatus.ConnectionFailed);
				return false;
			}
			return await ConnectAsync(ip, port, retries - 1);
		}

		private async Task OnConnectedToServer(NetworkStream stream)
		{
			IsConnecting = false;
			Connected?.Invoke(stream);
			OnConnectionStatusChange?.Invoke(ConnectionStatus.Connected);
			await ReceiveData();
		}

		public void Disconnect()
		{
			if (_client.Connected)
			{
				Disconnected?.Invoke();
				OnConnectionStatusChange?.Invoke(ConnectionStatus.Disconnected);
				_client.Client.Disconnect(true);
				_client.Close();
			}
		}

		public long Send(object data)
		{
			if (data.GetType() == typeof(byte[]))
			{
				byte[] dataBytes = (byte[])data;
				_client.GetStream().SendBytes(dataBytes);
				return dataBytes.LongLength;
			}
			long sentBytes = _client.GetStream().SendObject(data);
			_client.GetStream().Flush();
			return sentBytes;
		}

		public long Send(object data, DataCallbackEvent responseCallback, bool supressDataReceivedEvent = false)
		{
			_waitingForResponseCallback = responseCallback;
			_supressDataReceivedEvent = supressDataReceivedEvent;
			return Send(data);
		}

		public long Send<T>(object data, DataReceivedCallback<T> responseCallback, bool supressDataReceivedEvent)
		{
			_expectedResponseType = typeof(T);

			return Send(data, new DataCallbackEvent((dataObject) =>
			{
				responseCallback((T)dataObject);
			}), supressDataReceivedEvent);
		}

		// https://stackoverflow.com/a/11664073
		private async Task ReceiveData()
		{
			Socket socket = _client.Client;

			byte[] buffer;
			while (_client.Connected)
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
					object responseObject = buffer.ToObject<object>();

					if (!(_supressDataReceivedEvent && _expectedResponseType != null && _expectedResponseType == responseObject.GetType()))
					{
						DataReceived?.Invoke(socket.RemoteEndPoint, buffer);
					}

					if (_waitingForResponseCallback != null && (_expectedResponseType == null || _expectedResponseType == responseObject.GetType()))
					{
						_waitingForResponseCallback(responseObject);
						_waitingForResponseCallback = null;
						_supressDataReceivedEvent = false;
						_expectedResponseType = null;
					}
				}
				else
				{
					break;
				}
			}

			if (!_client.Connected && socket.Connected)
			{
				try
				{
					socket.Disconnect(true);
				}
				catch { }
			}

			Disconnected?.Invoke();
		}
	}
}
