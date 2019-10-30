#region Usings
using System;

using ScriptsLib.Controls.Tweaks;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ResizeComboBox()
		{
			try
			{
				if (MainForm.comboBox_controls_comboBox_resizeComboBox_resize.Height == 37)
				{
					SlComboBox.ResizeComboBox(MainForm.comboBox_controls_comboBox_resizeComboBox_resize, 21);
				}
				else
				{
					SlComboBox.ResizeComboBox(MainForm.comboBox_controls_comboBox_resizeComboBox_resize, 37);
				}

				MainForm.button_controls_comboBox_resizeComboBox_resize.Text = $"Resize {MainForm.button_controls_comboBox_resizeComboBox_resize.Height} | {MainForm.comboBox_controls_comboBox_resizeComboBox_resize.Height}";
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}