using System.Net.Sockets;

namespace ScriptsLibV2.Extensions
{
	public static partial class SocketExtensions
	{
		public static long SendObject(this Socket socket, object obj)
		{
			byte[] objBytes = obj.ToByteArray();
			socket.Send(objBytes);
			return objBytes.LongLength;
		}
	}
}
