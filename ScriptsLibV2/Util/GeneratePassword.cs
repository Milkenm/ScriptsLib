using System;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		/// <summary>Generates a 16 characters long password (or call it string with random chars) using a-Z 0-9.</summary>
		public static string GeneratePassword()
		{
			return GeneratePassword(16);
		}

		/// <summary>Generates a password (or call it string with random chars).</summary>
		/// <param name="size">The amount of characters.</param>
		public static string GeneratePassword(int size)
		{
			return GeneratePassword(size, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890");
		}

		/// <summary>Generates a password (or call it string with random chars).</summary>
		/// <param name="allowedChars">The characters to be used to make the password.</param>
		public static string GeneratePassword(string allowedChars)
		{
			return GeneratePassword(16, allowedChars);
		}

		/// <summary>Generates a password (or call it string with random chars).</summary>
		/// <param name="size">The amount of characters.</param>
		/// <param name="allowedChars">The characters to be used to make the password.</param>
		public static string GeneratePassword(int size, string allowedChars)
		{
			string password = null;
			Random rand = new Random();

			for (int i = 0; i < size; i++)
			{
				password = $"{password}{allowedChars[rand.Next(allowedChars.Length - 1)]}";
			}
			return password;
		}
	}
}
