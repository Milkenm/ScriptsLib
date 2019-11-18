#region Usings
using System;
using System.Data.OleDb;
using System.Threading.Tasks;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nDatabases
{
	public static partial class AccessDatabase
	{
		public static async Task InsertInto(string _TableName, string _Columns, string _Values)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					string _EditColumns = null;

					if (!_TableName.StartsWith("[") && !_TableName.EndsWith("]"))
					{
						_TableName = $"[{_TableName}]";
					}
					if (!_Columns.StartsWith("[") && !_Columns.EndsWith("]"))
					{
						foreach (string _Column in _Columns.Split(','))
						{
							if (!string.IsNullOrEmpty(_EditColumns))
							{
								_EditColumns = $"{_EditColumns}, [{_Column}]";
							}
							else
							{
								_EditColumns = $"[{_Column}]";
							}
						}
					}








					OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);
					OleDbCommand _OleDbCommand;

					_OleDbCommand = new OleDbCommand($"INSERT INTO {_TableName} ({_EditColumns}) VALUES ({_Values})", _OleDbConnection);

					Msg(_OleDbCommand.CommandText, MsgType.Info, "OleDb Command");

					_OleDbConnection.OpenAsync();
					_OleDbCommand.ExecuteNonQueryAsync();
					_OleDbConnection.Close();
				});
			}
			catch (Exception _Exception)
			{
				System.Windows.Forms.MessageBox.Show(_Exception.Message, _Exception.Source);
			}
		}
	}
}
