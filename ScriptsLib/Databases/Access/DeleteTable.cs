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
		public static async Task DeleteTable(string _TableName)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);

					OleDbCommand _OleDbCommand = new OleDbCommand($"DROP TABLE {_TableName}", _OleDbConnection);
					Msg(_OleDbCommand.CommandText, MsgType.Info, "OleDb Command");

					_OleDbConnection.OpenAsync();
					_OleDbCommand.ExecuteNonQueryAsync();
					_OleDbConnection.Close();
				});
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
	}
}
