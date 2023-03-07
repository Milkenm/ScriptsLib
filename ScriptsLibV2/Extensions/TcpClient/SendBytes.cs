namespace ScriptsLibV2.Extensions
{
	public static partial class TcpClientExtensions
	{
		public static void SendBytes(this System.Net.Sockets.TcpClient client, byte[] bytes)
		{
			client.GetStream().Write(bytes, 0, bytes.Length);
		}
	}
}