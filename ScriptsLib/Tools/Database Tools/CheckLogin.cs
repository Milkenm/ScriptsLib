#region Usings
using System;
using System.Data.OleDb;
using System.Data.SqlClient;

using ScriptsLib.Databases;

using static ScriptsLib.Dev;
#endregion usings



namespace ScriptsLib.nTools
{
	public static partial class DatabaseTools
	{
		/// <summary>Checks if the given user and password exist in the database.</summary>
		/// <param name="_Table">The database table containing the user accounts.</param>
		/// <param name="_Username">The given username to be checked.</param>
		/// <param name="_Password">The given password to be checked.</param>
		/// <param name="_UsernameColumn">The table column containing the usernames.</param>
		/// <param name="_PasswordColumn">The table column containing the passwords.</param>
		/// <param name="_DatabaseType">The type of database to use.</param>
		public static bool CheckLogin(string _Table, string _Username, string _Password, string _UsernameColumn, string _PasswordColumn, DatabaseType _DatabaseType)
		{
			try
			{
				if (_DatabaseType == DatabaseType.SqlServer)
				{
					SqlConnection _Connection = new SqlConnection(SqlServerDatabase._BaseConnection + SqlServerDatabase._DatabasePath);


					SqlCommand _Command = new SqlCommand($"SELECT COUNT(*) FROM {_Table} WHERE {_UsernameColumn} = '{_Username}' AND {_PasswordColumn} = '{_Password}'", _Connection);

					_Connection.OpenAsync().GetAwaiter().GetResult();
					int _Result = Convert.ToInt32(_Command.ExecuteScalarAsync().GetAwaiter().GetResult().ToString());

					Msg($"Command: {_Command.CommandText}\n\nResult: {_Result}", MsgType.Info, "CheckLogin");

					_Connection.Close();

					if (_Result > 0)
					{
						return true;
					}
					return false;
				}
				else if (_DatabaseType == DatabaseType.Access)
				{
					OleDbConnection _Connection = new OleDbConnection(AccessDatabase.BaseConnection + AccessDatabase.DatabasePath);


					OleDbCommand _Command = new OleDbCommand($"SELECT COUNT(*) FROM {_Table} WHERE {_UsernameColumn} = '{_Username}' AND {_PasswordColumn} = '{_Password}'", _Connection);

					_Connection.OpenAsync().GetAwaiter().GetResult();
					int _Result = Convert.ToInt32(_Command.ExecuteScalarAsync().GetAwaiter().GetResult().ToString());

					Msg($"Command: {_Command.CommandText}\n\nResult: {_Result}", MsgType.Info, "CheckLogin");

					_Connection.Close();

					if (_Result > 0)
					{
						return true;
					}
					return false;
				}
				else
				{
					throw new Exception("Selected database type not supported.");
				}
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return false;
			}
		}
	}
}
