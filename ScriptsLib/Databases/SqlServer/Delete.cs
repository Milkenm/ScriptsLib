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
		public static async Task Delete(string _Table, string _Condition)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

					SqlCommand _SqlCommand = new SqlCommand($"DELETE FROM {_Table} WHERE {_Condition}", _SqlConnection);

					_SqlConnection.OpenAsync();
					_SqlCommand.ExecuteNonQueryAsync();
					_SqlConnection.Close();
				});
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
	}
}
