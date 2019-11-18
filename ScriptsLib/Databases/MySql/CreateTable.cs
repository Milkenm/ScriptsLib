#region Usings
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nDatabases
{
	public static partial class MySqlDatabase
	{
		public static async Task CreateTable(string _Name, List<TableFields> _Fields)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					MySqlConnection _MySqlConnection = new MySqlConnection(string.Format(_BaseConnection, _Server, _Port, _User, _Password, _Database, _SslMode));
					Msg(_MySqlConnection.ConnectionString, MsgType.Info, "MySql Connection");

					string _Columns = null;
					foreach (TableFields _Loop in _Fields)
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
							if (!string.IsNullOrEmpty(_Columns))
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
							if (!string.IsNullOrEmpty(_Columns))
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
					Msg(_MySqlCommand.CommandText, MsgType.Info, "MySql Command");


					_MySqlConnection.OpenAsync();
					_MySqlCommand.ExecuteNonQueryAsync();
					_MySqlConnection.Close();
				});
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}

		#region Enums
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
		#endregion Enums
	}
}
