using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptsLibV2.Util
{
	public static partial class TwemojiUtils
	{
		public static string GetEmojiUrlFromCode(string emojiCode)
		{
			return string.Format("https://raw.githubusercontent.com/twitter/twemoji/master/assets/72x72/{0}.png", emojiCode);
		}
	}
}
