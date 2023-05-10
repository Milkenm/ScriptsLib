using System.Diagnostics;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		/// <summary>
		/// Uses [<see cref="ConditionalAttribute"/>("DEBUG")] to check if debugging is enabled.
		/// </summary>
		/// <returns><see langword="true"/> if debugging is enabled, else <see langword="false"/></returns>
		public static bool IsDebugEnabled()
		{
#if DEBUG
			return true;
#else
			return false;
#endif
		}
	}
}
