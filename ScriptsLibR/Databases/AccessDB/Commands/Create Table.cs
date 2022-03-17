using ScriptsLibR.Extensions;

using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public int CreateTable(string tableName, List<AccessTableFields> fields)
		{
			string columnsString = this.CreateTableCode(tableName, fields);
			return this.ExecuteNonQuery($"CREATE TABLE {tableName} ({columnsString})", true);
		}

		public async Task<int> CreateTableAsync(string tableName, List<AccessTableFields> fields)
		{
			string columnsString = this.CreateTableCode(tableName, fields);
			return await this.ExecuteNonQueryAsync($"CREATE TABLE {tableName} ({columnsString})", true);
		}

		public string CreateTableCode(string tableName, List<AccessTableFields> fields)
		{
			tableName.ThrowArgumentNullExceptionIfNull("tableName", true);
			(fields.Count == 0).ThrowArgumentNullExceptionIfTrue("fields");

			List<string> columns = new List<string>();
			foreach (AccessTableFields field in fields)
			{
				string dataType = field.DataType switch
				{
					AccessDataTypes.Text => "text",
					AccessDataTypes.Number => "long",
					AccessDataTypes.Currency => "currency",
					AccessDataTypes.Decimal => "double",
					AccessDataTypes.DateTime => "date/time",
					AccessDataTypes.PrimaryKey => "key",
					_ => throw new InvalidEnumArgumentException($"Invalid \"fields\" value: '{fields}'."),
				};

				if (field.DataType == AccessDataTypes.PrimaryKey)
				{
					columns.Add($"[{field.Name}] AUTOINCREMENT PRIMARY KEY");
				}
				else
				{
					columns.Add($"[{field.Name}] {dataType}");
				}
			}
			return string.Join(", ", columns.ToArray());
		}
	}
}
