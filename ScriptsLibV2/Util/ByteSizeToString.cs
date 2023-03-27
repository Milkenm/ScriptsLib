using System;
using System.Globalization;

namespace ScriptsLibV2.Util
{
	public partial class Utils
	{
		public static string ByteSizeToString(double size)
		{
			int div = 0;

			while (size >= 1024)
			{
				size /= 1024;
				div++;
			}

			string suffix = "B";
			switch (div)
			{
				case 1: suffix = "KB"; break;
				case 2: suffix = "MB"; break;
				case 3: suffix = "GB"; break;
				case 4: suffix = "TB"; break;
				case 5: suffix = "PB"; break;
			}

			NumberFormatInfo nfi = new NumberFormatInfo();
			nfi.NumberDecimalSeparator = ".";

			return $"{Math.Round(size, 2).ToString(nfi)} {suffix}";
		}
	}
}
