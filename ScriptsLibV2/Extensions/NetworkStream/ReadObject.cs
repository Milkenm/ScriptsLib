using System.Net.Sockets;
using System.Threading.Tasks;

namespace ScriptsLibV2.Extensions
{
	public static partial class NetworkStreamExtensions
	{
		public static T ReadObject<T>(this NetworkStream stream, int bufferSize = 256)
		{
			byte[] buffer = new byte[bufferSize];

			int read = stream.Read(buffer, 0, bufferSize);

			if (read == 0) return default(T);
			return buffer.ToObject<T>();
		}

		public static async Task<T> ReadObjectAsync<T>(this NetworkStream stream, int bufferSize = 256)
		{
			byte[] buffer = new byte[bufferSize];

			int read = await stream.ReadAsync(buffer, 0, bufferSize);

			if (read == 0) return default(T);
			return buffer.ToObject<T>();
		}
	}
}
