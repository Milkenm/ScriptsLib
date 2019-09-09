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
		/// <summary>Deletes a value from the database.</summary>
		/// <param name="_Table">The table from where to delete the value.</param>
		/// <param name="_Condition">The condition to delete the value.</param>
		public static async Task Delete(string _Table, string _Condition)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);

					OleDbCommand _OleDbCommand = new OleDbCommand($"DELETE FROM {_Table} WHERE {_Condition}", _OleDbConnection);

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
