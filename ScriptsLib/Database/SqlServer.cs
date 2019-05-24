#region Usings
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

using ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.Databases
{
	public class SqlServer_Database
	{
		internal static readonly string _BaseConnection = @"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=";
		public static string _DatabasePath { get; set; }


		Debug _Debug = new Debug();













		#region Create Table
		// # ================================================================================================ #
		public async Task CreateTable(string _Name, List<TableFields> _Fields)
		{
			try
			{
				SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

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
				SqlCommand _SqlCommand = new SqlCommand(_Command, _SqlConnection);
				_Debug.Msg(_SqlCommand.CommandText, Debug.MsgType.Info, "SQL Command");

				await _SqlConnection.OpenAsync();
				await _SqlCommand.ExecuteNonQueryAsync();
				_SqlConnection.Close();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, Debug.MsgType.Error, _Exception.Source);
			}
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
			try
			{
				SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

				string _Command = $"DROP TABLE {_TableName}";
				SqlCommand _SqlCommand = new SqlCommand(_Command, _SqlConnection);
				_Debug.Msg(_SqlCommand.CommandText, Debug.MsgType.Info, "SQL Command");

				await _SqlConnection.OpenAsync();
				await _SqlCommand.ExecuteNonQueryAsync();
				_SqlConnection.Close();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, Debug.MsgType.Error, _Exception.Source);
			}
		}
		// # ================================================================================================ #
		#endregion Delete Table



		#region Insert Into
		// # ================================================================================================ #
		public async Task InsertInto(string _TableName, string _Columns, string _Values)
		{
			try
			{
				SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

				string _Command = $"INSERT INTO {_TableName} ({_Columns}) VALUES ({_Values})";
				SqlCommand _SqlCommand = new SqlCommand(_Command, _SqlConnection);
				_Debug.Msg(_SqlCommand.CommandText, Debug.MsgType.Info, "SQL Command");

				await _SqlConnection.OpenAsync();
				await _SqlCommand.ExecuteNonQueryAsync();
				_SqlConnection.Close();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, Debug.MsgType.Error, _Exception.Source);
			}
		}
		// # ================================================================================================ #
		#endregion Insert Into



		#region Create Database
		// # ================================================================================================ #
		public async Task CreateDatabase(string _Path)
		{
			try
			{
				if (!File.Exists(_Path))
				{
					string _DatabaseName = Path.GetFileNameWithoutExtension(_Path);

					var _Connection = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true");
					await _Connection.OpenAsync();
					var _Command = _Connection.CreateCommand();


					_Command.CommandText = $"CREATE DATABASE {_DatabaseName} ON PRIMARY (NAME={_DatabaseName}, FILENAME='{_Path}')";
					_Debug.Msg(_Command.CommandText, Debug.MsgType.Info, "Create Database");
					await _Command.ExecuteNonQueryAsync();

					_Command.CommandText = $"EXEC sp_detach_db '{_DatabaseName}', 'true'";
					_Debug.Msg(_Command.CommandText, Debug.MsgType.Info, "Export Database");
					await _Command.ExecuteNonQueryAsync();

					_Connection.Close();
				}
				else
				{
					throw new Exception("File already exists!");
				}
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, Debug.MsgType.Error, _Exception.Source);
			}
		}
		// # ================================================================================================ #
		#endregion Create Database



		#region Select
		public List<string> Select(string _Table, string _Selection = "*", string _Condition = null, string _Splitter = "|,|")
		{
			try
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
							_Debug.Msg("Read.", Debug.MsgType.Info, "SqlDataReader.Read()");
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
								_Debug.Msg("Add: " + _Add, Debug.MsgType.Info, "SqlDataReader.Read()");
								_Results.Add(_Add);
							}
						}
						else
						{
							_While = false;
							_Debug.Msg("Stop.", Debug.MsgType.Info, "SqlDataReader.Read()");
						}
					}
				}
				_Connection.Close();

				return _Results;
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, Debug.MsgType.Error, _Exception.Source);
				return null;
			}
		}
		#endregion Select



		#region Update
		public async Task Update(string _Table, string _Update, string _Condition)
		{
			try
			{
				SqlConnection _Connection = new SqlConnection(_BaseConnection + _DatabasePath);


				SqlCommand _Command = new SqlCommand($"UPDATE {_Table} SET {_Update} WHERE {_Condition}", _Connection);

				_Debug.Msg(_Command.CommandText, Debug.MsgType.Info, "Update Command Text");

				await _Connection.OpenAsync();
				await _Command.ExecuteNonQueryAsync();
				_Connection.Close();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, Debug.MsgType.Error, _Exception.Source);
			}
		}
		#endregion Update



		#region Delete
		public async Task Delete(string _Table, string _Condition)
		{
			try
			{
				SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

				SqlCommand _SqlCommand = new SqlCommand($"DELETE FROM {_Table} WHERE {_Condition}", _SqlConnection);

				await _SqlConnection.OpenAsync();
				await _SqlCommand.ExecuteNonQueryAsync();
				_SqlConnection.Close();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, Debug.MsgType.Error, _Exception.Source);
			}
		}
		#endregion Delete
	}
}
