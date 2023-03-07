using System;
using System.Net;
using System.Threading.Tasks;

using ScriptsLibV2;
using ScriptsLibV2.Extensions;

namespace SlTerminal
{
	internal class Program
	{
		private static TcpServer Server;
		private static TcpClient Client;

		private static void Main(string[] args)
		{
			Server = new TcpServer(6969);
			Server.UseAsynchronousEvents = true;
			Server.Start();
			Server.OnClientConnect += Server_OnClientConnected;
			Server.OnClientDisconnect += Server_OnClientDisconnect;
			Server.OnDataReceived += Server_OnDataReceived;

			Client = new TcpClient();
			Client.OnDataReceived += Client_OnDataReceived;
			Client.Connect(IPAddress.Loopback, 6969);
			Console.WriteLine(Client.IsConnected);
			Client.Send("Hello from Client");

			TcpClient client2 = new TcpClient();
			client2.Connect(IPAddress.Loopback, 6969);
			Console.WriteLine(client2.IsConnected);
			client2.Send("Hello from client2");

			Console.ReadKey();
		}

		private static void Server_OnDataReceived(EndPoint source, byte[] data)
		{
			Console.WriteLine("Server received data: " + data.ToObject<string>());
		}

		private static void Server_OnClientDisconnect(System.Net.Sockets.Socket client)
		{
			Console.WriteLine("Client disconnected.");
		}

		private static void Client_OnDataReceived(EndPoint source, byte[] data)
		{
			int i = data.ToObject<int>();
			if (i == 2)
			{
				Client.Disconnect();
			}
			Console.WriteLine("Client received data: " + i);
		}

		private static void Server_OnClientConnected(System.Net.Sockets.Socket client)
		{
			Console.WriteLine("Client connected to server.");

			for (int i = 0; i < 5; i++)
			{
				if (!client.Connected) break;

				client.Send(i.ToByteArray());
				Task.Delay(1000).Wait();
			}
		}
	}
}
