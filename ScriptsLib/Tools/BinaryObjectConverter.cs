using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ScriptsLib
{
	public static partial class Tools
	{
		public static class BinaryObjectConverter
		{
			// https://stackoverflow.com/a/18205093
			/// <summary>Converts an object to a byte array.</summary>
			/// <param name="obj">The object to convert to a byte array.</param>
			public static byte[] ObjectToByteArray(object obj)
			{
				if (obj != null)
				{
					BinaryFormatter bf = new BinaryFormatter();

					using (MemoryStream ms = new MemoryStream())
					{
						bf.Serialize(ms, obj);
						return ms.ToArray();
					}
				}
				else
				{
					return null;
				}
			}

			/// <summary>Converts a byte array to an object.</summary>
			/// <param name="byteArray">The byte array to convert to an object.</param>
			public static object ByteArrayToObject(byte[] byteArray)
			{
				if (byteArray.Length > 0)
				{
					using (MemoryStream ms = new MemoryStream())
					{
						BinaryFormatter bf = new BinaryFormatter();

						ms.Write(byteArray, 0, byteArray.Length);
						ms.Seek(0, SeekOrigin.Begin);

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
}
