#region Usings
using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScriptsLib.Network;

using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_WaitTcpPacket()
		{
			_MainForm.button_network_packets_waitTcpPacket_wait.Enabled = false;
			new Task(new Action(() =>
			{
				while (true)
				{
					MessageBox.Show("Received: \n\n\n" + Packets.WaitTcpPacket(IPAddress.Parse("127.0.0.1"), (int)Static._MainForm.numeric_network_packets_waitTcpPacket_localPort.Value), "Wait TCP Packet");
				}
			})).Start();
		}
	}
}