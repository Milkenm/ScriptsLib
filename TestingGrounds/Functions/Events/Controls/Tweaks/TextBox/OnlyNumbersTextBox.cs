﻿#region Usings
using System;

using ScriptsLib.Controls.Tweaks;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_OnlyNumbersTextBox()
		{
			try
			{
				if (MainForm.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Checked == true)
				{
					SlTextBox.OnlyNumbersTextBox(MainForm.textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers, false);
				}
				else
				{
					SlTextBox.OnlyNumbersTextBox(MainForm.textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers, false, false);
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}
