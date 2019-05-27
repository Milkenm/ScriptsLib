#region Usings
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Threading.Tasks;

using ScriptsLib.Dev;

using static ScriptsLib.Dev.Debug;
#endregion Usings



namespace ScriptsLib.Databases
{
	public class AccessDatabase
	{
		#region Refs
		Debug _Debug = new Debug();
		#endregion Refs

		#region Vars
		internal static readonly string _BaseConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
		public static string _DatabasePath { get; set; }
		#endregion Vars












		#region Create Table
		// # ================================================================================================ #
		public async Task CreateTable(string _Name, List<TableFields> _Fields)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);


					string _Columns = null;
					foreach (var _Loop in _Fields)
					{
						string _DataType;
						if (_Loop.DataType == AccessDataTypes.Text)
						{
							_DataType = "text";
						}
						else if (_Loop.DataType == AccessDataTypes.Number)
						{
							_DataType = "long";
						}
						else if (_Loop.DataType == AccessDataTypes.Money)
						{
							_DataType = "currency";
						}
						else if (_Loop.DataType == AccessDataTypes.Decimal)
						{
							_DataType = "double";
						}
						else if (_Loop.DataType == AccessDataTypes.DateAndTime)
						{
							_DataType = "date/time";
						}
						else if (_Loop.DataType == AccessDataTypes.Key)
						{
							_DataType = "key";
						}
						else
						{
							throw new Exception();
						}


						if (_DataType != "key")
						{
							if (!String.IsNullOrEmpty(_Columns))
							{
								_Columns = $"{_Columns}, [{_Loop.Name}] {_DataType}";
							}
							else
							{
								_Columns = $"[{_Loop.Name}] {_DataType}";
							}
						}
						else
						{
							if (!String.IsNullOrEmpty(_Columns))
							{
								_Columns = $"{_Columns}, [{_Loop.Name}] AUTOINCREMENT PRIMARY KEY";
							}
							else
							{
								_Columns = $"[{_Loop.Name}] AUTOINCREMENT PRIMARY KEY";
							}
						}
					}

					string _Command = $"CREATE TABLE {_Name} ({_Columns})";
					OleDbCommand _OleDbCommand = new OleDbCommand(_Command, _OleDbConnection);
					_Debug.Msg(_OleDbCommand.CommandText, MsgType.Info, "OleDb Command");


					_OleDbConnection.OpenAsync();
					_OleDbCommand.ExecuteNonQueryAsync();
					_OleDbConnection.Close();
				});
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}

		public struct TableFields
		{
			public string Name;
			public AccessDataTypes DataType;
			public bool PrimaryKey;
			public bool AutoIncrement;
		}

		public enum AccessDataTypes
		{
			Key,
			Text,
			Number,
			Money,
			Decimal,
			DateAndTime,
		}
		// # ================================================================================================ #
		#endregion Create Table



		#region Delete Table
		// # ================================================================================================ #
		public async Task DeleteTable(string _TableName)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);

					OleDbCommand _OleDbCommand = new OleDbCommand($"DROP TABLE {_TableName}", _OleDbConnection);
					_Debug.Msg(_OleDbCommand.CommandText, MsgType.Info, "OleDb Command");

					_OleDbConnection.OpenAsync();
					_OleDbCommand.ExecuteNonQueryAsync();
					_OleDbConnection.Close();
				});
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
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
				await Task.Factory.StartNew(() =>
				{
					if (!_TableName.StartsWith("[") && !_TableName.EndsWith("]"))
					{
						_TableName = $"[{_TableName}]";
					}
					if (!_Columns.StartsWith("[") && !_Columns.EndsWith("]"))
					{
						string[] _SplitColumns;
						_Columns = null;

						_SplitColumns = _Columns.Split(',');

						foreach (string _ValueColumn in _SplitColumns)
						{
							if (!String.IsNullOrEmpty(_Columns))
							{
								_Columns = $"{_Columns}, [{_ValueColumn}]";
							}
							else
							{
								_Columns = $"[{_ValueColumn}]";
							}
						}
					}








					OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);

					OleDbCommand _OleDbCommand = new OleDbCommand($"INSERT INTO {_TableName} ({_Columns}) VALUES ({_Values})", _OleDbConnection);
					_Debug.Msg(_OleDbCommand.CommandText, MsgType.Info, "OleDb Command");

					_OleDbConnection.OpenAsync();
					_OleDbCommand.ExecuteNonQueryAsync();
					_OleDbConnection.Close();
				});
			}
			catch (Exception _Exception)
			{
				System.Windows.Forms.MessageBox.Show(_Exception.Message, _Exception.Source);
			}
		}
		// # ================================================================================================ #
		#endregion Insert Into



		#region Create Database
		// # ================================================================================================ #
		private async Task CreateDatabase(string _Path)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					if (!File.Exists(_Path))
					{
						string _DatabaseName = Path.GetFileNameWithoutExtension(_Path);

						var _Connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;");
						_Connection.OpenAsync();
						var _Command = _Connection.CreateCommand();


						_Command.CommandText = $"CREATE DATABASE {_DatabaseName} ON PRIMARY (NAME={_DatabaseName}, FILENAME='{_Path}')";
						_Debug.Msg(_Command.CommandText, MsgType.Info, "Create Database");
						_Command.ExecuteNonQueryAsync();

						_Command.CommandText = $"EXEC sp_detach_db '{_DatabaseName}', 'true'";
						_Debug.Msg(_Command.CommandText, MsgType.Info, "Export Database");
						_Command.ExecuteNonQueryAsync();

						_Connection.Close();
					}
					else
					{
						throw new Exception("File already exists!");
					}
				});
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
		// # ================================================================================================ #
		#endregion Create Database



		#region Select
		public List<string> Select(string _Table, string _Selection = "*", string _Condition = null, string _Splitter = "|,|")
		{
			try
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
							_Debug.Msg("Read.", MsgType.Info, "SqlDataReader.Read()");
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
								_Debug.Msg("Add: " + _Add, MsgType.Info, "OleDbDataReader.Read()");
								_Results.Add(_Add);
							}
						}
						else
						{
							_While = false;
							_Debug.Msg("Stop.", MsgType.Info, "OleDbDataReader.Read()");
						}
					}
				}
				_OleDbConnection.Close();


				return _Results;
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
		#endregion Select



		#region Update
		public async Task Update(string _Table, string _Update, string _Condition)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);


					OleDbCommand _OleDbCommand = new OleDbCommand($"UPDATE {_Table} SET {_Update} WHERE {_Condition}", _OleDbConnection);

					_Debug.Msg(_OleDbCommand.CommandText, MsgType.Info, "Update Command Text");

					_OleDbConnection.OpenAsync();
					_OleDbCommand.ExecuteNonQueryAsync();
					_OleDbConnection.Close();
				});
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
		#endregion Update



		#region Delete
		public async Task Delete(string _Table, string _Condition)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);

					OleDbCommand _OleDbCommand = new OleDbCommand($"DELETE FROM {_Table} WHERE {_Condition}", _OleDbConnection);

					_OleDbConnection.OpenAsync();
					_OleDbCommand.ExecuteNonQueryAsync();
					_OleDbConnection.Close();
				});
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
		#endregion Delete
	}
}