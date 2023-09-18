using System.Net.Sockets;

namespace ScriptsLibV2.Extensions
{
	public static partial class SocketExtensions
	{
		public static long SendObject(this Socket socket, object obj)
		{
			byte[] objBytes = obj.ToByteArray();
			_ = socket.Send(objBytes, objBytes.Length, SocketFlags.None);
			return objBytes.LongLength;
		}

		public static long SendObjectAsync(this Socket socket, object obj)
		{
			byte[] objBytes = obj.ToByteArray();

			SocketAsyncEventArgs sendEventArgs = new SocketAsyncEventArgs();
			sendEventArgs.SetBuffer(objBytes, 0, objBytes.Length);

			_ = socket.SendAsync(sendEventArgs);
			return objBytes.Length;
		}

		public static long SendObjectAsync2(this Socket socket, object obj)
		{
			byte[] objBytes = obj.ToByteArray();

			_ = socket.BeginSend(objBytes, 0, objBytes.Length, SocketFlags.None, null, null);

			return objBytes.Length;
		}
	}
}
