using System.Drawing;

using ScriptsLibV2.Util;

namespace ScriptsLibV2.Extensions
{
	public static partial class ImageExtensions
	{
		public static string ToBase64(this Image image)
		{
			return ImageUtils.ImageToBase64(image);
		}
	}
}
