using ScriptsLib.PInvoke;

using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlForm
	{
		public static void AllowDrag(Form form)
		{
			form.MouseDown += new MouseEventHandler((s, e) => AllowDragEvent(e, form));
		}

		private static void AllowDragEvent(MouseEventArgs e, Control form)
		{
			if (e.Button == MouseButtons.Left)
			{
				User32.ReleaseCapture();
				User32.SendMessage(form.Handle, 0xA1, 0x2, 0);
			}
		}
	}
}
