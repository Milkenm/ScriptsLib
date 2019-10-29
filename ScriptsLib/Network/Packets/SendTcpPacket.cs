#region Usings
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using ScriptsLib.Resources.Lang;
#endregion Usings



namespace ScriptsLib.Network
{
	public static partial class Packets
	{
		/// <summary>Sends a TCP packet.</summary>
		/// <param name="_RemoteHost">The IP or Hostname of the computer to send the message to.</param>
		/// <param name="_RemotePort">The port of the computer to send the message to.</param>
		/// <param name="_Message">The message to send.</param>
		public static void SendTcpPacket(string _RemoteHost, int _RemotePort, string _Message)
		{
			try
			{
				// Create a TCP client.
				TcpClient _Client = new TcpClient(_RemoteHost, _RemotePort);
				
				// Convert the message...
				byte[] _Data = Encoding.ASCII.GetBytes(_Message);
				// ...and then send it.
				NetworkStream _Stream = _Client.GetStream();
				_Stream.Write(_Data, 0, _Data.Length);

				// Close everything.
				_Stream.Close();
				_Client.Close();
			}
			catch (SocketException _SocketException)
			{
				MessageBox.Show(string.Format(Lang._ErrorSocketException, _SocketException.Message), Lang._ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
