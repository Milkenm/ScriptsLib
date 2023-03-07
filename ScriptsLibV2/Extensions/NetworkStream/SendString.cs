using System.Net.Sockets;

namespace ScriptsLibV2.Extensions
{
	public static partial class NetworkStreamExtensions
	{
		public static void SendString(this NetworkStream stream, string str)
		{
			SendBytes(stream, str.ToBytes());
		}
	}
}
