#region Usings
using System.Net.Sockets;
using System.Text;
#endregion Usings



namespace ScriptsLib.Network
{
	public static partial class Packets
	{
		#region Send UDP Packet
		public static void SendUdpPacket(string _RemoteHost, int _RemotePort, string _Message)
		{
			// Create a UDP client.
			UdpClient _Client = new UdpClient(_RemoteHost, _RemotePort);

			// Convert the message...
			byte[] _Data = Encoding.ASCII.GetBytes(_Message);
			// ...and then send it.
			_Client.Send(_Data, _Data.Length);

			// Close everything.
			_Client.Close();
		}
		#endregion Send UDP Packet
	}
}
