﻿using System.Net.Sockets;

namespace ScriptsLib.Extensions
{
	public static partial class TcpClientExtensions
	{
		public static void SendBytes(this TcpClient client, byte[] bytes)
		{
			client.GetStream().Write(bytes, 0, bytes.Length);
		}
	}
}