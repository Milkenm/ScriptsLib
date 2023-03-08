using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

using ScriptsLibV2.ScriptsLib.TcpClients;

namespace ScriptsLibV2
{
	public class TcpClient : TcpBase
	{
		private System.Net.Sockets.TcpClient Client = new System.Net.Sockets.TcpClient();

		public delegate void ClientConnectionEvent(NetworkStream stream);
		public event ClientConnectionEvent OnConnect;
		public event ClientConnectionEvent OnDisconnect;

		private IPAddress LastIP = null;
		private int? LastPort = null;
		private int? LastRetries = null;

		public bool IsConnected { get => Client.Connected; }

		private DataEvent? WaitingForResponseCallback = null;
		private bool SupressDefaultEvent = false;

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
				return Connect(LastIP, (int)LastPort, (int)LastRetries);
			}
			else
			{
				throw new Exception("Connect method was never called.");
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
			TriggerEvent(() => OnConnect?.Invoke(stream));
			await ReceiveData();
		}

		public async void Disconnect()
		{
			if (Client.Connected)
			{
				TriggerEvent(() => OnDisconnect?.Invoke(Client.GetStream()));
				Client.Client.Disconnect(true);
				Client.Close();
			}
		}

		public void Send(object data)
		{
			if (!base.Send(Client.GetStream(), data))
			{
				TriggerEvent(() => OnDisconnect?.Invoke(Client.GetStream()));
				Disconnect();
			}
		}

		public void Send(object data, DataEvent responseCallback, bool supressDefaultEvent = false)
		{
			WaitingForResponseCallback = responseCallback;
			SupressDefaultEvent = supressDefaultEvent;
			Send(data);
		}

		// https://stackoverflow.com/a/11664073
		public async Task ReceiveData()
		{
			Socket socket = Client.Client;

			base.ReceiveData(socket);

			if (!Client.Connected && socket.Connected)
			{
				try
				{
					socket.Disconnect(true);
					base.IsReceivingData = false;
				}
				catch { }
			}
		}
	}
}
