using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public int DeleteTable(string tableName)
		{
			return this.ExecuteNonQuery($"DROP TABLE {tableName}", true);
		}

		public async Task<int> DeleteTableAsync(string tableName)
		{
			return await this.ExecuteNonQueryAsync($"DROP TABLE {tableName}", true);
		}
	}
}
