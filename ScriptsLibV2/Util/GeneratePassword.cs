using System;
using System.Text;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		/// <summary>
		/// The default "allowedChars" used for <see cref="GeneratePassword(Random, long, string)"/> and <see cref="GeneratePassword(long, string)"/>.
		/// </summary>
		public const string DefaultPasswordCharacterSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

		/// <summary>
		/// Generates a password (or call it string with random chars).
		/// </summary>
		/// <param name="random">Existing <see cref="Random"/> instance.</param>
		/// <param name="size">The amount of characters.</param>
		/// <param name="allowedChars">The characters to be used to make the password.</param>
		public static string GeneratePassword(Random random, long size = 16, string allowedChars = DefaultPasswordCharacterSet)
		{
			StringBuilder passwordBuilder = new StringBuilder();
			for (long i = 0; i < size; i++)
			{
				passwordBuilder.Append(allowedChars[random.Next(allowedChars.Length - 1)]);
			}
			return passwordBuilder.ToString();
		}

		/// <inheritdoc cref="GeneratePassword(Random, long, string)"/>
		public static string GeneratePassword(long size = 16, string allowedChars = DefaultPasswordCharacterSet) => GeneratePassword(new Random(), size, allowedChars);
	}
}
