using NUnit.Framework;

using ScriptsLibV2.Util;

namespace Util
{
	internal class Twemoji_GetEmojiUrlFromCode
	{
		private static readonly string EmojiCode = "1f9f5";
		private static readonly string ExpectedUrl = "https://raw.githubusercontent.com/twitter/twemoji/master/assets/72x72/1f9f5.png";

		[Test]
		public void TEST_GetEmojiUrlFromCode()
		{
			string emojiUrl = TwemojiUtils.GetEmojiUrlFromCode(EmojiCode);
			Assert.AreEqual(ExpectedUrl, emojiUrl);
		}
	}
}
