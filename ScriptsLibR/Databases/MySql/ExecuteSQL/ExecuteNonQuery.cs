using MySql.Data.MySqlClient;

using ScriptsLibR.Extensions;

using System.Threading.Tasks;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		public int ExecuteNonQuery(string sql)
		{
			sql.ThrowExceptionIfNull("sql", true);

			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteNonQuery();
			}
		}

		public static int ExecuteNonQuery(string sql, MySqlCommand cmd)
		{
			sql.ThrowExceptionIfNull("sql", true);
			cmd.ThrowExceptionIfNull("cmd");

			cmd.CommandText = sql;
			return cmd.ExecuteNonQuery();
		}

		public int[] ExecuteNonQuery(string[] sqls)
		{
			sqls.ThrowExceptionIfNull("sqls", true);

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

		public static int[] ExecuteNonQuery(string[] sqls, MySqlCommand cmd)
		{
			sqls.ThrowExceptionIfNull("slqs", true);
			cmd.ThrowExceptionIfNull("cmd");

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
			sql.ThrowExceptionIfNull("sql", true);

			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
			}
		}

		public static async Task<int> ExecuteNonQueryAsync(string sql, MySqlCommand cmd)
		{
			sql.ThrowExceptionIfNull("sql", true);
			cmd.ThrowExceptionIfNull("cmd");

			cmd.CommandText = sql;
			return await cmd.ExecuteNonQueryAsync();
		}

		public async Task<int[]> ExecuteNonQueryAsync(string[] sqls)
		{
			sqls.ThrowExceptionIfNull("sqls", true);

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

		public static async Task<int[]> ExecuteNonQueryAsync(string[] sqls, MySqlCommand cmd)
		{
			sqls.ThrowExceptionIfNull("sqls", true);
			cmd.ThrowExceptionIfNull("cmd");

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
