using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.SqlServerDB
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
					SqlServerDataTypes.Text => "ntext",
					SqlServerDataTypes.Number => "bigint",
					SqlServerDataTypes.Image => "image",
					SqlServerDataTypes.Money => "money",
					SqlServerDataTypes.Decimal => "decimal(38,38)",
					SqlServerDataTypes.DateAndTime => "datetime2",
					SqlServerDataTypes.Date => "date",
					SqlServerDataTypes.Time => "time",
					_ => throw new Exception("Invalid Field DataType."),
				};

				columns.Add($"{field.Name} {dataType}");
			}
			return string.Join(", ", columns.ToArray());
		}
	}
}
