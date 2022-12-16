using System;
using System.Runtime.InteropServices;

namespace ScriptsLibV2.PInvoke
{
	public static partial class User32
	{
		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);
	}
}
