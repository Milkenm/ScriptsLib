#region Usings
using System;

using ScriptsLib.Controls.Tweaks;

using static TestingGrounds.Functions;
using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ResizeComboBox()
		{
			try
			{
				if (_MainForm.comboBox_controls_comboBox_resizeComboBox_resize.Height == 37)
				{
					SlComboBox.ResizeComboBox(_MainForm.comboBox_controls_comboBox_resizeComboBox_resize, 21);
				}
				else
				{
					SlComboBox.ResizeComboBox(_MainForm.comboBox_controls_comboBox_resizeComboBox_resize, 37);
				}

				_MainForm.button_controls_comboBox_resizeComboBox_resize.Text = $"Resize {_MainForm.button_controls_comboBox_resizeComboBox_resize.Height} | {_MainForm.comboBox_controls_comboBox_resizeComboBox_resize.Height}";
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}