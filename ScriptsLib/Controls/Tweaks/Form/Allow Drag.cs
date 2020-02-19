using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlForm
	{
		internal const int WM_NCLBUTTONDOWN = 0xA1;
		internal const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		internal static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		internal static extern bool ReleaseCapture();

		internal static void AllowDrag(MouseEventArgs e, Control ctrl)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(ctrl.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
