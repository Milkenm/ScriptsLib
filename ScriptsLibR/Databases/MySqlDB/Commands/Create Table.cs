
using ScriptsLibR.Extensions;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		/*
		public int CreateTable(string tableName, List<MySqlTableColumn> fields)
		{
			string columnsString = this.CreateTableCode(tableName, fields);
			return this.ExecuteNonQuery($"CREATE TABLE {tableName} ({columnsString})");
		}

		public async Task<int> CreateTableAsync(string tableName, List<MySqlTableFields> fields)
		{
			string columnsString = this.CreateTableCode(tableName, fields);
			return await this.ExecuteNonQueryAsync($"CREATE TABLE {tableName} ({columnsString})");
		}

		private string CreateTableCode(string tableName, List<MySqlTableFields> fields)
		{
			tableName.ThrowArgumentNullExceptionIfNull("tableName", true);
			(fields.Count == 0).ThrowArgumentNullExceptionIfTrue("fields");

			List<string> columns = new List<string>();
			foreach (MySqlTableFields field in fields)
			{
				string dataType = field.DataType switch
				{
					MySqlDataTypes.Text => "longtext",
					MySqlDataTypes.Number => "bigint",
					MySqlDataTypes.Money => "currency",
					MySqlDataTypes.Decimal => "double",
					MySqlDataTypes.DateAndTime => "datetime",
					MySqlDataTypes.Key => "key",
					MySqlDataTypes.Boolean => "boolean",
					MySqlDataTypes.Timestamp => "timestamp",
					MySqlDataTypes.Year => "year",
					_ => throw new Exception("Invalid Field DataType."),
				};

				if (dataType == "key")
				{
					columns.Add($"{field.Name} INT NOT NULL AUTO_INCREMENT, PRIMARY KEY ({field.Name})");
				}
				else
				{
					columns.Add($"{field.Name} {dataType}");
				}
			}
			return string.Join(", ", columns.ToArray());
		}*/
	}
}
