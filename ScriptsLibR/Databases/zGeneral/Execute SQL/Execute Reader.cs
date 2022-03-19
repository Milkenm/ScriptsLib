using ScriptsLibR.Extensions;

using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.General
{
	public partial class General
	{
		public DataTable ExecuteReader(DbConnection con, string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}

			using (DbCommand cmd = con.CreateCommand())
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public DataTable ExecuteReader(DbCommand cmd, string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}
			if (cmd == null)
			{
				throw new ArgumentNullException("cmd");
			}

			using (DbDataReader dr = cmd.ExecuteReader())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}


		public DataTable ExecuteReader(DbConnection con, string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sqls");
			}

			using (DbCommand cmd = con.CreateCommand())
			using (DbDataReader dr = cmd.ExecuteReader())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public DataTable ExecuteReader(DbCommand cmd, string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sqls");
			}
			if (cmd == null)
			{
				throw new ArgumentNullException("cmd");
			}

			using (DbDataReader dr = cmd.ExecuteReader())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public async Task<DataTable> ExecuteReaderAsync(DbConnection con, string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}

			using (DbCommand cmd = con.CreateCommand())
			using (DbDataReader dr = await cmd.ExecuteReaderAsync())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public async Task<DataTable> ExecuteReaderAsync(DbCommand cmd, string sql)
		{
			if (sql.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}
			if (cmd == null)
			{
				throw new ArgumentNullException("cmd");
			}

			using (DbDataReader dr = await cmd.ExecuteReaderAsync())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}


		public async Task<DataTable> ExecuteReaderAsync(DbConnection con, string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sql");
			}

			using (DbCommand cmd = con.CreateCommand())
			using (DbDataReader dr = await cmd.ExecuteReaderAsync())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}

		public async Task<DataTable> ExecuteReaderAsync(DbCommand cmd, string[] sqls)
		{
			if (sqls.IsEmpty())
			{
				throw new ArgumentNullException("sqls");
			}
			if (cmd == null)
			{
				throw new ArgumentNullException("cmd");
			}

			using (DbDataReader dr = await cmd.ExecuteReaderAsync())
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				return dt;
			}
		}
	}
}
