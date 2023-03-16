﻿using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2
{
	public class TcpClient
	{
		private readonly System.Net.Sockets.TcpClient Client = new System.Net.Sockets.TcpClient();

		private IPAddress LastIP = null;
		private int? LastPort = null;
		private int? LastRetries = null;

		public delegate void ConnectEvent(NetworkStream stream);
		public event ConnectEvent OnConnect;
		public delegate void DisconnectEvent();
		public event DisconnectEvent OnDisconnect;
		public event DisconnectEvent OnConnectionFail;

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
		public event DataEvent OnDataReceived;

		public delegate void DataReceivedCallback<T>(T packet);

		public bool IsConnecting { get; private set; }
		public bool IsConnected => Client.Connected;

		private DataCallbackEvent? WaitingForResponseCallback = null;
		private bool SupressDefaultEvent = false;
		private Type? ExpectedResponseType = null;

		public bool Connect(IPAddress ip, int port, int retries = 0)
		{
			IsConnecting = true;

			LastIP = ip;
			LastPort = port;
			LastRetries = retries;

			Disconnect();
			OnConnectionStatusChange?.Invoke(ConnectionStatus.Connecting);
			try
			{
				Client.Connect(ip, port);
				if (!Client.Connected)
				{
					return RetryConnection(ip, port, retries);
				}
			}
			catch
			{
				return RetryConnection(ip, port, retries);
			}
			Task.Run(() => OnConnectedToServer(Client.GetStream()));
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

		private bool RetryConnection(IPAddress ip, int port, int retries)
		{
			Debug.WriteLine("Retrying connection #" + retries);
			if (retries == 0)
			{
				IsConnecting = false;
				OnConnectionStatusChange?.Invoke(ConnectionStatus.ConnectionFailed);
				OnConnectionFail?.Invoke();
				return false;
			}
			return Connect(ip, port, retries - 1);
		}

		public bool Connect()
		{
			if (LastIP != null && LastPort != null)
			{
				return Connect(LastIP, (int)LastPort, (int)LastRetries);
			}
			else
			{
				throw new System.Exception("Connect method was never called.");
			}
		}

		public async Task<bool> ConnectAsync(IPAddress ip, int port, int retries = 0)
		{
			Disconnect();
			OnConnectionStatusChange?.Invoke(ConnectionStatus.Connecting);
			try
			{
				await Client.ConnectAsync(ip, port);
				if (!Client.Connected)
				{
					return await RetryConnectionAsync(ip, port, retries);
				}
			}
			catch
			{
				return await RetryConnectionAsync(ip, port, retries);
			}
			Task.Run(async () => await OnConnectedToServer(Client.GetStream()));
			return true;
		}

		private async Task<bool> RetryConnectionAsync(IPAddress ip, int port, int retries)
		{
			if (retries == 0)
			{
				OnConnectionFail?.Invoke();
				OnConnectionStatusChange?.Invoke(ConnectionStatus.ConnectionFailed);
				return false;
			}
			return await ConnectAsync(ip, port, retries - 1);
		}

		private async Task OnConnectedToServer(NetworkStream stream)
		{
			IsConnecting = false;
			OnConnect?.Invoke(stream);
			OnConnectionStatusChange?.Invoke(ConnectionStatus.Connected);
			await ReceiveData();
		}

		public void Disconnect()
		{
			if (Client.Connected)
			{
				OnDisconnect?.Invoke();
				OnConnectionStatusChange?.Invoke(ConnectionStatus.Disconnected);
				Client.Client.Disconnect(true);
				Client.Close();
			}
		}

		public long Send(object data)
		{
			if (data.GetType() == typeof(byte[]))
			{
				byte[] dataBytes = (byte[])data;
				Client.GetStream().SendBytes(dataBytes);
				return dataBytes.LongLength;
			}
			return Client.GetStream().SendObject(data);
		}

		public long Send(object data, DataCallbackEvent responseCallback, bool supressDefaultEvent = false)
		{
			WaitingForResponseCallback = responseCallback;
			SupressDefaultEvent = supressDefaultEvent;
			return Send(data);
		}

		public long Send<T>(object data, DataReceivedCallback<T> responseCallback, bool supressDefaultEvent)
		{
			ExpectedResponseType = typeof(T);

			return Send(data, new DataCallbackEvent((dataObject) =>
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

			OnDisconnect?.Invoke();
		}
	}
}
