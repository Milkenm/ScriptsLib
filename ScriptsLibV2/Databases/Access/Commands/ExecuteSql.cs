using System.Data;
using System.Threading.Tasks;

using ScriptsLibV2.Util;

namespace ScriptsLibV2.Databases
{
	public partial class AccessDB : DatabaseRunner, IDatabase
	{
		public DataTable ExecuteSql(string sql)
		{
			Utils.NullChecker(true, (sql, nameof(sql)));

			return ExecuteReader(GetDatabaseConnection(), sql);
		}

		public async Task<DataTable> ExecuteSqlAsync(string sql)
		{
			Utils.NullChecker(true, (sql, nameof(sql)));

			return await ExecuteReaderAsync(GetDatabaseConnection(), sql);
		}
	}
}
