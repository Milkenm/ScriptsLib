using ScriptsLibR.Extensions;

using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading.Tasks;

#nullable enable
namespace ScriptsLibR.Databases.SqlServer
{
	public partial class SqlServerDB
	{
		public object? ExecuteScalar(string sql, bool requiresDatabaseToExist)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sql));
			}

			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteScalar();
			}
		}

		public object? ExecuteScalar(OleDbCommand cmd, string sql)
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

		public object?[] ExecuteScalar(string[] sqls, bool requiresDatabaseToExist)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}

			object?[] returnValue = new object?[sqls.Length];
			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
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

		public async Task<object?> ExecuteScalarAsync(string sql, bool requiresDatabaseToExist)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sql));
			}

			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteScalarAsync();
			}
		}

		public async Task<object?> ExecuteScalarAsync(OleDbCommand cmd, string sql)
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

		public async Task<object?[]> ExecuteScalarAsync(string[] sqls, bool requiresDatabaseToExist)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}

			object?[] returnValue = new object?[sqls.Length];
			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
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
