using ScriptsLibR.Extensions;

using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace ScriptsLibR.Utils.Database
{
	public static partial class DatabaseUtils
	{
		public static DataTable ExecuteReader(DbConnection con, string sql)
		{
			Utils.NullChecker(true, (con, nameof(con)), (sql, nameof(sql)));

			using (DbCommand cmd = con.CreateCommand())
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public static DataTable ExecuteReader(DbCommand cmd, string sql)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)), (sql, nameof(sql)));

			using (DbDataReader dr = cmd.ExecuteReader())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}


		public static DataTable ExecuteReader(DbConnection con, string[] sqls)
		{
			Utils.NullChecker(true, (con, nameof(con)), (sqls, nameof(sqls)));

			using (DbCommand cmd = con.CreateCommand())
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public static DataTable ExecuteReader(DbCommand cmd, string[] sqls)
		{
			Utils.NullChecker(true, (cmd, nameof(cmd)), (sqls, nameof(sqls)));

			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException(nameof(sqls));
			}
			if (cmd == null)
			{
				throw new ArgumentNullException(nameof(cmd));
			}

			using (DbDataReader dr = cmd.ExecuteReader())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public static async Task<DataTable> ExecuteReaderAsync(DbConnection con, string sql)
		{
			await Utils.NullCheckerAsync(true, (con, nameof(con)), (sql, nameof(sql)));

			using (DbCommand cmd = con.CreateCommand())
			using (DbDataReader dr = await cmd.ExecuteReaderAsync())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public static async Task<DataTable> ExecuteReaderAsync(DbCommand cmd, string sql)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)), (sql, nameof(sql)));

			using (DbDataReader dr = await cmd.ExecuteReaderAsync())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}


		public static async Task<DataTable> ExecuteReaderAsync(DbConnection con, string[] sqls)
		{
			await Utils.NullCheckerAsync(true, (con, nameof(con)), (sqls, nameof(sqls)));

			using (DbCommand cmd = con.CreateCommand())
			using (DbDataReader dr = await cmd.ExecuteReaderAsync())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public static async Task<DataTable> ExecuteReaderAsync(DbCommand cmd, string[] sqls)
		{
			await Utils.NullCheckerAsync(true, (cmd, nameof(cmd)), (sqls, nameof(sqls)));

			using (DbDataReader dr = await cmd.ExecuteReaderAsync())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}
	}
}
