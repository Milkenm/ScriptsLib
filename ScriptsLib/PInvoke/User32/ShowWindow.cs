using System;
using System.Runtime.InteropServices;

namespace ScriptsLib.PInvoke
{
	public static partial class User32
	{
		[DllImport("user32.dll")]
		internal static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

		internal enum WindowShowStyle : uint
		{
			Hide = 0,
			ShowNormal = 1,
			ShowMinimized = 2,
			Maximize = 3,
			ShowNormalNoActivate = 4,
			Show = 5,
			Minimize = 6,
			ShowMinNoActivate = 7,
			ShowNoActivate = 8,
			Restore = 9,
			ShowDefault = 10,
			ForceMinimized = 11
		}
	}
}
