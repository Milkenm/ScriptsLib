using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptsLibR.Util
{
	public static partial class Twemoji
	{
		public static string GetEmojiUrlFromCode(string emojiCode)
		{
			return string.Format("https://raw.githubusercontent.com/twitter/twemoji/master/assets/72x72/{0}.png", emojiCode);
		}
	}
}
