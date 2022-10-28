using MySql.Data.MySqlClient;

using ScriptsLibR.Extensions;

using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		public MySqlDataReader ExecuteReader(string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sql));
			}

			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteReader();
			}
		}

		public static MySqlDataReader ExecuteReader(string sql, MySqlCommand cmd)
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
			return cmd.ExecuteReader();
		}


		public MySqlDataReader[] ExecuteReader(string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}

			MySqlDataReader[] returnValue = new MySqlDataReader[sqls.Length];
			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = cmd.ExecuteReader();
				}
			}
			return returnValue;
		}

		public static MySqlDataReader[] ExecuteReader(string[] sqls, MySqlCommand cmd)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}
			if (cmd == null)
			{
				throw new ArgumentNullException(nameof(cmd));
			}

			MySqlDataReader[] returnValue = new MySqlDataReader[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				cmd.CommandText = sqls[i];
				returnValue[i] = cmd.ExecuteReader();
			}
			return returnValue;
		}

		public async Task<DbDataReader> ExecuteReaderAsync(string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sql));
			}

			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteReaderAsync();
			}
		}

		public static async Task<DbDataReader> ExecuteReaderAsync(string sql, MySqlCommand cmd)
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
			return await cmd.ExecuteReaderAsync();
		}


		public async Task<DbDataReader[]> ExecuteReaderAsync(string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}

			DbDataReader[] returnValue = new DbDataReader[sqls.Length];
			using (MySqlCommand cmd = this.GetDbConnection().CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = await cmd.ExecuteReaderAsync();
				}
			}
			return returnValue;
		}

		public static async Task<DbDataReader[]> ExecuteReaderAsync(string[] sqls, MySqlCommand cmd)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}
			if (cmd == null)
			{
				throw new ArgumentNullException(nameof(cmd));
			}

			DbDataReader[] returnValue = new DbDataReader[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				cmd.CommandText = sqls[i];
				returnValue[i] = await cmd.ExecuteReaderAsync();
			}
			return returnValue;
		}
	}
}
