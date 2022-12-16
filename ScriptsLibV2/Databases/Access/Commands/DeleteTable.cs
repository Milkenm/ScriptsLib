using System.Threading.Tasks;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2.Databases
{
	public partial class AccessDB : DatabaseRunner, IDatabase
	{
		public int DeleteTable(string tableName)
		{
			DeleteTableCode(tableName);
			return ExecuteNonQuery(GetDatabaseConnection(), $"DROP TABLE [{tableName}]");
		}

		public async Task<int> DeleteTableAsync(string tableName)
		{
			DeleteTableCode(tableName);
			return await ExecuteNonQueryAsync(GetDatabaseConnection(), $"DROP TABLE [{tableName}]");
		}

		private void DeleteTableCode(string tableName)
		{
			tableName.ThrowExceptionIfNull(nameof(tableName), true);
		}
	}
}
