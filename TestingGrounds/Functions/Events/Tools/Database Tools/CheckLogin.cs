﻿#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib.nTools;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_DatabaseToolsCheckLogin()
		{
			try
			{
				bool _Success;
				if (MainForm.comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server
				{
					_Success = DatabaseTools.CheckLogin("Users", "Name", "Password", MainForm.textBox_tools_databaseTools_checkLogin_user.Text, MainForm.textBox_tools_databaseTools_checkLogin_pass.Text, DatabaseTools.DatabaseType.SqlServer);
				}
				else
				{
					_Success = DatabaseTools.CheckLogin("Users", "Name", "Password", MainForm.textBox_tools_databaseTools_checkLogin_user.Text, MainForm.textBox_tools_databaseTools_checkLogin_pass.Text, DatabaseTools.DatabaseType.Access);
				}

				if (_Success == true)
				{
					MessageBox.Show("Logged in.");
				}
				else
				{
					MessageBox.Show("Invalid login credentials.");
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}