#region Usings

using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Threading.Tasks;
using ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.Databases
{
	public class Access_Database
	{
		internal static readonly string _BaseConnection = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
		public static string _DatabasePath { get; set; }


		Debug debug = new Debug();





		#region Create Table
		// # ================================================================================================ #
		public async Task CreateTable(string _Name, List<TableFields> _Fields)
		{
			OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);

			string _Columns = null;
			foreach (var _Loop in _Fields)
			{
				string _DataType;
				if (_Loop.DataType == SqlDataTypes.Text)
				{
					_DataType = "ntext";
				}
				else if (_Loop.DataType == SqlDataTypes.Number)
				{
					_DataType = "bigint";
				}
				else if (_Loop.DataType == SqlDataTypes.Image)
				{
					_DataType = "image";
				}
				else if (_Loop.DataType == SqlDataTypes.Money)
				{
					_DataType = "money";
				}
				else if (_Loop.DataType == SqlDataTypes.Decimal)
				{
					_DataType = "decimal(38,38)";
				}
				else if (_Loop.DataType == SqlDataTypes.DateAndTime)
				{
					_DataType = "datetime2";
				}
				else if (_Loop.DataType == SqlDataTypes.Date)
				{
					_DataType = "date";
				}
				else if (_Loop.DataType == SqlDataTypes.Time)
				{
					_DataType = "time";
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
			OleDbCommand _OleDbCommand = new OleDbCommand(_Command, _OleDbConnection);
			debug.Msg(_OleDbCommand.CommandText, "OleDb Command");

			await _OleDbConnection.OpenAsync();
			await _OleDbCommand.ExecuteNonQueryAsync();
			_OleDbConnection.Close();
		}

		public struct TableFields
		{
			public string Name;
			public SqlDataTypes DataType;
			public bool PrimaryKey;
			public bool AutoIncrement;
		}

		public enum SqlDataTypes
		{
			Text,
			Number,
			Image,
			Money,
			Decimal,
			DateAndTime,
			Date,
			Time,
		}
		// # ================================================================================================ #
		#endregion Create Table
		
		#region Delete Table
		// # ================================================================================================ #
		public async Task DeleteTable(string _TableName)
		{
			OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);
			
			OleDbCommand _OleDbCommand = new OleDbCommand($"DROP TABLE {_TableName}", _OleDbConnection);
			debug.Msg(_OleDbCommand.CommandText, "OleDb Command");

			await _OleDbConnection.OpenAsync();
			await _OleDbCommand.ExecuteNonQueryAsync();
			_OleDbConnection.Close();
		}
		// # ================================================================================================ #
		#endregion Delete Table
		
		#region Insert Into
		// # ================================================================================================ #
		public async Task InsertInto(string _TableName, string _Columns, string _Values)
		{
			OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);
			
			OleDbCommand _OleDbCommand = new OleDbCommand($"INSERT INTO {_TableName} ({_Columns}) VALUES ({_Values})", _OleDbConnection);
			debug.Msg(_OleDbCommand.CommandText, "OleDb Command");

			await _OleDbConnection.OpenAsync();
			await _OleDbCommand.ExecuteNonQueryAsync();
			_OleDbConnection.Close();
		}
		// # ================================================================================================ #
		#endregion Insert Into
		
		#region Create Database
		// # ================================================================================================ #
		private async Task CreateDatabase(string _Path)
		{
			if (!File.Exists(_Path))
			{
				string _DatabaseName = Path.GetFileNameWithoutExtension(_Path);

				var _Connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;");
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
			OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);

			OleDbCommand _OleDbCommand;
			if (!String.IsNullOrEmpty(_Condition))
			{
				_OleDbCommand = new OleDbCommand($"SELECT {_Selection} FROM {_Table} WHERE {_Condition}", _OleDbConnection);
			}
			else
			{
				_OleDbCommand = new OleDbCommand($"SELECT {_Selection} FROM {_Table}", _OleDbConnection);
			}


			List<string> _Results = new List<string>();

			_OleDbConnection.Open();
			using (OleDbDataReader _Reader = _OleDbCommand.ExecuteReader())
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
							debug.Msg("Add: " + _Add, "OleDbDataReader.Read()");
							_Results.Add(_Add);
						}
					}
					else
					{
						_While = false;
						debug.Msg("Stop.", "OleDbDataReader.Read()");
					}
				}
			}
			_OleDbConnection.Close();

			return _Results;
		}
		#endregion Select

		#region Update
		public async Task Update(string _Table, string _Update, string _Condition)
		{
			OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);


			OleDbCommand _OleDbCommand = new OleDbCommand($"UPDATE {_Table} SET {_Update} WHERE {_Condition}", _OleDbConnection);

			debug.Msg(_OleDbCommand.CommandText, "Update Command Text");

			await _OleDbConnection.OpenAsync();
			await _OleDbCommand.ExecuteNonQueryAsync();
			_OleDbConnection.Close();
		}
		#endregion Update
	}
}