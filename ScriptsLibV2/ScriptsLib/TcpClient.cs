using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2
{
	public class TcpClient
	{
		private System.Net.Sockets.TcpClient Client = new System.Net.Sockets.TcpClient();

		private IPAddress LastIP = null;
		private int? LastPort = null;
		private int? LastRetries = null;

		public delegate void ConnectionEvent(NetworkStream stream);
		public event ConnectionEvent OnConnect;
		public event ConnectionEvent OnDisconnect;

		public delegate void DataCallbackEvent(object dataObject);
		public delegate void DataEvent(EndPoint source, byte[] data);
		public event DataEvent OnDataReceived;

		public delegate void DataReceivedCallback<T>(T packet);

		public bool IsConnected { get => Client.Connected; }

		private DataCallbackEvent? WaitingForResponseCallback = null;
		private bool SupressDefaultEvent = false;
		private Type? ExpectedResponseType = null;

		public bool Connect(IPAddress ip, int port, int retries = 0)
		{
			LastIP = ip;
			LastPort = port;
			LastRetries = retries;

			Disconnect();
			Client.Connect(ip, port);
			if (!Client.Connected)
			{
				if (retries == 0)
				{
					return false;
				}
				return Connect(ip, port, retries - 1);
			}
			Task.Run(() => OnConnectedToServer(Client.GetStream()));
			return true;
		}

		public bool Connect()
		{
			if (LastIP != null && LastPort != null)
			{
				return this.Connect(LastIP, (int)LastPort, (int)LastRetries);
			}
			else
			{
				throw new System.Exception("Connect method was never called.");
			}
		}

		public async Task<bool> ConnectAsync(IPAddress ip, int port, int retries = 0)
		{
			Disconnect();
			await Client.ConnectAsync(ip, port);
			if (!Client.Connected)
			{
				if (retries == 0)
				{
					return false;
				}
				return await ConnectAsync(ip, port, retries - 1);
			}
			Task.Run(async () => await OnConnectedToServer(Client.GetStream()));
			return true;
		}

		private async Task OnConnectedToServer(NetworkStream stream)
		{
			OnConnect?.Invoke(stream);
			await ReceiveData();
		}

		public void Disconnect()
		{
			if (Client.Connected)
			{
				OnDisconnect?.Invoke(Client.GetStream());
				Client.Client.Disconnect(true);
				Client.Close();
			}
		}

		public void Send(object data)
		{
			Client.GetStream().SendObject(data);
		}

		public void Send(object data, DataCallbackEvent responseCallback, bool supressDefaultEvent = false)
		{
			Send(data);
			WaitingForResponseCallback = responseCallback;
			SupressDefaultEvent = supressDefaultEvent;
		}

		public void Send<T>(object data, DataReceivedCallback<T> responseCallback, bool supressDefaultEvent)
		{
			ExpectedResponseType = typeof(T);

			this.Send(data, new DataCallbackEvent((dataObject) =>
			{
				responseCallback((T)dataObject);
			}), supressDefaultEvent);
		}

		// https://stackoverflow.com/a/11664073
		public async Task ReceiveData()
		{
			Socket socket = Client.Client;

			byte[] buffer;
			while (Client.Connected)
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

					if (!(SupressDefaultEvent && ExpectedResponseType != null && ExpectedResponseType == responseObject.GetType()))
					{
						OnDataReceived?.Invoke(socket.RemoteEndPoint, buffer);
					}

					if (WaitingForResponseCallback != null && (ExpectedResponseType == null || ExpectedResponseType == responseObject.GetType()))
					{
						WaitingForResponseCallback(responseObject);
						WaitingForResponseCallback = null;
						SupressDefaultEvent = false;
						ExpectedResponseType = null;
					}
				}
				else
				{
					break;
				}
			}

			if (!Client.Connected && socket.Connected)
			{
				try
				{
					socket.Disconnect(true);
				}
				catch { }
			}
		}
	}
}
