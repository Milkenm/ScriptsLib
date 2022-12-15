using NUnit.Framework;

using ScriptsLibR.Util;

namespace SlTestingR.TEST_Utils
{
	internal class GeneratePassword
	{
		private readonly int CustomPasswordSize = 5;
		private readonly string CustomPasswordCharacters = "a";

		[Test]
		public void TEST_GeneratePassword_Default()
		{
			string firstPassword = Utils.GeneratePassword();
			string secondPassword = Utils.GeneratePassword();
			Assert.IsTrue(firstPassword != secondPassword && firstPassword.Length == 16);
		}

		[Test]
		public void TEST_GeneratePassword_CustomSize()
		{
			string password = Utils.GeneratePassword(CustomPasswordSize);
			Assert.AreEqual(password.Length, CustomPasswordSize);
		}

		[Test]
		public void TEST_GeneratePassword_CustomCharacters()
		{
			string password = Utils.GeneratePassword(CustomPasswordCharacters);
			Assert.AreEqual(password.Replace(CustomPasswordCharacters, "").Length, 0);
		}

		[Test]
		public void TEST_GeneratePassword_CustomSizeAndCharacters()
		{
			string password = Utils.GeneratePassword(CustomPasswordSize, CustomPasswordCharacters);
			Assert.IsTrue(password.Length == CustomPasswordSize && password.Replace(CustomPasswordCharacters, "").Length == 0);
		}
	}
}
