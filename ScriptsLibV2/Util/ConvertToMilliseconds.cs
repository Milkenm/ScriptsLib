using System;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		public static long ConvertToMilliseconds(int seconds = 0, int minutes = 0, int hours = 0, int days = 0)
		{
			TimeSpan ts = new TimeSpan(days, hours, minutes, seconds);
			return (long)ts.TotalMilliseconds;
		}
	}
}
