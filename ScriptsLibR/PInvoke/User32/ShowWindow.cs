using System;
using System.Runtime.InteropServices;

namespace ScriptsLibR.PInvoke
{
	public static partial class User32
	{
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

		public enum WindowShowStyle : uint
		{
			Hide,
			ShowNormal,
			ShowMinimized,
			Maximize,
			ShowNormalNoActivate,
			Show,
			Minimize,
			ShowMinNoActivate,
			ShowNoActivate,
			Restore,
			ShowDefault,
			ForceMinimized
		}
	}
}
