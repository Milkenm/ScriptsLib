using NUnit.Framework;

using ScriptsLibR.Util;

namespace SlTestingR. TEST_Utils
{
	internal class Hash
	{
		private static readonly string Text = "test";
		private static readonly string ExpectedResult = "9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08";

		[Test]
		public void TEST_Hash()
		{
			string hashed = Utils.Hash(Text);
			Assert.AreEqual(hashed, ExpectedResult);
		}
	}
}
