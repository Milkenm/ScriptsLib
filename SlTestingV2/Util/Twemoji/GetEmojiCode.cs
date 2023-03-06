using NUnit.Framework;

using ScriptsLibV2.Util;

namespace Util
{
	internal class Twemoji_GetEmojiCode
	{
		private static readonly string Emoji = "🧵";
		private static readonly string ExpectedCode = "1f9f5";

		[Test]
		public void TEST_GetEmojiCode()
		{
			string code = TwemojiUtils.GetEmojiCode(Emoji);
			Assert.AreEqual(ExpectedCode, code);
		}
	}
}
