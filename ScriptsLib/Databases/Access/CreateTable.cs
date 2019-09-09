#region Usings
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Threading.Tasks;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nDatabases
{
	public static partial class AccessDatabase
	{
		public static async Task CreateTable(string _Name, List<TableFields> _Fields)
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
					Msg(_OleDbCommand.CommandText, MsgType.Info, "OleDb Command");


					_OleDbConnection.OpenAsync();
					_OleDbCommand.ExecuteNonQueryAsync();
					_OleDbConnection.Close();
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
		#endregion Enums
	}
}
