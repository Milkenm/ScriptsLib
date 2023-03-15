using System.IO;
using System.Reflection;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		public static string GetInstallationFolder()
		{
			return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
		}
	}
}
