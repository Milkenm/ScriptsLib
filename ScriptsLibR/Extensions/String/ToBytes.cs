using System.Text;

namespace ScriptsLibR.Extensions
{
	public static partial class StringExtensions
	{
		public static byte[] ToBytes(this string str)
		{
			return Encoding.UTF8.GetBytes(str);
		}
	}
}