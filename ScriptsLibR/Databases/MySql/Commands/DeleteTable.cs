using System.Threading.Tasks;

using ScriptsLibR.Extensions;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB : DatabaseRunner, IDatabase
	{
		public int DeleteTable(string tableName)
		{
			DeleteTableCode(tableName);
			return ExecuteNonQuery(GetDatabaseConnection(), $"DROP TABLE {tableName}");
		}

		public async Task<int> DeleteTableAsync(string tableName)
		{
			DeleteTableCode(tableName);
			return await ExecuteNonQueryAsync(GetDatabaseConnection(), $"DROP TABLE {tableName}");
		}

		private void DeleteTableCode(string tableName)
		{
			tableName.ThrowExceptionIfNull(nameof(tableName), true);
		}
	}
}
