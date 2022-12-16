using System.Net.Sockets;

namespace ScriptsLibV2.Extensions
{
	public static partial class UdpClientExtensions
	{
		public static void SendString(this UdpClient client, string str)
		{
			SendBytes(client, str.ToBytes());
		}
	}
}