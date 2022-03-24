using ScriptsLibR.Extensions;
using ScriptsLibR.Interfaces;

using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public int Update(string table, string update, string condition)
		{
			this.UpdateCode(table, update, condition);
			return this.ExecuteNonQuery($"UPDATE [{table}] SET {update} WHERE {condition}");
		}

		public async Task<int> UpdateAsync(string table, string update, string condition)
		{
			this.UpdateCode(table, update, condition);
			return await this.ExecuteNonQueryAsync($"UPDATE [{table}] SET {update} WHERE {condition}");
		}

		private void UpdateCode(string table, string update, string condition)
		{
			table.ThrowArgumentNullExceptionIfNull("table", true);
			update.ThrowArgumentNullExceptionIfNull("update", true);
			condition.ThrowArgumentNullExceptionIfNull("condition", true);
		}
	}
}
