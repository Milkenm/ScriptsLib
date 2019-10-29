#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib.nDatabases;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_DatabaseInsertInto()
		{
			try
			{
				if (_MainForm.comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server Database
				{
					SqlServerDatabase.InsertInto("Users", "ID, Name, Password", "1, 'User1', 'Pass1'").GetAwaiter();
				}
				else // Access Database
				{
					AccessDatabase.InsertInto("[Users]", "[Name], [Password]", "'User1', 'Pass1'").GetAwaiter();
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
