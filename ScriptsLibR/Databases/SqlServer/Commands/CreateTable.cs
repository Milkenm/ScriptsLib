using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ScriptsLibR.Databases.SqlServer.Types;

namespace ScriptsLibR.Databases.SqlServer
{
	public partial class SqlServerDB
	{
		public int CreateTable(string tableName, List<SqlServerTableFields> fields)
		{
			string columnsString = this.CreateTableCode(tableName, fields);
			return this.ExecuteNonQuery($"CREATE TABLE {tableName} ({columnsString})", true);
		}

		public async Task<int> CreateTableAsync(string tableName, List<SqlServerTableFields> fields)
		{
			string columnsString = this.CreateTableCode(tableName, fields);
			return await this.ExecuteNonQueryAsync($"CREATE TABLE {tableName} ({columnsString})", true);
		}

		public string CreateTableCode(string tableName, List<SqlServerTableFields> fields)
		{
			List<string> columns = new List<string>();
			foreach (SqlServerTableFields field in fields)
			{
				string dataType = field.DataType switch
				{
					SqlServerDataType.Text => "ntext",
					SqlServerDataType.Number => "bigint",
					SqlServerDataType.Image => "image",
					SqlServerDataType.Money => "money",
					SqlServerDataType.Decimal => "decimal(38,38)",
					SqlServerDataType.DateAndTime => "datetime2",
					SqlServerDataType.Date => "date",
					SqlServerDataType.Time => "time",
					_ => throw new Exception("Invalid Field DataType."),
				};

				columns.Add($"{field.Name} {dataType}");
			}
			return string.Join(", ", columns.ToArray());
		}
	}
}
