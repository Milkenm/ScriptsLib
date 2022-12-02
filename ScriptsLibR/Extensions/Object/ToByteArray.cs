using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ScriptsLibR.Extensions
{
	public static partial class ObjectExtensions
	{
		/// <summary>Converts an object to a byte array.</summary>
		/// <param name="obj">The object to convert to a byte array.</param>
		/// https://stackoverflow.com/a/18205093
		public static byte[] ToByteArray(this object obj)
		{
			if (obj != null)
			{
				using (MemoryStream ms = new MemoryStream())
				{
					BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(ms, obj);

					return ms.ToArray();
				}
			}
			else
			{
				return null;
			}
		}
	}
}