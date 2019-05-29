#region Usings
using System;
using System.Runtime.InteropServices;
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










		public class TextBox : Controls
		{
			#region Only Numbers
			// # ================================================================================================ #
			public void OnlyNumbers(System.Windows.Forms.TextBox _TextBox, bool _Enabled = true, bool _Decimal = false)
			{
				_TextBox.KeyPress += new KeyPressEventHandler((_Sender, _Event) => OnlyNumbersEvent(_Sender, _Event, _Decimal, _Enabled));
			}
			// # ================================================================================================ #
			private void OnlyNumbersEvent(object _Sender, KeyPressEventArgs _Event, bool _Decimal, bool _Enabled)
			{
				if (_Enabled == true)
				{
					if (!Char.IsControl(_Event.KeyChar) && !Char.IsDigit(_Event.KeyChar) && (_Event.KeyChar != '.'))
					{
						_Event.Handled = true;
					}

					if (_Decimal == true)
					{
						if ((_Event.KeyChar == '.') && ((_Sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
						{
							_Event.Handled = true;
						}
					}
				}
			}
			// # ================================================================================================ #
			#endregion Only Numbers
		}



		public class ComboBox : Controls
		{
			#region Resize
			///
			// https://stackoverflow.com/questions/3158004/how-do-i-set-the-height-of-a-combobox
			///



			// # ================================================================================================ #
			[DllImport("user32.dll")]
			static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
			private const int CB_SETITEMHEIGHT = 0x153;

			public void Resize(System.Windows.Forms.ComboBox _ComboBox, int _Hight)
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
			#endregion Resize
		}
	}
}
