#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib.nDatabases;

using static TestingGrounds.Functions;
using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_DatabaseDeleteTable()
		{
			try
			{
				if (_MainForm.comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server Database
				{
					SqlServerDatabase.DeleteTable("Users").GetAwaiter();
				}
				else // Access Database
				{
					AccessDatabase.DeleteTable("Users").GetAwaiter();
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
