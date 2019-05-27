#region Usings
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScriptsLib.Dev;

using static ScriptsLib.Dev.Debug;
#endregion Usings



namespace ScriptsLib.Controls
{
	public class Controls
	{
		#region Refs
		// # ================================================================================================ #
		Debug _Debug = new Debug();
		// # ================================================================================================ #
		#endregion Refs












		#region Resize ComboBox
		///
		// https://stackoverflow.com/questions/3158004/how-do-i-set-the-height-of-a-combobox
		///



		// # ================================================================================================ #
		[DllImport("user32.dll")]
		static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
		private const int CB_SETITEMHEIGHT = 0x153;

		public void ResizeComboBox(ComboBox _ComboBox, int _Hight)
		{
			try
			{
				SendMessage(_ComboBox.Handle, CB_SETITEMHEIGHT, -1, _Hight - 6);
				_ComboBox.Refresh();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
		// # ================================================================================================ #
		#endregion Resize ComboBox
	}
}
