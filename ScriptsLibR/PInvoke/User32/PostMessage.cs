using System;
using System.Runtime.InteropServices;

namespace ScriptsLibR.PInvoke
{
	public static partial class User32
	{
		[DllImport("user32.dll")]
		public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
	}
}
