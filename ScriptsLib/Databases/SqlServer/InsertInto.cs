#region Usings
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nDatabases
{
	public static partial class SqlServerDatabase
	{
		public static async Task InsertInto(string _TableName, string _Columns, string _Values)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

					string _Command = $"INSERT INTO {_TableName} ({_Columns}) VALUES ({_Values})";
					SqlCommand _SqlCommand = new SqlCommand(_Command, _SqlConnection);
					Msg(_SqlCommand.CommandText, MsgType.Info, "SQL Command");

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
