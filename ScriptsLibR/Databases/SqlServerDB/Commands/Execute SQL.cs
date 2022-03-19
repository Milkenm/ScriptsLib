using ScriptsLibR.Extensions;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ScriptsLibR.Databases.SqlServerDB
{
	public partial class SqlServerDB
	{
		public DataTable ExecuteSQL(string sql, bool requiresDatabaseToExist)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);

			using (SqlDataAdapter da = new SqlDataAdapter(sql, this.GetDbConnection(requiresDatabaseToExist)))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}
