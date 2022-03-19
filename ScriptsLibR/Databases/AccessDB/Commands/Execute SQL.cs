﻿using ScriptsLibR.Extensions;

using System.Data;
using System.Data.OleDb;

namespace ScriptsLibR.Databases.AccessDB
{
	public partial class AccessDB
	{
		public DataTable ExecuteSQL(string sql, bool requiresDatabaseToExist)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);

			using (OleDbDataAdapter da = new OleDbDataAdapter(sql, this.GetDbConnection(requiresDatabaseToExist)))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}