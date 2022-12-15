using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ScriptsLibR.Extensions;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB : DatabaseRunner, IDatabase
	{
		public int CreateTable(string tableName, params string[] fields)
		{
			string columnsString = CreateTableCode(tableName, fields);
			return ExecuteNonQuery(GetDatabaseConnection(), $"CREATE TABLE `{tableName}` ({columnsString})");
		}

		public async Task<int> CreateTableAsync(string tableName, params string[] fields)
		{
			string columnsString = CreateTableCode(tableName, fields);
			return await ExecuteNonQueryAsync(GetDatabaseConnection(), $"CREATE TABLE `{tableName}` ({columnsString})"); ;
		}

		private string CreateTableCode(string tableName, params string[] fields)
		{
			tableName.ThrowExceptionIfNull(nameof(tableName), true);
			(fields.Length == 0).ThrowExceptionIfTrue(nameof(fields));

			List<string> formatedFields = new List<string>();
			foreach (string _field in fields)
			{
				string field = _field.Replace("`", "");
				string[] splitField = field.Split(' ');
				formatedFields.Add($"`{splitField[0]}` {string.Join(" ", splitField.Skip(1).ToArray())}");
			}

			return string.Join(",", fields);
		}
	}
}
