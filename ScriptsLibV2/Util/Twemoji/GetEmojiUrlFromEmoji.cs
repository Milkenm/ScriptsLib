﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ScriptsLibV2.Util
{
	public static partial class TwemojiUtils
	{
		public static string GetEmojiUrlFromEmoji(string emoji)
		{
			return GetEmojiUrlFromCode(GetEmojiCode(emoji));
		}
	}
}