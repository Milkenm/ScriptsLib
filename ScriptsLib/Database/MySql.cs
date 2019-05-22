#region Usings
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.Databases
{
	public class MySql_Database
	{
		internal static readonly string _BaseConnection = @"Server={0}; Port={1}; User ID={2}; Password={3}; Database={4}; SslMode={5}";
		public static string _Server { get; set; }
		public static int _Port { get; set; }
		public static string _Database { get; set; }
		public static string _User { get; set; }
		public static string _Password { get; set; }
		public static string _SslMode { get; set; }

		Debug _Debug = new Debug();



		#region Create Table
		// # ================================================================================================ #
		public async Task CreateTable(string _Name, List<TableFields> _Fields)
		{
			try
			{
				MySqlConnection _MySqlConnection = new MySqlConnection(String.Format(_BaseConnection, _Server, _Port, _User, _Password, _Database, _SslMode));
				_Debug.Msg(_MySqlConnection.ConnectionString, "MySql Connection");

				string _Columns = null;
				foreach (var _Loop in _Fields)
				{
					string _DataType;
					if (_Loop.DataType == MySqlDataTypes.Text)
					{
						_DataType = "longtext";
					}
					else if (_Loop.DataType == MySqlDataTypes.Number)
					{
						_DataType = "bigint";
					}
					else if (_Loop.DataType == MySqlDataTypes.Money)
					{
						_DataType = "currency";
					}
					else if (_Loop.DataType == MySqlDataTypes.Decimal)
					{
						_DataType = "double";
					}
					else if (_Loop.DataType == MySqlDataTypes.DateAndTime)
					{
						_DataType = "datetime";
					}
					else if (_Loop.DataType == MySqlDataTypes.Key)
					{
						_DataType = "key";
					}
					else if (_Loop.DataType == MySqlDataTypes.Boolean)
					{
						_DataType = "boolean";
					}
					else if (_Loop.DataType == MySqlDataTypes.Timestamp)
					{
						_DataType = "timespamp";
					}
					else if (_Loop.DataType == MySqlDataTypes.Year)
					{
						_DataType = "year";
					}
					else
					{
						throw new Exception();
					}


					if (_DataType != "key")
					{
						if (!String.IsNullOrEmpty(_Columns))
						{
							_Columns = $"{_Columns}, {_Loop.Name} {_DataType}";
						}
						else
						{
							_Columns = $"{_Loop.Name} {_DataType}";
						}
					}
					else
					{
						if (!String.IsNullOrEmpty(_Columns))
						{
							_Columns = $"{_Columns}, {_Loop.Name} INT NOT NULL AUTO_INCREMENT, PRIMARY KEY ({_Loop.Name})";
						}
						else
						{
							_Columns = $"{_Loop.Name} INT NOT NULL AUTO_INCREMENT, PRIMARY KEY ({_Loop.Name})";
						}
					}
				}

				string _Command = $"CREATE TABLE {_Name} ({_Columns})";
				MySqlCommand _MySqlCommand = new MySqlCommand(_Command, _MySqlConnection);
				_Debug.Msg(_MySqlCommand.CommandText, "MySql Command");


				await _MySqlConnection.OpenAsync();
				await _MySqlCommand.ExecuteNonQueryAsync();
				_MySqlConnection.Close();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, _Exception.Source);
			}
		}

		public struct TableFields
		{
			public string Name;
			public MySqlDataTypes DataType;
			public bool PrimaryKey;
			public bool AutoIncrement;
		}

		public enum MySqlDataTypes
		{
			Key,
			Text,
			Number,
			Money,
			Decimal,
			DateAndTime,
			Boolean,
			Timestamp,
			Year,
		}
		// # ================================================================================================ #
		#endregion Create Table

		#region Delete Table
		// # ================================================================================================ #
		public async Task DeleteTable(string _TableName)
		{
			try
			{
				MySqlConnection _MySqlConnection = new MySqlConnection(String.Format(_BaseConnection, _Server, _Port, _User, _Password, _Database, _SslMode));

				MySqlCommand _MySqlCommand = new MySqlCommand($"DROP TABLE {_TableName}", _MySqlConnection);
				_Debug.Msg(_MySqlCommand.CommandText, "OleDb Command");

				await _MySqlConnection.OpenAsync();
				await _MySqlCommand.ExecuteNonQueryAsync();
				_MySqlConnection.Close();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, _Exception.Source);
			}
		}
		// # ================================================================================================ #
		#endregion Delete Table
	}
}
