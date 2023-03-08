using System.Drawing;

using ScriptsLibV2.Util;

namespace ScriptsLibV2.Extensions
{
	public static partial class StringExtensions
	{
		public static Image ToImage(this string base64)
		{
			return ImageUtils.Base64ToImage(base64);
		}
	}
}
