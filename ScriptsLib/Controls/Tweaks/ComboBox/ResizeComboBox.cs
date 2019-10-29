#region Usings
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using static ScriptsLib.Dev;
#endregion Usings

// # = #
// https://stackoverflow.com/questions/3158004/how-do-i-set-the-height-of-a-combobox
// # = #

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlComboBox
	{
		[DllImport("user32.dll")]
		internal static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

		/// <summary>Sets the heigh of the ComboBox.</summary>
		/// <param name="_ComboBox">The ComboBox to be resized.</param>
		/// <param name="_Hight">The height to be applied to the selected ComboBox.</param>
		public static void ResizeComboBox(ComboBox _ComboBox, int _Hight)
		{
			try
			{
				SendMessage(_ComboBox.Handle, 0x153, -1, _Hight - 6);
				_ComboBox.Refresh();
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
	}
}
