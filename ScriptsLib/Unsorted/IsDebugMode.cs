using System.Diagnostics;

namespace ScriptsLib.Unsorted
{
	public static class Unsorted
	{
		private static bool Debugging;

		public static bool IsDebugMode()
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
