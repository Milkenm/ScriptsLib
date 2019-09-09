#region Usings
using ScriptsLib.nNetwork;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_SendTcpPacket()
		{
			Packets.SendTcpPacket("127.0.0.1", 69, "Hello!");
		}
	}
}