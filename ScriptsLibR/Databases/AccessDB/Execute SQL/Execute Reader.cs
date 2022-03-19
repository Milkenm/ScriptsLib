using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public DataTable ExecuteReader(string sql)
		{
			return new General.General().ExecuteReader(this.GetDbConnection(), sql);
		}

		public DataTable ExecuteReader(string sql, OleDbCommand cmd)
		{
			return new General.General().ExecuteReader(cmd, sql);
		}

		public DataTable ExecuteReader(string[] sqls)
		{
			return new General.General().ExecuteReader(this.GetDbConnection(), sqls);
		}

		public DataTable ExecuteReader(string[] sqls, OleDbCommand cmd)
		{
			return new General.General().ExecuteReader(cmd, sqls);
		}

		public async Task<DataTable> ExecuteReaderAsync(string sql)
		{
			return await new General.General().ExecuteReaderAsync(this.GetDbConnection(), sql);
		}

		public async Task<DataTable> ExecuteReaderAsync(string sql, OleDbCommand cmd)
		{
			return await new General.General().ExecuteReaderAsync(cmd, sql);
		}

		public async Task<DataTable> ExecuteReaderAsync(string[] sqls)
		{
			return await new General.General().ExecuteReaderAsync(this.GetDbConnection(), sqls);
		}

		public async Task<DataTable> ExecuteReaderAsync(string[] sqls, OleDbCommand cmd)
		{
			return await new General.General().ExecuteReaderAsync(cmd, sqls);
		}
	}
}
