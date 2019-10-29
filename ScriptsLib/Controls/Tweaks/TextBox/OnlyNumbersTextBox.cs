#region Usings
using System;
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlTextBox
	{
		/// <summary>Makes the TextBox only accept numbers.</summary>
		/// <param name="_TextBox">The TextBox that will only accept numbers.</param>
		/// <param name="_Decimal">Does the TextBox accept decimal numbers?</param>
		/// <param name="_Enabled">Toggle between number only and text mode.</param>
		public static void OnlyNumbersTextBox(TextBox _TextBox, bool _Decimal = false, bool _Enabled = true)
		{
			_TextBox.KeyPress += new KeyPressEventHandler((_Sender, _Event) => OnlyNumbersTextBoxEvent(_Sender, _Event, _Decimal, _Enabled));
		}

		#region Type Event
		private static void OnlyNumbersTextBoxEvent(object _Sender, KeyPressEventArgs _Event, bool _Decimal, bool _Enabled)
		{
			///
			// https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
			///



			if (_Enabled == true)
			{
				if (!Char.IsControl(_Event.KeyChar) && !Char.IsDigit(_Event.KeyChar) && _Event.KeyChar != '.')
				{
					_Event.Handled = true;
				}

				if (_Event.KeyChar == '.' && (_Sender as TextBox).Text.IndexOf('.') > -1 || _Event.KeyChar == '.' && _Decimal == false)
				{
					_Event.Handled = true;
				}
			}
		}
		#endregion Type Event
	}
}
