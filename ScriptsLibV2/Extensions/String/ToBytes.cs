using System.Text;

namespace ScriptsLibV2.Extensions
{
	public static partial class StringExtensions
	{
		public static byte[] ToBytes(this string text)
		{
			return Encoding.UTF8.GetBytes(text);
		}
	}
}