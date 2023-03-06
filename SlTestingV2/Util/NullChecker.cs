using System;

using NUnit.Framework;

using ScriptsLibV2.Util;

namespace Util
{
	internal class Util_NullChecker
	{
		private readonly string nullString = null;
		private readonly string notNullString = "Not null.";
		private readonly string emptyString = "";
		private readonly string whitespaceString = "     ";

		[Test]
		public void TEST_NullChecker_NullString()
		{
			Assert.Catch<ArgumentNullException>(() => Utils.NullChecker(true, (nullString, nameof(nullString))));
		}

		[Test]
		public void TEST_NullChecker_NotNullString()
		{
			Utils.NullChecker(true, (notNullString, nameof(notNullString)));
			Assert.Pass();
		}

		[Test]
		public void TEST_NullChecker_EmptyString_Fail()
		{
			Assert.Catch<ArgumentNullException>(() => Utils.NullChecker(true, (emptyString, nameof(emptyString))));
		}

		[Test]
		public void TEST_NullChecker_EmptyString_Pass()
		{
			Utils.NullChecker(false, (emptyString, nameof(emptyString)));
			Assert.Pass();
		}

		[Test]
		public void TEST_NullChecker_WhitespaceString_Fail()
		{
			Assert.Catch<ArgumentNullException>(() => Utils.NullChecker(true, (whitespaceString, nameof(whitespaceString))));
		}

		[Test]
		public void TEST_NullChecker_WhitesapceString_Pass()
		{
			Utils.NullChecker(false, (whitespaceString, nameof(whitespaceString)));
			Assert.Pass();
		}
	}
}
