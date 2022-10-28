using ScriptsLibR.Extensions;

using System.Threading.Tasks;

namespace ScriptsLibR.Databases.SqlServer
{
	public partial class SqlServerDB
	{
		/*
		public int DeleteTable(string tableName)
		{
			this.DeleteTableCode(tableName);
			return this.ExecuteNonQuery($"DROP TABLE {tableName}", true);
		}

		public async Task<int> DeleteTableAsync(string tableName)
		{
			this.DeleteTableCode(tableName);
			return await this.ExecuteNonQueryAsync($"DROP TABLE {tableName}", true);
		}

		private void DeleteTableCode(string tableName)
		{
			tableName.ThrowArgumentNullExceptionIfNull("tableName", true);
		}
		*/
	}
}
