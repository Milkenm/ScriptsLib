using System.Net.Sockets;

namespace ScriptsLib.Extensions
{
	public static partial class TcpClientExtensions
	{
		public static void SendString(this TcpClient client, string str)
		{
			SendBytes(client, str.ToBytes());
		}
	}
}