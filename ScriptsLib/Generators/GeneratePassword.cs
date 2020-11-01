using System;

namespace ScriptsLib
{
	public static partial class Generators
	{
		/// <summary>Generates a password (or call it string with random chars).</summary>
		/// <param name="size">The amount of characters.</param>
		/// <param name="allowedChars">The characters to be used to make the password.</param>
		public static string GeneratePassword(int size, string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890")
		{
			string password = null;
			Random rand = new Random();

			for (int i = 0; i < size; i++)
			{
				size--;
				password = $"{password}{allowedChars[rand.Next(allowedChars.Length - 1)]}";
			}
			return password;
		}
	}
}
