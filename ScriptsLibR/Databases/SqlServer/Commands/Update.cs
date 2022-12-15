using System.Threading.Tasks;

using ScriptsLibR.Extensions;

namespace ScriptsLibR.Databases
{
	public partial class SqlServerDB
	{
		public int Update(string table, string update, string condition)
		{
			UpdateCode(table, update, condition);
			return ExecuteNonQuery(GetDatabaseConnection(), $"UPDATE [{table}] SET {update} WHERE {condition}");
		}

		public async Task<int> UpdateAsync(string table, string update, string condition)
		{
			UpdateCode(table, update, condition);
			return await ExecuteNonQueryAsync(GetDatabaseConnection(), $"UPDATE [{table}] SET {update} WHERE {condition}");
		}

		private void UpdateCode(string table, string update, string condition)
		{
			table.ThrowExceptionIfNull(nameof(table), true);
			update.ThrowExceptionIfNull(nameof(update), true);
			condition.ThrowExceptionIfNull(nameof(condition), true);
		}
	}
}