#region Usings
using System;

using ScriptsLib;

using static TestingGrounds.Functions;
using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ToolsLog()
		{
			try
			{
				if (_MainForm.comboBox_tools_log_logType.SelectedIndex == 0) // INFO
				{
					Tools.Log(_MainForm.textBox_tools_log_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", _MainForm.textBox_tools_log_logSource.Text, Tools.LogType.Info).GetAwaiter();
				}
				else if (_MainForm.comboBox_tools_log_logType.SelectedIndex == 1) // ERROR
				{
					Tools.Log(_MainForm.textBox_tools_log_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", _MainForm.textBox_tools_log_logSource.Text, Tools.LogType.Error).GetAwaiter();
				}
				else if (_MainForm.comboBox_tools_log_logType.SelectedIndex == 2) // WARNING
				{
					Tools.Log(_MainForm.textBox_tools_log_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", _MainForm.textBox_tools_log_logSource.Text, Tools.LogType.Warning).GetAwaiter();
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}