using System.Threading.Tasks;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2.Databases
{
	public partial class MySqlDB : DatabaseRunner, IDatabase
	{
		/// <summary>Deletes a value from the database.</summary>
		/// <param name="tableName">The table from where to delete the value.</param>
		/// <param name="condition">The condition to delete the value.</param>
		public int Delete(string tableName, string condition)
		{
			DeleteCode(tableName, condition);
			return ExecuteNonQuery(GetDatabaseConnection(), $"DELETE FROM {tableName} WHERE {condition}");
		}

		/// <summary>Deletes a value from the database.</summary>
		/// <param name="tableName">The table from where to delete the value.</param>
		/// <param name="condition">The condition to delete the value.</param>
		public async Task<int> DeleteAsync(string tableName, string condition)
		{
			DeleteCode(tableName, condition);
			return await ExecuteNonQueryAsync(GetDatabaseConnection(), $"DELETE FROM {tableName} WHERE {condition}");
		}

		private void DeleteCode(string tableName, string condition)
		{
			tableName.ThrowExceptionIfNull(nameof(tableName), true);
			condition.ThrowExceptionIfNull(nameof(condition), true);
		}
	}
}
