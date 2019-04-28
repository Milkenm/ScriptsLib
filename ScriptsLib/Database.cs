#region Usings
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

using ScriptsLib.Internal;
#endregion Usings



namespace ScriptsLib.Database
{
	public class SlDatabase
	{
		public static string _DatabasePath { get; set; }
		private static readonly string _BaseConnection = $@"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=";


		Debug debug = new Debug();





		#region CREATE TABLE
		// # ================================================================================================ #
		public async Task CreateTable(string _Name, List<TableFields> _Fields)
		{
			SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

			string _Columns = null;
			foreach (var _Loop in _Fields)
			{
				string _DataType;
				if (_Loop.DataType == SqlDataTypes.text)
				{
					_DataType = "text";
				}
				else if (_Loop.DataType == SqlDataTypes.number)
				{
					_DataType = "bigint";
				}
				else
				{
					throw new Exception();
				}


				if (!String.IsNullOrEmpty(_Columns))
				{
					_Columns = $"{_Columns}, {_Loop.Name} {_DataType}";
				}
				else
				{
					_Columns = $"{_Loop.Name} {_DataType}";
				}
			}

			string _Command = $"CREATE TABLE {_Name} ({_Columns})";
			SqlCommand _SqlCommand = new SqlCommand(_Command, _SqlConnection);
			debug.Msg(_SqlCommand.CommandText, "SQL Command");

			await _SqlConnection.OpenAsync();
			await _SqlCommand.ExecuteNonQueryAsync();
			_SqlConnection.Close();
		}

		public struct TableFields
		{
			public string Name;
			public SqlDataTypes DataType;
		}

		public enum SqlDataTypes
		{
			text,
			number,
		}
		// # ================================================================================================ #
		#endregion CREATE TABLE

		#region DELETE TABLE
		// # ================================================================================================ #
		public async Task DeleteTable(string _TableName)
		{
			SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

			string _Command = $"DROP TABLE {_TableName}";
			SqlCommand _SqlCommand = new SqlCommand(_Command, _SqlConnection);
			debug.Msg(_SqlCommand.CommandText, "SQL Command");

			await _SqlConnection.OpenAsync();
			await _SqlCommand.ExecuteNonQueryAsync();
			_SqlConnection.Close();
		}
		// # ================================================================================================ #
		#endregion DELETE TABLE

		#region INSERT INTO
		// # ================================================================================================ #
		public async Task InsertInto(string _TableName, string _Columns, string _Values)
		{
			SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

			string _Command = $"INSERT INTO {_TableName} ({_Columns}) VALUES ({_Values})";
			SqlCommand _SqlCommand = new SqlCommand(_Command, _SqlConnection);
			debug.Msg(_SqlCommand.CommandText, "SQL Command");

			await _SqlConnection.OpenAsync();
			await _SqlCommand.ExecuteNonQueryAsync();
			_SqlConnection.Close();
		}
		// # ================================================================================================ #
		#endregion INSERT INTO

		#region CREATE DATABASE
		public async Task CreateDatabase(string _Path)
		{
			if (!File.Exists(_Path))
			{
				string _DatabaseName = Path.GetFileNameWithoutExtension(_Path);

				var _Connection = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true");
				await _Connection.OpenAsync();
				var _Command = _Connection.CreateCommand();


				_Command.CommandText = $"CREATE DATABASE {_DatabaseName} ON PRIMARY (NAME={_DatabaseName}, FILENAME='{_Path}')";
				debug.Msg(_Command.CommandText, "Create Database");
				await _Command.ExecuteNonQueryAsync();

				_Command.CommandText = $"EXEC sp_detach_db '{_DatabaseName}', 'true'";
				debug.Msg(_Command.CommandText, "Export Database");
				await _Command.ExecuteNonQueryAsync();

				_Connection.Close();
			}
			else
			{
				throw new Exception("File already exists!");
			}
		}
		#endregion CREATE DATABASE



		#region RAW COMMAND
		// # ================================================================================================ #
		public async Task RawCommand(string _Command)
		{
			SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

			SqlCommand _SqlCommand = new SqlCommand(_Command, _SqlConnection);
			debug.Msg(_SqlCommand.CommandText, "SQL Command");

			await _SqlConnection.OpenAsync();
			await _SqlCommand.ExecuteNonQueryAsync();
			_SqlConnection.Close();
		}
		// # ================================================================================================ #
		#endregion RAW COMMAND
	}
}
