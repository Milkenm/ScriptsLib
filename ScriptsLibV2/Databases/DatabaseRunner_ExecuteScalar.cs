using System.Data.Common;
using System.Threading.Tasks;

using ScriptsLibV2.Util;

#nullable enable
namespace ScriptsLibV2.Databases
{
	public abstract partial class DatabaseRunner
	{
		// ==================================================================== \\

		public object? ExecuteScalar(DbConnection con, string sql)
		{
			Utils.NullChecker(true, (con, nameof(con)), (sql, nameof(sql)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return ExecuteScalar(cmd, sql);
			}
		}

		public object? ExecuteScalar(DbCommand cmd, string sql)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)), (sql, nameof(sql)));

			cmd.CommandText = sql;
			return ExecuteScalar(cmd);
		}

		public object? ExecuteScalar(DbCommand cmd)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)));

			return cmd.ExecuteScalar();
		}

		// ==================================================================== \\

		public object?[] ExecuteScalar(DbConnection con, string[] sqls)
		{
			Utils.NullChecker(true, (con, nameof(con)), (sqls, nameof(sqls)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return ExecuteScalar(cmd, sqls);
			}
		}

		public object?[] ExecuteScalar(DbCommand cmd, string[] sqls)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)), (sqls, nameof(sqls)));

			object?[] result = new object?[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				result[i] = ExecuteScalar(cmd, sqls[i]);
			}
			return result;
		}

		public object?[] ExecuteScalar(DbCommand[] cmds)
		{
			Utils.NullChecker(true, (cmds, nameof(cmds)));

			object?[] result = new object?[cmds.Length];
			for (int i = 0; i < cmds.Length; i++)
			{
				result[i] = ExecuteScalar(cmds[i]);
			}
			return result;
		}

		// ==================================================================== \\

		public async Task<object?> ExecuteScalarAsync(DbConnection con, string sql)
		{
			await Utils.NullCheckerAsync(true, (con, nameof(con)), (sql, nameof(sql)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return await ExecuteScalarAsync(cmd, sql);
			}
		}

		public async Task<object?> ExecuteScalarAsync(DbCommand cmd, string sql)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)), (sql, nameof(sql)));

			cmd.CommandText = sql;
			return await ExecuteScalarAsync(cmd);
		}

		public async Task<object?> ExecuteScalarAsync(DbCommand cmd)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)));

			return await cmd.ExecuteScalarAsync();
		}

		// ==================================================================== \\

		public async Task<object?[]> ExecuteScalarAsync(DbConnection con, string[] sqls)
		{
			await Utils.NullCheckerAsync(true, (con, nameof(con)), (sqls, nameof(sqls)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return await ExecuteScalarAsync(cmd, sqls);
			}
		}

		public async Task<object?[]> ExecuteScalarAsync(DbCommand cmd, string[] sqls)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)), (sqls, nameof(sqls)));

			object?[] result = new object?[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				cmd.CommandText = sqls[i];
				result[i] = await ExecuteScalarAsync(cmd);
			}
			return result;
		}

		public async Task<object?[]> ExecuteScalarAsync(DbCommand[] cmds)
		{
			await Utils.NullCheckerAsync(true, (cmds, nameof(cmds)));

			object?[] result = new object?[cmds.Length];
			for (int i = 0; i < cmds.Length; i++)
			{
				result[i] = await ExecuteScalarAsync(cmds[i]);
			}
			return result;
		}

		// ==================================================================== \\
	}
}
#nullable disable