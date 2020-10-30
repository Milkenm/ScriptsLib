using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlComboBox
	{
		[DllImport("user32.dll")]
		internal static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

		/// <summary>Sets the heigh of the ComboBox.</summary>
		/// <param name="cb">The ComboBox to be resized.</param>
		/// <param name="height">The height to be applied to the selected ComboBox.</param>
		/// https://stackoverflow.com/a/32165678
		public static void ResizeComboBox(ComboBox cb, int height)
		{
			SendMessage(cb.Handle, 0x153, -1, height - 6);
			cb.Refresh();
		}
	}
}
