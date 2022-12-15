using System.Threading.Tasks;

using ScriptsLibR.Util;

namespace ScriptsLibR.Databases
{
	public partial class SqlServerDB
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
			Utils.NullChecker(true, (tableName, nameof(tableName)));
		}
	}
}