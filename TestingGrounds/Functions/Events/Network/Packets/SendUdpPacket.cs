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
			Packets.SendUdpPacket(MainForm.textBox_network_packets_sendUdpPacket_remoteIp.Text, (int)MainForm.numeric_network_packets_sendUdpPacket_remotePort.Value, MainForm.textBox_network_packets_sendUdpPacket_message.Text);
		}
	}
}