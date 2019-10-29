#region Usings
using ScriptsLib.Network;

using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_SendUdpPacket()
		{
			Packets.SendUdpPacket(_MainForm.textBox_network_packets_sendUdpPacket_remoteIp.Text, (int)_MainForm.numeric_network_packets_sendUdpPacket_remotePort.Value, _MainForm.textBox_network_packets_sendUdpPacket_message.Text);
		}
	}
}