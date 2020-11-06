using System;
using System.Runtime.InteropServices;

namespace ScriptsLib.PInvoke
{
	public static partial class User32
	{
		[DllImport("user32.dll")]
		internal static extern bool SetForegroundWindow(IntPtr hWnd);
	}
}
