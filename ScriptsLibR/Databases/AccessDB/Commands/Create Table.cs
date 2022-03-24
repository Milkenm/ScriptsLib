using ScriptsLibR.Extensions;
using ScriptsLibR.Interfaces;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases
{
	public partial class AccessDB
	{
		public int CreateTable(string tableName, params IDatabaseTableColumn[] fields)
		{
			string columnsString = this.CreateTableCode(tableName, fields);
			return this.ExecuteNonQuery($"CREATE TABLE [{tableName}] ({columnsString})");
		}

		public async Task<int> CreateTableAsync(string tableName, params IDatabaseTableColumn[] fields)
		{
			string columnsString = this.CreateTableCode(tableName, fields);
			return await this.ExecuteNonQueryAsync($"CREATE TABLE [{tableName}] ({columnsString})");
		}

		private string CreateTableCode(string tableName, params IDatabaseTableColumn[] fields)
		{
			tableName.ThrowArgumentNullExceptionIfNull("tableName", true);
			(fields.Length == 0).ThrowArgumentNullExceptionIfTrue("fields");

			List<string> columns = new List<string>();
			foreach (AccessTableColumn field in fields)
			{
				columns.Add(field.ToString());
			}
			return string.Join(", ", columns.ToArray());
		}
	}
}
