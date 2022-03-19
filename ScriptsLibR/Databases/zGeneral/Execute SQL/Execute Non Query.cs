using ScriptsLibR.Extensions;

using System.Data.Common;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.General
{
	public partial class General
	{
		public int ExecuteNonQuery(DbConnection con, string sql)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);

			using (DbCommand cmd = con.CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteNonQuery();
			}
		}

		public int ExecuteNonQuery(DbCommand cmd, string sql)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);
			cmd.ThrowArgumentNullExceptionIfNull("cmd");

			cmd.CommandText = sql;
			return cmd.ExecuteNonQuery();
		}

		public int[] ExecuteNonQuery(DbConnection con, string[] sqls)
		{
			sqls.ThrowArgumentNullExceptionIfNull("sqls", true);

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

		public int[] ExecuteNonQuery(DbCommand cmd, string[] sqls)
		{
			sqls.ThrowArgumentNullExceptionIfNull("slqs", true);
			cmd.ThrowArgumentNullExceptionIfNull("cmd");

			int[] returnValue = new int[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				cmd.CommandText = sqls[i];
				returnValue[i] = cmd.ExecuteNonQuery();
			}
			return returnValue;
		}

		public async Task<int> ExecuteNonQueryAsync(DbConnection con, string sql)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);

			using (DbCommand cmd = con.CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
			}
		}

		public async Task<int> ExecuteNonQueryAsync(DbCommand cmd, string sql)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);
			cmd.ThrowArgumentNullExceptionIfNull("cmd");

			cmd.CommandText = sql;
			return await cmd.ExecuteNonQueryAsync();
		}

		public async Task<int[]> ExecuteNonQueryAsync(DbConnection con, string[] sqls)
		{
			sqls.ThrowArgumentNullExceptionIfNull("sqls", true);

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

		public async Task<int[]> ExecuteNonQueryAsync(DbCommand cmd, string[] sqls)
		{
			sqls.ThrowArgumentNullExceptionIfNull("sqls", true);
			cmd.ThrowArgumentNullExceptionIfNull("cmd");

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
