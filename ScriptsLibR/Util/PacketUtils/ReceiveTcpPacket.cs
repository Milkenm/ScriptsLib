﻿using System.Net;
using System.Net.Sockets;

namespace ScriptsLibR.Util
{
	public static partial class PacketUtils
	{
		/// <summary>Waits for a TCP packet.</summary>
		/// <param name="localIp">The local IP to create the server on.</param>
		/// <param name="localPort">The local port to create the server on.</param>
		public static byte[] ReceiveTcpPacket(IPAddress localIp, short localPort)
		{
			TcpListener server = new TcpListener(localIp, localPort);
			server.Start();

			TcpClient client = server.AcceptTcpClient();
			byte[] buffer = new byte[client.Client.ReceiveBufferSize];
			client.Client.Receive(buffer);

			server.Stop();
			client.Close();

			return buffer;
		}
	}
}