#region Usings
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nDatabases
{
	public static partial class SqlServerDatabase
	{
		public static async Task CreateTable(string _Name, List<TableFields> _Fields)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					SqlConnection _SqlConnection = new SqlConnection(_BaseConnection + _DatabasePath);

					string _Columns = null;
					foreach (TableFields _Loop in _Fields)
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


						if (!string.IsNullOrEmpty(_Columns))
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

		#region Enums
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
		#endregion Enums
	}
}
