#region Usings
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScriptsLib.Resources.Lang;
using static ScriptsLib.Dev.Debug;
#endregion Usings



namespace ScriptsLib.Network
{
	public class Network
	{
		#region Wi-Fi
		// # ================================================================================================ #
		public class Wifi
		{
			#region Refs
			// # ================================================================================================ #
			Dev.Debug _Debug = new Dev.Debug();
			// # ================================================================================================ #
			#endregion Refs

			#region Connect
			// # ================================================================================================ #
			public void Connect(string _SSID, string _Password)
			{
				try
				{
					string _EESWPA2PSKAES_Template = String.Join("\n", File.ReadAllLines(@"Resources\Templates\Network\Wifi\EES_WPA2PSK_AES.xml"));
					string _AppdataXmlPath = new Resources.Values()._AppdataPath + @"Temp\WifiNetworkAdd.xml";

					Tools.Tools _Tools = new Tools.Tools();
					_EESWPA2PSKAES_Template = _Tools.ReplaceString(_EESWPA2PSKAES_Template, "{SSID}", _SSID);
					_EESWPA2PSKAES_Template = _Tools.ReplaceString(_EESWPA2PSKAES_Template, "{PASSWORD}", _Password);

					Directory.CreateDirectory(new Resources.Values()._AppdataPath + @"Temp\");
					File.WriteAllText(_AppdataXmlPath, _EESWPA2PSKAES_Template);

					_Tools.ExecuteCmdCommand($@"netsh wlan add profile filename=""{_AppdataXmlPath}"" interface=""Wi-Fi"" user=current");
				}
				catch (Exception _Exception)
				{
					_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				}

			}
			// # ================================================================================================ #
			#endregion Connect
		}
		// # ================================================================================================ #
		#endregion Wi-Fi



		#region Packets
		// # ================================================================================================ #
		public class Packets
		{
			#region Send TCP Packet
			// # ================================================================================================ #
			/// <summary>Sends a TCP packet.</summary>
			/// <param name="_RemoteHost">The IP or Hostname of the computer to send the message to.</param>
			/// <param name="_RemotePort">The port of the computer to send the message to.</param>
			/// <param name="_Message">The message to send.</param>
			public void SendTcpPacket(string _RemoteHost, int _RemotePort, string _Message)
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
			// # ================================================================================================ #
			#endregion Send TCP Packet



			#region Wait TCP Packet
			// # ================================================================================================ #
			/// <summary>Waits for a TCP packet.</summary>
			/// <param name="_LocalIp">The local IP to create the server on.</param>
			/// <param name="_LocalPort">The local port to create the server on.</param>
			public string WaitTcpPacket(IPAddress _LocalIp, int _LocalPort)
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
			// # ================================================================================================ #
			#endregion Wait TCP Packet



			#region Send UDP Packet
			public void SendUdpPacket(string _RemoteHost, int _RemotePort, string _Message)
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



			#region Wait UDP Packet
			public string WaitUdpPacket(int _LocalPort)
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
			#endregion Wait UDP Packet
		}
		// # ================================================================================================ #
		#endregion Packets
	}
}
