#region Usings
using System.Net;
using System.Net.Sockets;
using System.Text;
#endregion Usings



namespace ScriptsLib.Network
{
	public static partial class Packets
	{
		/// <summary>Waits for a TCP packet.</summary>
		/// <param name="_LocalIp">The local IP to create the server on.</param>
		/// <param name="_LocalPort">The local port to create the server on.</param>
		public static string WaitTcpPacket(IPAddress _LocalIp, int _LocalPort)
		{
			// Create the server.
			TcpListener _Server = new TcpListener(_LocalIp, _LocalPort);
			_Server.Start();

			// Wait for a message...
			TcpClient _Client = _Server.AcceptTcpClient();
			// ...then store it.
			NetworkStream _Stream = _Client.GetStream();

			// Parse the message.
			byte[] _Buffer = new byte[256];
			string _Message = Encoding.ASCII.GetString(_Buffer, 0, _Stream.Read(_Buffer, 0, _Buffer.Length));

			// Close everything.
			_Server.Stop();
			_Client.Close();
			_Stream.Close();

			// Return the message.
			return _Message;
		}
	}
}
