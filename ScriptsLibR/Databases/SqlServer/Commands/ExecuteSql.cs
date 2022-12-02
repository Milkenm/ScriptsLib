using ScriptsLibR.Extensions;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ScriptsLibR.Databases.SqlServer
{
	public partial class SqlServerDB
	{
		public DataTable ExecuteSQL(string sql, bool requiresDatabaseToExist)
		{
			sql.ThrowExceptionIfNull("sql", true);

			using (SqlDataAdapter da = new SqlDataAdapter(sql, this.GetDbConnection(requiresDatabaseToExist)))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}
