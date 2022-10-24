using ScriptsLibR.Interfaces;
using ScriptsLibR.Util.Database;

using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases
{
	public partial class AccessDB
	{
		public DataTable ExecuteReader(string sql)
		{
			return DatabaseUtils.ExecuteReader(this.GetDbConnection(), sql);
		}

		public DataTable ExecuteReader(string sql, OleDbCommand cmd)
		{
			return DatabaseUtils.ExecuteReader(cmd, sql);
		}

		public DataTable ExecuteReader(string[] sqls)
		{
			return DatabaseUtils.ExecuteReader(this.GetDbConnection(), sqls);
		}

		public DataTable ExecuteReader(string[] sqls, OleDbCommand cmd)
		{
			return DatabaseUtils.ExecuteReader(cmd, sqls);
		}

		public async Task<DataTable> ExecuteReaderAsync(string sql)
		{
			return await DatabaseUtils.ExecuteReaderAsync(this.GetDbConnection(), sql);
		}

		public async Task<DataTable> ExecuteReaderAsync(string sql, OleDbCommand cmd)
		{
			return await DatabaseUtils.ExecuteReaderAsync(cmd, sql);
		}

		public async Task<DataTable> ExecuteReaderAsync(string[] sqls)
		{
			return await DatabaseUtils.ExecuteReaderAsync(this.GetDbConnection(), sqls);
		}

		public async Task<DataTable> ExecuteReaderAsync(string[] sqls, OleDbCommand cmd)
		{
			return await DatabaseUtils.ExecuteReaderAsync(cmd, sqls);
		}
	}
}
