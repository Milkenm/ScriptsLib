using System.Net.Sockets;

namespace ScriptsLibR.Extensions
{
	public static partial class TcpClientExtensions
	{
		public static void SendString(this TcpClient client, string str)
		{
			SendBytes(client, str.ToBytes());
		}
	}
}