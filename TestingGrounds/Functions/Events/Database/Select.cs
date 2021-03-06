﻿#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib.Databases;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_DatabaseSelect()
		{
			try
			{
				if (MainForm.comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server Database
				{
					foreach (var _Loop in SqlServerDatabase.Select("Users"))
					{
						MessageBox.Show($"{_Loop}", "Selected values");
					}
				}
				else // Access Database
				{
					foreach (var _Loop in AccessDatabase.Select("Users"))
					{
						MessageBox.Show($"{_Loop}", "Selected values");
					}
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}
