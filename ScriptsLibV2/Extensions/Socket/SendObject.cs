using System.Net.Sockets;

namespace ScriptsLibV2.Extensions
{
	public static partial class SocketExtensions
	{
		public static void SendObject(this Socket socket, object obj)
		{
			socket.Send(obj.ToByteArray());
		}
	}
}
