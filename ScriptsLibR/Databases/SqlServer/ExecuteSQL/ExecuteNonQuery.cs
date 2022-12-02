﻿using ScriptsLibR.Extensions;

using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.SqlServer
{
	public partial class SqlServerDB
	{
		public int ExecuteNonQuery(string sql, bool requiresDatabaseToExist)
		{
			sql.ThrowExceptionIfNull("sql", true);

			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				cmd.CommandText = sql;
				return cmd.ExecuteNonQuery();
			}
		}

		public int ExecuteNonQuery(string sql, SqlCommand cmd)
		{
			sql.ThrowExceptionIfNull("sql", true);
			cmd.ThrowExceptionIfNull("cmd");

			cmd.CommandText = sql;
			return cmd.ExecuteNonQuery();
		}

		public int[] ExecuteNonQuery(string[] sqls, bool requiresDatabaseToExist)
		{
			sqls.ThrowExceptionIfNull("sqls", true);

			int[] returnValue = new int[sqls.Length];
			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = cmd.ExecuteNonQuery();
				}
			}
			return returnValue;
		}

		public int[] ExecuteNonQuery(string[] sqls, SqlCommand cmd)
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

		public async Task<int> ExecuteNonQueryAsync(string sql, bool requiresDatabaseToExist)
		{
			sql.ThrowExceptionIfNull("sql", true);

			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				cmd.CommandText = sql;
				return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
			}
		}

		public async Task<int> ExecuteNonQueryAsync(string sql, SqlCommand cmd)
		{
			sql.ThrowExceptionIfNull("sql", true);
			cmd.ThrowExceptionIfNull("cmd");

			cmd.CommandText = sql;
			return await cmd.ExecuteNonQueryAsync();
		}

		public async Task<int[]> ExecuteNonQueryAsync(string[] sqls, bool requiresDatabaseToExist)
		{
			sqls.ThrowExceptionIfNull("sqls", true);

			int[] returnValue = new int[sqls.Length];
			using (SqlCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
			{
				for (int i = 0; i < sqls.Length; i++)
				{
					cmd.CommandText = sqls[i];
					returnValue[i] = await cmd.ExecuteNonQueryAsync();
				}
			}
			return returnValue;
		}

		public async Task<int[]> ExecuteNonQueryAsync(string[] sqls, SqlCommand cmd)
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
