using System.Net.Sockets;

namespace ScriptsLibV2.Extensions
{
	public static partial class NetworkStreamExtensions
	{
		public static void SendObject(this NetworkStream stream, object obj)
		{
			stream.SendBytes(obj.ToByteArray());
		}
	}
}
