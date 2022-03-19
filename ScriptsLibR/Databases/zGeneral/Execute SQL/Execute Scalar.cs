using ScriptsLibR.Extensions;

using System;
using System.Data.Common;
using System.Threading.Tasks;

#nullable enable
namespace ScriptsLibR.Databases.General
{
	public partial class General
	{
		public object? ExecuteScalar(DbConnection con, string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}

			using (DbCommand cmd = con.CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteScalar();
			}
		}

		public object? ExecuteScalar(DbCommand cmd, string sql)
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

		public object?[] ExecuteScalar(DbConnection con, string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sqls");
			}

			object?[] returnValue = new object?[sqls.Length];
			using (DbCommand cmd = con.CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = cmd.ExecuteScalar();
				}
			}
			return returnValue;
		}

		public object?[] ExecuteScalar(DbCommand cmd, string[] sqls)
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

		public async Task<object?> ExecuteScalarAsync(DbConnection con, string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}

			using (DbCommand cmd = con.CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteScalarAsync();
			}
		}

		public async Task<object?> ExecuteScalarAsync(DbCommand cmd, string sql)
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

		public async Task<object?[]> ExecuteScalarAsync(DbConnection con, string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}

			object?[] returnValue = new object?[sqls.Length];
			using (DbCommand cmd = con.CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = await cmd.ExecuteScalarAsync();
				}
			}
			return returnValue;
		}

		public async Task<object?[]> ExecuteScalarAsync(DbCommand cmd, string[] sqls)
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
