#region Usings
using System;

using ScriptsLib.nTools;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_DatabaseToolsSqlFilter()
		{
			try
			{
				MainForm.textBox_tools_databaseTools_filterSql_text.Text = DatabaseTools.FilterSql(MainForm.textBox_tools_databaseTools_filterSql_text.Text);
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}
