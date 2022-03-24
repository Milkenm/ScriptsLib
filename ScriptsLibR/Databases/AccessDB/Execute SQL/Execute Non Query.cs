using ScriptsLibR.Interfaces;
using ScriptsLibR.Utils.Database;

using System.Data.OleDb;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public int ExecuteNonQuery(string sql)
		{
			return DatabaseUtils.ExecuteNonQuery(this.GetDbConnection(), sql);
		}

		public int ExecuteNonQuery(string sql, OleDbCommand cmd)
		{
			return DatabaseUtils.ExecuteNonQuery(cmd, sql);
		}

		public int[] ExecuteNonQuery(string[] sqls)
		{
			return DatabaseUtils.ExecuteNonQuery(this.GetDbConnection(), sqls);
		}

		public int[] ExecuteNonQuery(string[] sqls, OleDbCommand cmd)
		{
			return DatabaseUtils.ExecuteNonQuery(cmd, sqls);
		}

		public async Task<int> ExecuteNonQueryAsync(string sql)
		{
			return await DatabaseUtils.ExecuteNonQueryAsync(this.GetDbConnection(), sql);
		}

		public async Task<int> ExecuteNonQueryAsync(string sql, OleDbCommand cmd)
		{
			return await DatabaseUtils.ExecuteNonQueryAsync(cmd, sql);
		}

		public async Task<int[]> ExecuteNonQueryAsync(string[] sqls)
		{
			return await DatabaseUtils.ExecuteNonQueryAsync(this.GetDbConnection(), sqls);
		}

		public async Task<int[]> ExecuteNonQueryAsync(string[] sqls, OleDbCommand cmd)
		{
			return await DatabaseUtils.ExecuteNonQueryAsync(cmd, sqls);
		}
	}
}
