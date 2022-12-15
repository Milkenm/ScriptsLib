using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ScriptsLibR.Util
{
	public static partial class Twemoji
	{
		public static string GetEmojiCode(string emoji)
		{
			string decimalEncoded = HttpUtility.HtmlEncode(emoji);
			int dec = int.Parse(decimalEncoded.Substring(2, decimalEncoded.Length - 3));
			return string.Format("{0:X}", dec).ToLower();
		}
	}
}
