using System.Net;
using System.Net.Sockets;

namespace ScriptsLib.Network
{
	public static partial class Packets
	{
		/// <summary>Waits for a TCP packet.</summary>
		/// <param name="localIp">The local IP to create the server on.</param>
		/// <param name="localPort">The local port to create the server on.</param>
		public static byte[] WaitTcpPacket(IPAddress localIp, short localPort)
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