#region Usings
using ScriptsLib.Network;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_SendTcpPacket()
		{
			Packets.SendTcpPacket(Static.MainForm.textBox_network_packets_sendTcpPacket_remoteIp.Text, (int)Static.MainForm.numeric_network_packets_sendTcpPacket_remotePort.Value, Static.MainForm.textBox_network_packets_sendTcpPacket_message.Text);
		}
	}
}