using ScriptsLibR.Interfaces;
using ScriptsLibR.Utils.Database;

using System.Data.OleDb;
using System.Threading.Tasks;

#nullable enable
namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public object? ExecuteScalar(string sql)
		{
			return DatabaseUtils.ExecuteScalar(this.GetDbConnection(), sql);
		}

		public object? ExecuteScalar(string sql, OleDbCommand cmd)
		{
			return DatabaseUtils.ExecuteScalar(cmd, sql);
		}

		public object?[] ExecuteScalar(string[] sqls)
		{
			return DatabaseUtils.ExecuteScalar(this.GetDbConnection(), sqls);
		}

		public object?[] ExecuteScalar(string[] sqls, OleDbCommand cmd)
		{
			return DatabaseUtils.ExecuteScalar(cmd, sqls);
		}

		public async Task<object?> ExecuteScalarAsync(string sql)
		{
			return await DatabaseUtils.ExecuteScalarAsync(this.GetDbConnection(), sql);
		}

		public async Task<object?> ExecuteScalarAsync(OleDbCommand cmd, string sql)
		{
			return await DatabaseUtils.ExecuteScalarAsync(cmd, sql);
		}

		public async Task<object?[]> ExecuteScalarAsync(string[] sqls)
		{
			return await DatabaseUtils.ExecuteScalarAsync(this.GetDbConnection(), sqls);
		}

		public async Task<object?[]> ExecuteScalarAsync(string[] sqls, OleDbCommand cmd)
		{
			return await DatabaseUtils.ExecuteScalarAsync(cmd, sqls);
		}
	}
}
