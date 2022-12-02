using System.Diagnostics;

namespace ScriptsLibR.Utils
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
