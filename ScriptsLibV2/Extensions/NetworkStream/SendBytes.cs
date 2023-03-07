using System.Net.Sockets;

namespace ScriptsLibV2.Extensions
{
	public static partial class NetworkStreamExtensions
	{
		public static void SendBytes(this NetworkStream stream, byte[] bytes)
		{
			stream.Write(bytes, 0, bytes.Length);
		}
	}
}
