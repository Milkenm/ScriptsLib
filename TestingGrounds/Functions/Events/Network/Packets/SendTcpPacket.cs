#region Usings
using ScriptsLib.nNetwork;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_SendTcpPacket()
		{
			Packets.SendTcpPacket(Values._MainForm.textBox_network_packets_sendTcpPacket_remoteIp.Text, (int)Values._MainForm.numeric_network_packets_sendTcpPacket_remotePort.Value, "Hello!");
		}
	}
}