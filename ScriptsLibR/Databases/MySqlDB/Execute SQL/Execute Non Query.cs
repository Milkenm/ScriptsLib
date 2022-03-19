using MySql.Data.MySqlClient;

using ScriptsLibR.Extensions;

using System.Threading.Tasks;

namespace ScriptsLibR.Databases.MySqlDB
{
	public partial class MySqlDB
	{
		public int ExecuteNonQuery(string sql)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);

			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteNonQuery();
			}
		}

		public int ExecuteNonQuery(string sql, MySqlCommand cmd)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);
			cmd.ThrowArgumentNullExceptionIfNull("cmd");

			cmd.CommandText = sql;
			return cmd.ExecuteNonQuery();
		}

		public int[] ExecuteNonQuery(string[] sqls)
		{
			sqls.ThrowArgumentNullExceptionIfNull("sqls", true);

			int[] returnValue = new int[sqls.Length];
			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = cmd.ExecuteNonQuery();
				}
			}
			return returnValue;
		}

		public int[] ExecuteNonQuery(string[] sqls, MySqlCommand cmd)
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

		public async Task<int> ExecuteNonQueryAsync(string sql)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);

			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
			}
		}

		public async Task<int> ExecuteNonQueryAsync(string sql, MySqlCommand cmd)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);
			cmd.ThrowArgumentNullExceptionIfNull("cmd");

			cmd.CommandText = sql;
			return await cmd.ExecuteNonQueryAsync();
		}

		public async Task<int[]> ExecuteNonQueryAsync(string[] sqls)
		{
			sqls.ThrowArgumentNullExceptionIfNull("sqls", true);

			int[] returnValue = new int[sqls.Length];
			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = await cmd.ExecuteNonQueryAsync();
				}
			}
			return returnValue;
		}

		public async Task<int[]> ExecuteNonQueryAsync(string[] sqls, MySqlCommand cmd)
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
