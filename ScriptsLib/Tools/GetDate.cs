#region Usings
using System;
#endregion Usings



namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Get current time and date. ([DD] Day || [MM] Month || [YYYY] Year || [hh] - Hour || [mm] Minute || [ss] Second || [ms] Millisecond.</summary>
		/// <param name="format">The format to return the date.</param>
		public static string GetDate(string format = "DD/MM/YYYY - hh:mm:ss (.ms)")
		{
			if (format.Contains("DD"))
			{
				string day = Convert.ToString(DateTime.Now.Day);
				if (day.Length < 2)
				{
					day = 0 + day;
				}

				format.Replace("DD", day);
			}

			if (format.Contains("MM"))
			{
				string month = Convert.ToString(DateTime.Now.Month);
				if (month.Length < 2)
				{
					month = 0 + month;
				}

				format.Replace("MM", month);
			}

			if (format.Contains("YYYY"))
			{
				string year = Convert.ToString(DateTime.Now.Year);

				format.Replace("YYYY", year);
			}

			if (format.Contains("hh"))
			{
				string hour = Convert.ToString(DateTime.Now.Hour);
				if (hour.Length < 2)
				{
					hour = 0 + hour;
				}

				format.Replace("hh", hour);
			}

			if (format.Contains("mm"))
			{
				string minute = Convert.ToString(DateTime.Now.Minute);
				if (minute.Length < 2)
				{
					minute = 0 + minute;
				}

				format.Replace("mm", minute);
			}

			if (format.Contains("ss"))
			{
				string second = Convert.ToString(DateTime.Now.Second);
				if (second.Length < 2)
				{
					second = 0 + second;
				}

				format.Replace("ss", second);
			}

			if (format.Contains("ms"))
			{
				string millisecond = Convert.ToString(DateTime.Now.Millisecond);
				if (millisecond.Length < 2)
				{
					millisecond = 00 + millisecond;
				}
				else if (millisecond.Length < 3)
				{
					millisecond = 0 + millisecond;
				}

				format.Replace("ms", millisecond);
			}

			return format;
		}
	}
}
