using ScriptsLib.Extensions;

using System.Net.Sockets;

namespace ScriptsLib.Network
{
	public static partial class Packets
	{
		/// <summary>Sends a UDP packet.</summary>
		/// <param name="remoteHost">The IP or Hostname of the computer to send the message to.</param>
		/// <param name="remotePort">The port of the computer to send the message to.</param>
		/// <param name="message">The message to send.</param>
		public static void SendUdpPacket(string remoteHost, int remotePort, string message)
		{
			using (UdpClient client = new UdpClient(remoteHost, remotePort))
			{
				client.SendString(message);
			}
		}
	}
}