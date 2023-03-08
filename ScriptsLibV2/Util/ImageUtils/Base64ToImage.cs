using System;
using System.Drawing;
using System.IO;


namespace ScriptsLibV2.Util
{
	public static partial class ImageUtils
	{
		public static Image Base64ToImage(string base64)
		{
			byte[] imageBytes = Convert.FromBase64String(base64);
			return new Bitmap(new MemoryStream(imageBytes));
		}
	}
}
