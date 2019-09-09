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
		public static async Task Update(string _Table, string _Update, string _Condition)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);


					OleDbCommand _OleDbCommand = new OleDbCommand($"UPDATE [{_Table}] SET {_Update} WHERE {_Condition}", _OleDbConnection);

					Msg(_OleDbCommand.CommandText, MsgType.Info, "Update Command Text");

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
