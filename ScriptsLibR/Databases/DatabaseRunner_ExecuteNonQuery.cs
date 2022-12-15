using System.Data.Common;
using System.Threading.Tasks;

using ScriptsLibR.Util;

namespace ScriptsLibR.Databases
{
	public abstract partial class DatabaseRunner
	{
		// ==================================================================== \\

		public int ExecuteNonQuery(DbConnection con, string sql)
		{
			Utils.NullChecker(true, (con, nameof(con)), (sql, nameof(sql)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return ExecuteNonQuery(cmd, sql);
			}
		}

		public int ExecuteNonQuery(DbCommand cmd, string sql)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)), (sql, nameof(sql)));

			cmd.CommandText = sql;
			return ExecuteNonQuery(cmd);
		}

		public int ExecuteNonQuery(DbCommand cmd)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)));

			return cmd.ExecuteNonQuery();
		}

		// ==================================================================== \\

		public int[] ExecuteNonQuery(DbConnection con, string[] sqls)
		{
			Utils.NullChecker(true, (con, nameof(con)), (sqls, nameof(sqls)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return ExecuteNonQuery(cmd, sqls);
			}
		}

		public int[] ExecuteNonQuery(DbCommand cmd, string[] sqls)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)), (sqls, nameof(sqls)));

			int[] result = new int[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				result[i] = ExecuteNonQuery(cmd, sqls[i]);
			}
			return result;
		}

		public int[] ExecuteNonQuery(DbCommand[] cmds)
		{
			Utils.NullChecker(true, (cmds, nameof(cmds)));

			int[] result = new int[cmds.Length];
			for (int i = 0; i < cmds.Length; i++)
			{
				result[i] = ExecuteNonQuery(cmds[i]);
			}
			return result;
		}

		// ==================================================================== \\

		public async Task<int> ExecuteNonQueryAsync(DbConnection con, string sql)
		{
			await Utils.NullCheckerAsync(true, (con, nameof(con)), (sql, nameof(sql)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return await ExecuteNonQueryAsync(cmd, sql);
			}
		}

		public async Task<int> ExecuteNonQueryAsync(DbCommand cmd, string sql)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)), (sql, nameof(sql)));

			cmd.CommandText = sql;
			return await ExecuteNonQueryAsync(cmd);
		}

		public async Task<int> ExecuteNonQueryAsync(DbCommand cmd)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)));

			return await cmd.ExecuteNonQueryAsync();
		}

		// ==================================================================== \\

		public async Task<int[]> ExecuteNonQueryAsync(DbConnection con, string[] sqls)
		{
			await Utils.NullCheckerAsync(true, (con, nameof(con)), (sqls, nameof(sqls)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return await ExecuteNonQueryAsync(cmd, sqls);
			}
		}

		public async Task<int[]> ExecuteNonQueryAsync(DbCommand cmd, string[] sqls)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)), (sqls, nameof(sqls)));

			int[] result = new int[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				result[i] = await ExecuteNonQueryAsync(cmd, sqls[i]);
			}
			return result;
		}

		public async Task<int[]> ExecuteNonQueryAsync(DbCommand[] cmds)
		{
			await Utils.NullCheckerAsync(true, (cmds, nameof(cmds)));

			int[] result = new int[cmds.Length];
			for (int i = 0; i < cmds.Length; i++)
			{
				result[i] = await ExecuteNonQueryAsync(cmds[i]);
			}
			return result;
		}

		// ==================================================================== \\
	}
}
