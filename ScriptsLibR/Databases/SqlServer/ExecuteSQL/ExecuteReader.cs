using ScriptsLibR.Extensions;

using System;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.SqlServer
{
	public partial class SqlServerDB
	{
		public SqlDataReader ExecuteReader(string sql, bool requiresDatabaseToExist)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sql));
			}

			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteReader();
			}
		}

		public SqlDataReader ExecuteReader(string sql, SqlCommand cmd)
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


		public SqlDataReader[] ExecuteReader(string[] sqls, bool requiresDatabaseToExist)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}

			SqlDataReader[] returnValue = new SqlDataReader[sqls.Length];
			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = cmd.ExecuteReader();
				}
			}
			return returnValue;
		}

		public SqlDataReader[] ExecuteReader(string[] sqls, SqlCommand cmd)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}
			if (cmd == null)
			{
				throw new ArgumentNullException(nameof(cmd));
			}

			SqlDataReader[] returnValue = new SqlDataReader[sqls.Length];
			for (int i = 0; i < sqls.Length; i++)
			{
				cmd.CommandText = sqls[i];
				returnValue[i] = cmd.ExecuteReader();
			}
			return returnValue;
		}

		public async Task<DbDataReader> ExecuteReaderAsync(string sql, bool requiresDatabaseToExist)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sql));
			}

			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteReaderAsync();
			}
		}

		public async Task<DbDataReader> ExecuteReaderAsync(string sql, OleDbCommand cmd)
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


		public async Task<DbDataReader[]> ExecuteReaderAsync(string[] sqls, bool requiresDatabaseToExist)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}

			DbDataReader[] returnValue = new DbDataReader[sqls.Length];
			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = await cmd.ExecuteReaderAsync();
				}
			}
			return returnValue;
		}

		public async Task<DbDataReader[]> ExecuteReaderAsync(string[] sqls, OleDbCommand cmd)
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
