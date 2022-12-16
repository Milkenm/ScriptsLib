using System.Data;
using System.Data.SqlClient;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2.Databases
{
	public partial class SqlServerDB
	{
		public DataTable ExecuteSQL(string sql)
		{
			sql.ThrowExceptionIfNull(nameof(sql), true);

			using (SqlDataAdapter da = new SqlDataAdapter(sql, GetDatabaseConnection<SqlConnection>()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}