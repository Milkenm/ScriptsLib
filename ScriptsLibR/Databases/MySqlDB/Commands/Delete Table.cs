using ScriptsLibR.Extensions;

using System;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		public int DeleteTable(string tableName)
		{
			//this.DeleteTableCode(tableName);
			//return this.ExecuteNonQuery($"DROP TABLE {tableName}", true);
			throw new NotImplementedException();
		}

		public async Task<int> DeleteTableAsync(string tableName)
		{
			//this.DeleteTableCode(tableName);
			//return await this.ExecuteNonQueryAsync($"DROP TABLE {tableName}", true);
			throw new NotImplementedException();
		}

		private void DeleteTableCode(string tableName)
		{
			tableName.ThrowArgumentNullExceptionIfNull("tableName", true);
		}
	}
}
