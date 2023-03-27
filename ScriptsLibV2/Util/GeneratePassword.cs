using System;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		public const string DefaultPasswordCharacterSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

		/// <summary>Generates a password (or call it string with random chars).</summary>
		/// <param name="size">The amount of characters.</param>
		/// <param name="allowedChars">The characters to be used to make the password.</param>
		public static string GeneratePassword(long size = 16, string allowedChars = DefaultPasswordCharacterSet)
		{
			string password = null;
			Random rand = new Random();

			for (long i = 0; i < size; i++)
			{
				password = $"{password}{allowedChars[rand.Next(allowedChars.Length - 1)]}";
			}
			return password;
		}
	}
}
