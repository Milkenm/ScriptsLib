using System.Data.OleDb;
using System.Threading.Tasks;
namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public int ExecuteNonQuery(string sql)
		{
			return new General.General().ExecuteNonQuery(this.GetDbConnection(), sql);
		}

		public int ExecuteNonQuery(string sql, OleDbCommand cmd)
		{
			return new General.General().ExecuteNonQuery(cmd, sql);
		}

		public int[] ExecuteNonQuery(string[] sqls)
		{
			return new General.General().ExecuteNonQuery(this.GetDbConnection(), sqls);
		}

		public int[] ExecuteNonQuery(string[] sqls, OleDbCommand cmd)
		{
			return new General.General().ExecuteNonQuery(cmd, sqls);
		}

		public async Task<int> ExecuteNonQueryAsync(string sql)
		{
			return await new General.General().ExecuteNonQueryAsync(this.GetDbConnection(), sql);
		}

		public async Task<int> ExecuteNonQueryAsync(string sql, OleDbCommand cmd)
		{
			return await new General.General().ExecuteNonQueryAsync(cmd, sql);
		}

		public async Task<int[]> ExecuteNonQueryAsync(string[] sqls)
		{
			return await new General.General().ExecuteNonQueryAsync(this.GetDbConnection(), sqls);
		}

		public async Task<int[]> ExecuteNonQueryAsync(string[] sqls, OleDbCommand cmd)
		{
			return await new General.General().ExecuteNonQueryAsync(cmd, sqls);
		}
	}
}
