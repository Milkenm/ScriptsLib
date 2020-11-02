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
		internal static void Event_DatabaseCreateDatabase()
		{
			try
			{
				if (MainForm.comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server
				{
					SqlServerDatabase.CreateDatabase(@"C:\Milkenm\Data\Tests.mdf").GetAwaiter();
				}
				else
				{
					MessageBox.Show("There is no 'Create Database' yet.");
					return;
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