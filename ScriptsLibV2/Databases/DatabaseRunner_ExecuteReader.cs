using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

using ScriptsLibV2.Util;

namespace ScriptsLibV2.Databases
{
	public abstract partial class DatabaseRunner
	{
		// ==================================================================== \\

		public DataTable ExecuteReader(DbConnection con, string sql)
		{
			Utils.NullChecker(true, (con, nameof(con)), (sql, nameof(sql)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return ExecuteReader(cmd, sql);
			}
		}

		public DataTable ExecuteReader(DbCommand cmd, string sql)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)), (sql, nameof(sql)));

			cmd.CommandText = sql;
			return ExecuteReader(cmd);
		}

		public DataTable ExecuteReader(DbCommand cmd)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)));

			using (DbDataReader dr = cmd.ExecuteReader())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		// ==================================================================== \\

		public DataTable[] ExecuteReader(DbConnection con, string[] sqls)
		{
			Utils.NullChecker(true, (con, nameof(con)), (sqls, nameof(sqls)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return ExecuteReader(cmd, sqls);
			}
		}

		public DataTable[] ExecuteReader(DbCommand cmd, string[] sqls)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)), (sqls, nameof(sqls)));

			DataTable[] result = new DataTable[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				result[i] = ExecuteReader(cmd, sqls[i]);
			}
			return result;
		}

		public DataTable[] ExecuteReader(DbCommand[] cmds)
		{
			Utils.NullChecker(true, (cmds, nameof(cmds)));

			DataTable[] result = new DataTable[cmds.Length];
			for (int i = 0; i < cmds.Length; i++)
			{
				result[i] = ExecuteReader(cmds[i]);
			}
			return result;
		}

		// ==================================================================== \\

		public async Task<DataTable> ExecuteReaderAsync(DbConnection con, string sql)
		{
			await Utils.NullCheckerAsync(true, (con, nameof(con)), (sql, nameof(sql)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return await ExecuteReaderAsync(cmd, sql);
			}
		}

		public async Task<DataTable> ExecuteReaderAsync(DbCommand cmd, string sql)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)), (sql, nameof(sql)));

			cmd.CommandText = sql;
			return await ExecuteReaderAsync(cmd);
		}

		public async Task<DataTable> ExecuteReaderAsync(DbCommand cmd)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)));

			using (DbDataReader dr = await cmd.ExecuteReaderAsync())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		// ==================================================================== \\

		public async Task<DataTable[]> ExecuteReaderAsync(DbConnection con, string[] sqls)
		{
			await Utils.NullCheckerAsync(true, (con, nameof(con)), (sqls, nameof(sqls)));

			using (DbCommand cmd = con.CreateCommand())
			{
				return await ExecuteReaderAsync(cmd, sqls);
			}
		}

		public async Task<DataTable[]> ExecuteReaderAsync(DbCommand cmd, string[] sqls)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)), (sqls, nameof(sqls)));

			DataTable[] result = new DataTable[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				cmd.CommandText = sqls[i];
				result[i] = await ExecuteReaderAsync(cmd, sqls[i]);
			}
			return result;
		}

		public async Task<DataTable[]> ExecuteReaderAsync(DbCommand[] cmds)
		{
			await Utils.NullCheckerAsync(true, (cmds, nameof(cmds)));

			DataTable[] result = new DataTable[cmds.Length];
			for (int i = 0; i < cmds.Length; i++)
			{
				result[i] = await ExecuteReaderAsync(cmds[i]);
			}
			return result;
		}

		// ==================================================================== \\
	}
}
