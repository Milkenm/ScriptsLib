using System;

namespace ScriptsLibV2.Util
{
	public partial class Utils
	{
		/// <summary>
		/// Generates a random <see langword="long"/> between <paramref name="min"/> and <paramref name="max"/>.
		/// </summary>
		/// <remarks>From <see href="https://stackoverflow.com/a/6651661"/>.</remarks>
		/// <param name="min">The minimum number.</param>
		/// <param name="max">The maximum number.</param>
		/// <param name="random">An existing <see cref="Random"/> instance.</param>
		/// <returns>A random <see cref="long"/> between <paramref name="min"/> and <paramref name="max"/>.</returns>
		public static long RandomLong(long min, long max, Random random)
		{
			byte[] buffer = new byte[8];
			random.NextBytes(buffer);
			long randomLong = BitConverter.ToInt64(buffer, 0);

			return Math.Abs(randomLong % (max + 1 - min)) + min;
		}

		/// <inheritdoc cref="RandomLong(long, long, Random)"/>
		public static long RandomLong(long min, long max) => RandomLong(min, max, new Random());
	}
}
