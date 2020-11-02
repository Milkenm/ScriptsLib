#region Usings
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
		internal static void Event_DatabaseDelete()
		{
			try
			{
				if (MainForm.comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server
				{
					SqlServerDatabase.Delete("Users", "ID = 1").GetAwaiter();
				}
				else // Access Database
				{
					AccessDatabase.Delete("Users", "ID = 1").GetAwaiter();
				}

				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}
