using MySql.Data.MySqlClient;

using ScriptsLibR.Extensions;

using System;
using System.Threading.Tasks;

#nullable enable
namespace ScriptsLibR.Databases.MySqlDB
{
	public partial class MySqlDB
	{
		public object? ExecuteScalar(string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}

			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteScalar();
			}
		}

		public object? ExecuteScalar(MySqlCommand cmd, string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}
			if (cmd == null)
			{
				throw new ArgumentNullException("cmd");
			}

			cmd.CommandText = sql;
			return cmd.ExecuteScalar();
		}

		public object?[] ExecuteScalar(string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sqls");
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

		public object?[] ExecuteScalar(string[] sqls, MySqlCommand cmd)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sqls");
			}
			if (cmd == null)
			{
				throw new ArgumentNullException("cmd");
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
				throw new ArgumentNullException("sql");
			}

			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteScalarAsync();
			}
		}

		public async Task<object?> ExecuteScalarAsync(MySqlCommand cmd, string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}
			if (cmd == null)
			{
				throw new ArgumentNullException("cmd");
			}

			cmd.CommandText = sql;
			return await cmd.ExecuteScalarAsync();
		}

		public async Task<object?[]> ExecuteScalarAsync(string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sql");
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

		public async Task<object?[]> ExecuteScalarAsync(string[] sqls, MySqlCommand cmd)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sqls");
			}
			if (cmd == null)
			{
				throw new ArgumentNullException("cmd");
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
