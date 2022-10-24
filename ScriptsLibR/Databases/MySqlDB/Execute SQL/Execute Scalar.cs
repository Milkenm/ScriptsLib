using MySql.Data.MySqlClient;

using ScriptsLibR.Extensions;

using System;
using System.Threading.Tasks;

#nullable enable
namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		public object? ExecuteScalar(string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sql));
			}

			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteScalar();
			}
		}

		public static object? ExecuteScalar(string sql, MySqlCommand cmd)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sql));
			}
			if (cmd == null)
			{
				throw new ArgumentNullException(nameof(cmd));
			}

			cmd.CommandText = sql;
			return cmd.ExecuteScalar();
		}

		public object?[] ExecuteScalar(string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}

			object?[] returnValue = new object?[sqls.Length];
			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = cmd.ExecuteScalar();
				}
			}
			return returnValue;
		}

		public static object?[] ExecuteScalar(string[] sqls, MySqlCommand cmd)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}
			if (cmd == null)
			{
				throw new ArgumentNullException(nameof(cmd));
			}

			object?[] returnValue = new object?[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				cmd.CommandText = sqls[i];
				returnValue[i] = cmd.ExecuteScalar();
			}
			return returnValue;
		}

		public async Task<object?> ExecuteScalarAsync(string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sql));
			}

			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteScalarAsync();
			}
		}

		public static async Task<object?> ExecuteScalarAsync(string sql, MySqlCommand cmd)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sql));
			}
			if (cmd == null)
			{
				throw new ArgumentNullException(nameof(cmd));
			}

			cmd.CommandText = sql;
			return await cmd.ExecuteScalarAsync();
		}

		public async Task<object?[]> ExecuteScalarAsync(string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}

			object?[] returnValue = new object?[sqls.Length];
			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = await cmd.ExecuteScalarAsync();
				}
			}
			return returnValue;
		}

		public static async Task<object?[]> ExecuteScalarAsync(string[] sqls, MySqlCommand cmd)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}
			if (cmd == null)
			{
				throw new ArgumentNullException(nameof(cmd));
			}

			object?[] returnValue = new object?[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				cmd.CommandText = sqls[i];
				returnValue[i] = await cmd.ExecuteScalarAsync();
			}
			return returnValue;
		}
	}
}
