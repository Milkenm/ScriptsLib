﻿#region Usings
using System;

using ScriptsLib;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ToolsLog()
		{
			try
			{
				if (MainForm.comboBox_tools_log_logType.SelectedIndex == 0) // INFO
				{
					Tools.Log(MainForm.textBox_tools_log_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", MainForm.textBox_tools_log_logSource.Text, Tools.LogType.Info).GetAwaiter();
				}
				else if (MainForm.comboBox_tools_log_logType.SelectedIndex == 1) // ERROR
				{
					Tools.Log(MainForm.textBox_tools_log_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", MainForm.textBox_tools_log_logSource.Text, Tools.LogType.Error).GetAwaiter();
				}
				else if (MainForm.comboBox_tools_log_logType.SelectedIndex == 2) // WARNING
				{
					Tools.Log(MainForm.textBox_tools_log_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", MainForm.textBox_tools_log_logSource.Text, Tools.LogType.Warning).GetAwaiter();
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}