using ScriptsLibR.Extensions;
using ScriptsLibR.Interfaces;

using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		/// <summary>Deletes a value from the database.</summary>
		/// <param name="tableName">The table from where to delete the value.</param>
		/// <param name="condition">The condition to delete the value.</param>
		public int Delete(string tableName, string condition)
		{
			this.DeleteCode(tableName, condition);
			return this.ExecuteNonQuery($"DELETE FROM {tableName} WHERE {condition}");
		}

		/// <summary>Deletes a value from the database.</summary>
		/// <param name="tableName">The table from where to delete the value.</param>
		/// <param name="condition">The condition to delete the value.</param>
		public async Task<int> DeleteAsync(string tableName, string condition)
		{
			this.DeleteCode(tableName, condition);
			return await this.ExecuteNonQueryAsync($"DELETE FROM {tableName} WHERE {condition}");
		}

		private void DeleteCode(string tableName, string condition)
		{
			tableName.ThrowArgumentNullExceptionIfNull("tableName", true);
			condition.ThrowArgumentNullExceptionIfNull("condition", true);
		}
	}
}
