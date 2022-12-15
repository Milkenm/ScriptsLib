using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ScriptsLibR.Util
{
	public static partial class Twemoji
	{
		public static string GetEmojiUrlFromEmoji(string emoji)
		{
			return GetEmojiUrlFromCode(GetEmojiCode(emoji));
		}
	}
}
