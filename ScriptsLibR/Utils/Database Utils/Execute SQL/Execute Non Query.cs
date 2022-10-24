
using System.Data.Common;
using System.Threading.Tasks;

namespace ScriptsLibR.Util.Database
{
	public partial class DatabaseUtils
	{
		public static int ExecuteNonQuery(DbConnection con, string sql)
		{
			Utils.NullChecker(true, (con, nameof(con)), (sql, nameof(sql)));

			using (DbCommand cmd = con.CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteNonQuery();
			}
		}

		public static int ExecuteNonQuery(DbCommand cmd, string sql)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)), (sql, nameof(sql)));

			cmd.CommandText = sql;
			return cmd.ExecuteNonQuery();
		}

		public static int[] ExecuteNonQuery(DbConnection con, string[] sqls)
		{
			Utils.NullChecker(true, (con, nameof(con)), (sqls, nameof(sqls)));

			int[] returnValue = new int[sqls.Length];
			using (DbCommand cmd = con.CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = cmd.ExecuteNonQuery();
				}
			}
			return returnValue;
		}

		public static int[] ExecuteNonQuery(DbCommand cmd, string[] sqls)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)), (sqls, nameof(sqls)));

			int[] returnValue = new int[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				cmd.CommandText = sqls[i];
				returnValue[i] = cmd.ExecuteNonQuery();
			}
			return returnValue;
		}

		public static async Task<int> ExecuteNonQueryAsync(DbConnection con, string sql)
		{
			await Utils.NullCheckerAsync(true, (con, nameof(con)), (sql, nameof(sql)));

			using (DbCommand cmd = con.CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
			}
		}

		public static async Task<int> ExecuteNonQueryAsync(DbCommand cmd, string sql)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)), (sql, nameof(sql)));

			cmd.CommandText = sql;
			return await cmd.ExecuteNonQueryAsync();
		}

		public static async Task<int[]> ExecuteNonQueryAsync(DbConnection con, string[] sqls)
		{
			await Utils.NullCheckerAsync(true, (con, nameof(con)), (sqls, nameof(sqls)));

			int[] returnValue = new int[sqls.Length];
			using (DbCommand cmd = con.CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = await cmd.ExecuteNonQueryAsync();
				}
			}
			return returnValue;
		}

		public static async Task<int[]> ExecuteNonQueryAsync(DbCommand cmd, string[] sqls)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)), (sqls, nameof(sqls)));

			int[] returnValue = new int[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				cmd.CommandText = sqls[i];
				returnValue[i] = await cmd.ExecuteNonQueryAsync();
			}
			return returnValue;
		}
	}
}
