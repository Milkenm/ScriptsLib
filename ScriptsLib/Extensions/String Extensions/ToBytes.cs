using System.Text;

namespace ScriptsLib.Extensions
{
	public static class StringExtensions
	{
		public static byte[] ToBytes(this string str)
		{
			return Encoding.UTF8.GetBytes(str);
		}
	}
}
