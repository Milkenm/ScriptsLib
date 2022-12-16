using System.Data;
using System.Data.SqlClient;

namespace ScriptsLibV2.Databases
{
	public partial class SqlServerDB
	{
		public DataTable Select(string tableName, string selection = "*", string condition = null)
		{
			string sql = $"SELECT {selection} FROM [{tableName}]" + (condition != null ? " WHERE {condition}" : null);

			using (SqlDataAdapter da = new SqlDataAdapter(sql, GetDatabaseConnection<SqlConnection>()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}