using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ScriptsLib.Extensions
{
	public static class ByteExtensions
	{
		/// <summary>Converts a byte array to an object.</summary>
		/// <param name="byteArray">The byte array to convert to an object.</param>
		public static object ToObject(byte[] byteArray)
		{
			if (byteArray.Length > 0)
			{
				using (MemoryStream ms = new MemoryStream())
				{
					ms.Write(byteArray, 0, byteArray.Length);
					ms.Seek(0, SeekOrigin.Begin);

					BinaryFormatter bf = new BinaryFormatter();
					return bf.Deserialize(ms);
				}
			}
			else
			{
				return null;
			}
		}
	}
}
