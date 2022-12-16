using NUnit.Framework;

using ScriptsLibV2.Util;

namespace SlTestingR.Util.Twemoji
{
	internal class GetEmojiUrlFromEmoji
	{
		private static readonly string Emoji = "🧵";
		private static readonly string ExpectedUrl = "https://raw.githubusercontent.com/twitter/twemoji/master/assets/72x72/1f9f5.png";

		[Test]
		public void TEST_GetEmojiUrlFromEmoji()
		{
			string emojiUrl = TwemojiUtils.GetEmojiUrlFromEmoji(Emoji);
			Assert.AreEqual(ExpectedUrl, emojiUrl);
		}
	}
}
