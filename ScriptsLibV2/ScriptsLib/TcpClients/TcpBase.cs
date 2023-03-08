using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2.ScriptsLib.TcpClients
{
	public abstract class TcpBase
	{
		public delegate void DataEvent(EndPoint source, byte[] data);
		public event DataEvent OnDataReceived;

		private DataEvent WaitingForResponseCallback = null;
		private bool SupressDefaultEvent = false;

		public bool UseAsynchronousEvents { get; set; }
		public bool IsReceivingData { get; set; } = true;

		protected bool Send(Socket socket, object obj)
		{
			if (!socket.Connected)
			{
				return false;
			}

			try
			{
				socket.SendObject(obj);
				return true;
			}
			catch
			{
				return false;
			}
		}

		protected bool Send(NetworkStream stream, object obj)
		{
			try
			{
				Console.WriteLine("send object");
				stream.SendObject(obj);
				Console.WriteLine("sent");
				return true;
			}
			catch
			{
				return false;
			}
		}

		protected async void TriggerEvent(Action action)
		{
			if (UseAsynchronousEvents)
			{
				await Task.Factory.StartNew(action, TaskCreationOptions.LongRunning);
			}
			else action();
		}

		public async void ReceiveData(Socket socket)
		{
			byte[] buffer;
			while (IsReceivingData)
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
					Console.WriteLine("Received data.");
					if (!SupressDefaultEvent || WaitingForResponseCallback == null)
					{
						Console.WriteLine("On data received event.");
						TriggerEvent(() => OnDataReceived?.Invoke(socket.RemoteEndPoint, buffer));
					}
					if (WaitingForResponseCallback != null)
					{
						Console.WriteLine("Trigger event.");
						TriggerEvent(() => WaitingForResponseCallback(socket.RemoteEndPoint, buffer));

						WaitingForResponseCallback = null;
						SupressDefaultEvent = false;
					}
				}
				else
				{
					break;
				}
			}
		}
	}
}
