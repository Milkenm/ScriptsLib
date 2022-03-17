using ScriptsLibR.Extensions;

using System;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public object? ExecuteScalar(string sql, bool requiresDatabaseToExist)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}

			using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteScalar();
			}
		}

		public object? ExecuteScalar(OleDbCommand cmd, string sql)
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

		public object?[] ExecuteScalar(string[] sqls, bool requiresDatabaseToExist)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sqls");
			}

			object?[] returnValue = new object?[sqls.Length];
			using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = cmd.ExecuteScalar();
				}
			}
			return returnValue;
		}

		public object?[] ExecuteScalar(string[] sqls, OleDbCommand cmd)
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

		public async Task<object?> ExecuteScalarAsync(string sql, bool requiresDatabaseToExist)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}

			using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteScalarAsync();
			}
		}

		public async Task<object?> ExecuteScalarAsync(OleDbCommand cmd, string sql)
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

		public async Task<object?[]> ExecuteScalarAsync(string[] sqls, bool requiresDatabaseToExist)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}

			object?[] returnValue = new object?[sqls.Length];
			using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = await cmd.ExecuteScalarAsync();
				}
			}
			return returnValue;
		}

		public async Task<object?[]> ExecuteScalarAsync(string[] sqls, OleDbCommand cmd)
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
