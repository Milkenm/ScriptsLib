using System.Threading.Tasks;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2.Databases
{
	public partial class AccessDB : DatabaseRunner, IDatabase
	{
		public int CreateTable(string tableName, params string[] fields)
		{
			string columnsString = CreateTableCode(tableName, fields);
			return ExecuteNonQuery(GetDatabaseConnection(), $"CREATE TABLE [{tableName}] ({columnsString})");
		}

		public async Task<int> CreateTableAsync(string tableName, params string[] fields)
		{
			string columnsString = CreateTableCode(tableName, fields);
			return await ExecuteNonQueryAsync(GetDatabaseConnection(), $"CREATE TABLE [{tableName}] ({columnsString})");
		}

		private string CreateTableCode(string tableName, params string[] fields)
		{
			tableName.ThrowExceptionIfNull(nameof(tableName), true);
			(fields.Length == 0).ThrowExceptionIfTrue(nameof(fields));

			return string.Join(",", fields);
		}
	}
}