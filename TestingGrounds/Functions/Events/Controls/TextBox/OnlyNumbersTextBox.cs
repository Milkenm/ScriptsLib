#region Usings
using System;

using ScriptsLib.nControls;

using static TestingGrounds.Functions;
using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_OnlyNumbersTextBox()
		{
			try
			{
				if (_MainForm.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Checked == true)
				{
					SlTextBox.OnlyNumbersTextBox(_MainForm.textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers, false);
				}
				else
				{
					SlTextBox.OnlyNumbersTextBox(_MainForm.textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers, false, false);
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}
