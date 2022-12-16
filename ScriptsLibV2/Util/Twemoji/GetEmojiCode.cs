using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ScriptsLibV2.Util
{
	public static partial class TwemojiUtils
	{
		public static string GetEmojiCode(string emoji)
		{
			string decimalEncoded = HttpUtility.HtmlEncode(emoji);
			int dec = int.Parse(decimalEncoded.Substring(2, decimalEncoded.Length - 3));
			return string.Format("{0:X}", dec).ToLower();
		}
	}
}
