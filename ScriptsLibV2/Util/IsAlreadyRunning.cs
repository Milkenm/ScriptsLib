using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		/// <summary>Returns true is "this" application is running, else false.</summary>
		public static bool IsThisApplicationAlreadyRunning()
		{
			Regex filter = new Regex(".exe");
			return Process.GetProcessesByName(filter.Replace(AppDomain.CurrentDomain.FriendlyName, "")).Length > 1;
		}
	}
}