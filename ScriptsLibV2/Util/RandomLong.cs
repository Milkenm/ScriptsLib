using System;

namespace ScriptsLibV2.Util
{
	public partial class Utils
	{
		/// <summary>
		/// From <see href="https://stackoverflow.com/a/6651661"/>.
		/// </summary>
		/// <param name="min">The minimum number.</param>
		/// <param name="max">The maximum number.</param>
		/// <returns>A random <see cref="long"/> between "min" and "max".</returns>
		public static long RandomLong(long min, long max)
		{
			byte[] buf = new byte[8];
			new Random().NextBytes(buf);
			long longRand = BitConverter.ToInt64(buf, 0);

			return Math.Abs(longRand % (max - min)) + min;
		}
	}
}
