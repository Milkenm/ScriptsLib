#region Usings
using System.Net;
using System.Net.Sockets;
using System.Text;
#endregion Usings



namespace ScriptsLib.nNetwork
{
	public static partial class Packets
	{
		public static string WaitUdpPacket(int _LocalPort)
		{
			// Create the server.
			UdpClient _Client = new UdpClient(_LocalPort, AddressFamily.InterNetwork);
			IPEndPoint _EndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 70);

			// Wait for the message.
			byte[] _Received = _Client.Receive(ref _EndPoint);

			// Parse the message...
			byte[] _Buffer = new byte[256];
			// ...and save it.
			string _Message = Encoding.ASCII.GetString(_Received, 0, _Received.Length);

			// Close everything.
			_Client.Close();

			// Return the message.
			return _Message;
		}
	}
}
