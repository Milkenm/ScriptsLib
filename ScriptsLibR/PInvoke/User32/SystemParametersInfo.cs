using System.Runtime.InteropServices;

namespace ScriptsLibR.PInvoke
{
	public static partial class User32
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
	}
}
