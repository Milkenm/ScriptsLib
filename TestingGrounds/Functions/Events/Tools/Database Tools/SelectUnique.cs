#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ScriptsLib.nTools;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_DatabaseToolsSelectUnique()
		{
			try
			{
				if (_MainForm.comboBox_tg_databaseType.SelectedIndex == 1)
				{
					List<string> _Select = DatabaseTools.SelectUnique(_MainForm.textBox_tools_databaseTools_selectUnique_table.Text, _MainForm.textBox_tools_databaseTools_selectUnique_column.Text, DatabaseTools.DatabaseType.Access);

					string _String = null;
					foreach (string _Value in _Select)
					{
						if (!String.IsNullOrEmpty(_String))
						{
							_String = $"{_String}, {_Value}";
						}
						else
						{
							_String = _Value;
						}
					}

					MessageBox.Show(_String);
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}