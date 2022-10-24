using ScriptsLibR.Databases;
using ScriptsLibR.Exceptions;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ScriptsLibR.Interfaces.Abstract
{
	public abstract class DatabaseTableColumn<T> : IDatabaseTableColumn<T>
	{
		public DatabaseTableColumn(string name, T dataType, bool isPrimaryKey, string parameters)
		{
			this.Name = name;
			this.DataType = dataType;
			this.IsPrimaryKey = isPrimaryKey;
			this.Parameter1 = param1;
			this.Parameter2 = param2;
		}

		public string Name { get; }
		public T DataType { get; }
		public bool IsPrimaryKey { get; }

		public string Parameters { get; }

		public override string ToString()
		{
				StringBuilder sb = new StringBuilder($"[{this.Name}]");
			if (DataType.GetType() == typeof(AccessDataType))
			{
				string dataType = this.DataType switch
				{
					AccessDataType.BigBinary => "BIGBINARY",
					AccessDataType.Binary => "BINARY",
					AccessDataType.Bit => "BIT",
					AccessDataType.Counter => "COUNTER",
					AccessDataType.Currency => "CURRENCY",
					AccessDataType.DateTime => "DATE",
					AccessDataType.Guid => "GUID",
					AccessDataType.LongText => "LONGTEXT",
					AccessDataType.NumberSingle => "SINGLE",
					AccessDataType.NumberDouble => "DOUBLE",
					AccessDataType.NumberByte => "BYTE",
					AccessDataType.NumberInteger => "SHORT",
					AccessDataType.NumberLongInteger => "LONG",
					AccessDataType.Numeric => "NUMERIC",
					AccessDataType.Ole => "LONGBINARY",
					AccessDataType.Text => "TEXT",
					_ => throw new InvalidEnumArgumentException($"Invalid \"DataType\": '{this.DataType}'."),
				};
				sb.Append($" {dataType}");

				if (this.IsPrimaryKey)
				{
					sb.Append(" PRIMARY KEY");
				}
			}
			else if (DataType.GetType() == typeof(MySqlDataType))
			{
				throw new NotImplementedException();
				string dataType = this.DataType switch
				{
					MySqlDataType.TinyText => "TINYTEXT",
					MySqlDataType.Text => "TEXT",
					MySqlDataType.MediumText => "MEDIUMTEXT",
					MySqlDataType.LongText => "LONGTEXT",
					MySqlDataType.TinyBlob => "TINYBLOB",
					MySqlDataType.Blob => "BLOB",
					MySqlDataType.MediumBlob => "MEDIUMBLOB",
					MySqlDataType.LongBlob => "LONGBLOB",
					MySqlDataType.Char => $"CHAR({Parameters})",
					MySqlDataType.VarChar => $"VARCHAR({Parameters})",
					MySqlDataType.Binary => $"BINARY({Parameters})",
					MySqlDataType.VarBinary => $"VARBINARY({Parameters})",
					_ => throw new InvalidEnumArgumentException($"Invalid \"DataType\": '{this.DataType}'."),
				};
				sb.Append($" {dataType}");

				if (this.IsPrimaryKey)
				{
					sb.Append(" PRIMARY KEY");
				}
			}
			else if (DataType.GetType() == typeof(SqlServerDataType))
			{
				throw new NotImplementedException();
			}
			else
			{
				throw new InvalidDataTypeException(DataType.GetType());
			}
			return sb.ToString();
		}
	}
}
