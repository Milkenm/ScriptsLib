using System.Data.OleDb;
using System.Threading.Tasks;

#nullable enable
namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public object? ExecuteScalar(string sql)
		{
			return new General.General().ExecuteScalar(this.GetDbConnection(), sql);
		}

		public object? ExecuteScalar(string sql, OleDbCommand cmd)
		{
			return new General.General().ExecuteScalar(cmd, sql);
		}

		public object?[] ExecuteScalar(string[] sqls)
		{
			return new General.General().ExecuteScalar(this.GetDbConnection(), sqls);
		}

		public object?[] ExecuteScalar(string[] sqls, OleDbCommand cmd)
		{
			return new General.General().ExecuteScalar(cmd, sqls);
		}

		public async Task<object?> ExecuteScalarAsync(string sql)
		{
			return await new General.General().ExecuteScalarAsync(this.GetDbConnection(), sql);
		}

		public async Task<object?> ExecuteScalarAsync(OleDbCommand cmd, string sql)
		{
			return await new General.General().ExecuteScalarAsync(cmd, sql);
		}

		public async Task<object?[]> ExecuteScalarAsync(string[] sqls)
		{
			return await new General.General().ExecuteScalarAsync(this.GetDbConnection(), sqls);
		}

		public async Task<object?[]> ExecuteScalarAsync(string[] sqls, OleDbCommand cmd)
		{
			return await new General.General().ExecuteScalarAsync(cmd, sqls);
		}
	}
}
