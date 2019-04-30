#region Usings
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

using ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.Database
{
	public class SlDatabase
	{
		internal static readonly string _BaseConnection = $@"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=";
		public static string _DatabasePath { get; set; }


		Debug debug = new Debug();





		#region Create Table
		// # ================================================================================================ #
		public async Task CreateTable(string _Name, List<TableFields> _Fields)
		{
			SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

			string _Columns = null;
			foreach (var _Loop in _Fields)
			{
				string _DataType;
				if (_Loop.DataType == SqlDataTypes.Text)
				{
					_DataType = "text";
				}
				else if (_Loop.DataType == SqlDataTypes.Number)
				{
					_DataType = "bigint";
				}
				else if (_Loop.DataType == SqlDataTypes.VarChar)
				{
					_DataType = "varchar(50)";
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
			Text,
			Number,
			VarChar,
		}
		// # ================================================================================================ #
		#endregion Create Table

		#region Delete Table
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
		#endregion Delete Table

		#region Insert Into
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
		#endregion Insert Into

		#region Create Database
		// # ================================================================================================ #
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
		// # ================================================================================================ #
		#endregion Create Database


		#region Select
		public List<string> Select(string _Table, string _Selection = "*", string _Condition = null, string _Splitter = "|,|")
		{
			SqlConnection _Connection = new SqlConnection(_BaseConnection + _DatabasePath);

			SqlCommand _Command;
			if (!String.IsNullOrEmpty(_Condition))
			{
				_Command = new SqlCommand($"SELECT {_Selection} FROM {_Table} WHERE {_Condition}", _Connection);
			}
			else
			{
				_Command = new SqlCommand($"SELECT {_Selection} FROM {_Table}", _Connection);
			}


			List<string> _Results = new List<string>();

			_Connection.Open();
			using (SqlDataReader _Reader = _Command.ExecuteReader())
			{
				bool _While = true;
				while (_While == true)
				{
					if (_Reader.Read() == true)
					{
						debug.Msg("Read.", "SqlDataReader.Read()");
						List<string> _Values = new List<string>();
						int _Index = 0;

						try
						{
							while (true)
							{
								_Values.Add(_Reader[_Index].ToString());
								_Index++;
							}
						}
						catch
						{
							string _Add = null;
							foreach (string _Loop in _Values)
							{
								if (String.IsNullOrEmpty(_Add))
								{
									_Add = _Loop;
								}
								else
								{
									_Add = _Add + _Splitter + _Loop;
								}
							}
							debug.Msg("Add: " + _Add, "SqlDataReader.Read()");
							_Results.Add(_Add);
						}
					}
					else
					{
						_While = false;
						debug.Msg("Stop.", "SqlDataReader.Read()");
					}
				}
			}
			_Connection.Close();

			return _Results;
		}
		#endregion Select



		#region Raw Sql
		// # ================================================================================================ #
		public object RawSql(string _Command)
		{
			SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

			SqlCommand _SqlCommand = new SqlCommand(_Command, _SqlConnection);
			debug.Msg(_SqlCommand.CommandText, "SQL Command");

			_SqlConnection.Open();
			debug.Msg(_SqlConnection.ConnectionString);
			object _Result = _SqlCommand.ExecuteNonQuery();
			_SqlConnection.Close();

			return _Result;
		}
		// # ================================================================================================ #
		#endregion Raw Sql
	}
}
