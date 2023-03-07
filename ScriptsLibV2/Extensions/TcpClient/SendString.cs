namespace ScriptsLibV2.Extensions
{
	public static partial class TcpClientExtensions
	{
		public static void SendString(this System.Net.Sockets.TcpClient client, string str)
		{
			SendBytes(client, str.ToBytes());
		}
	}
}