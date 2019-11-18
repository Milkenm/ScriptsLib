#region Usings
using System;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nDatabases
{
	public static partial class MySqlDatabase
	{
		public static async Task DeleteTable(string _TableName)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					MySqlConnection _MySqlConnection = new MySqlConnection(string.Format(_BaseConnection, _Server, _Port, _User, _Password, _Database, _SslMode));

					MySqlCommand _MySqlCommand = new MySqlCommand($"DROP TABLE {_TableName}", _MySqlConnection);
					Msg(_MySqlCommand.CommandText, MsgType.Info, "OleDb Command");

					_MySqlConnection.OpenAsync();
					_MySqlCommand.ExecuteNonQueryAsync();
					_MySqlConnection.Close();
				});
			}
			catch (Exception _Exception) { Msg(_Exception.Message, MsgType.Error, _Exception.Source); }
		}
	}
}
