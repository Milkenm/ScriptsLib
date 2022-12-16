using System.Net.Sockets;

namespace ScriptsLibV2.Extensions
{
	public static partial class TcpClientExtensions
	{
		public static void SendString(this TcpClient client, string str)
		{
			SendBytes(client, str.ToBytes());
		}
	}
}