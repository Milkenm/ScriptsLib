using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlForm
	{
		public static void AllowDrag(Form form)
		{
			form.MouseDown += new MouseEventHandler((se, ev) => AllowDragEvent(ev, form));
		}




		internal const int WM_NCLBUTTONDOWN = 0xA1;
		internal const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		internal static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		internal static extern bool ReleaseCapture();

		private static void AllowDragEvent(MouseEventArgs e, Control form)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
