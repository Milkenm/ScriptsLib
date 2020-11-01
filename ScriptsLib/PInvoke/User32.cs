﻿using System;
using System.Runtime.InteropServices;

namespace ScriptsLib.PInvoke
{
	public static class User32
	{
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
	}
}
