#region Usings
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.Databases
{
	public static partial class SqlServerDatabase
	{
		public static async Task Update(string _Table, string _Update, string _Condition)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					SqlConnection _Connection = new SqlConnection(_BaseConnection + _DatabasePath);


					SqlCommand _Command = new SqlCommand($"UPDATE {_Table} SET {_Update} WHERE {_Condition}", _Connection);

					Msg(_Command.CommandText, MsgType.Info, "Update Command Text");

					_Connection.OpenAsync();
					_Command.ExecuteNonQueryAsync();
					_Connection.Close();
				});
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
	}
}
