﻿#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib;

using static TestingGrounds.Functions;
using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ToolsReplaceString()
		{
			try
			{
				MessageBox.Show(Tools.ReplaceString(_MainForm.textBox_tools_replaceString_original.Text, _MainForm.textBox_tools_replaceString_replace.Text, _MainForm.textBox_tools_replaceString_replacewith.Text));
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}