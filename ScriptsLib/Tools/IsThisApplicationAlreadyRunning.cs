using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Returns true is "this" application is running, else false.</summary>
		public static bool IsThisApplicationAlreadyRunning()
		{
			Regex regex = new Regex(".exe");

			int instances = 0;
			foreach (Process p in Process.GetProcessesByName(regex.Replace(AppDomain.CurrentDomain.FriendlyName, "")))
			{
				instances++;
			}

			return instances > 1;
		}
	}
}