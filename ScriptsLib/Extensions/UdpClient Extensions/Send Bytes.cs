using System.Net.Sockets;

namespace ScriptsLib.Extensions
{
	public static partial class UdpClientExtensions
	{
		public static void SendBytes(this UdpClient client, byte[] bytes)
		{
			client.Send(bytes, bytes.Length);
		}
	}
}