using System;
using System.Drawing;
using System.IO;

namespace ScriptsLibV2.Util
{
	public static partial class ImageUtils
	{
		public static string ImageToBase64(Image image)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				image.Save(ms, image.RawFormat);
				return Convert.ToBase64String(ms.ToArray());
			}
		}
	}
}
