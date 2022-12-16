using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ScriptsLibV2.Extensions
{
	public static partial class ByteExtensions
	{
		/// <summary>Converts a byte array to an object.</summary>
		/// <param name="byteArray">The byte array to convert to an object.</param>
		public static T ToObject<T>(this byte[] byteArray)
		{
			if (byteArray.Length > 0)
			{
				using (MemoryStream ms = new MemoryStream())
				{
					ms.Write(byteArray, 0, byteArray.Length);
					ms.Seek(0, SeekOrigin.Begin);

					BinaryFormatter bf = new BinaryFormatter();
					object obj = bf.Deserialize(ms);
					return (T)obj;
				}
			}
			else
			{
				return default;
			}
		}
	}
}