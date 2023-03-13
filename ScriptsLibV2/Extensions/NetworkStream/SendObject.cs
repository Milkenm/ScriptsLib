using System.Net.Sockets;

namespace ScriptsLibV2.Extensions
{
	public static partial class NetworkStreamExtensions
	{
		public static long SendObject(this NetworkStream stream, object obj)
		{
			byte[] objBytes = obj.ToByteArray();
			stream.SendBytes(objBytes);
			return objBytes.LongLength;
		}
	}
}
