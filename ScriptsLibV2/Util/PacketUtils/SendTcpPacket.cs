using System.Net.Sockets;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2.Util
{
	public static partial class PacketUtils
	{
		/// <summary>Sends a TCP packet.</summary>
		/// <param name="remoteHost">The IP or Hostname of the computer to send the message to.</param>
		/// <param name="remotePort">The port of the computer to send the message to.</param>
		/// <param name="message">The message to send.</param>
		public static void SendTcpPacket(string remoteHost, int remotePort, string message)
		{
			using (TcpClient client = new TcpClient(remoteHost, remotePort))
			{
				client.SendString(message);
			}
		}
	}
}