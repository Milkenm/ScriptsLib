using MySql.Data.MySqlClient;

using ScriptsLibR.Extensions;

using System.Data;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		public DataTable ExecuteSQL(string sql)
		{
			sql.ThrowExceptionIfNull("sql", true);

			using (MySqlDataAdapter da = new MySqlDataAdapter(sql, this.GetDbConnection()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}
