#region Events
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScriptsLib.Network;

using static TestingGrounds.Values;
#endregion Events



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_WaitUdpPacket()
		{
			_MainForm.button_network_packets_waitUdpPacket_wait.Enabled = false;
			new Task(new Action(() =>
			{
				while (true)
				{
					MessageBox.Show("Received: \n\n\n" + Packets.WaitUdpPacket((int)_MainForm.numeric_network_packets_waitUdpPacket_localPort.Value), "Wait UDP Packet");
				}
			})).Start();
		}
	}
}