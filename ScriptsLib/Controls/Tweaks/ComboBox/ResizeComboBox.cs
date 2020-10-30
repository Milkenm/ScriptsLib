using ScriptsLib.PInvoke;

using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlComboBox
	{
		/// <summary>Sets the heigh of the ComboBox.</summary>
		/// <param name="cb">The ComboBox to be resized.</param>
		/// <param name="height">The height to be applied to the selected ComboBox.</param>
		/// https://stackoverflow.com/a/32165678
		public static void ResizeComboBox(ComboBox cb, int height)
		{
			User32.SendMessage(cb.Handle, 0x153, -1, height - 6);
			cb.Refresh();
		}
	}
}
