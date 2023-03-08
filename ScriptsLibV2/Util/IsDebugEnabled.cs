﻿using System.Diagnostics;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		private static bool Debugging;

		public static bool IsDebugEnabled()
		{
			CheckDebugMode();
			return Debugging;
		}

		[Conditional("DEBUG")]
		private static void CheckDebugMode()
		{
			Debugging = true;
		}
	}
}