using System.Data;

using MySql.Data.MySqlClient;

using ScriptsLibV2.Extensions;

namespace ScriptsLibV2.Databases
{
	public partial class MySqlDB : DatabaseRunner, IDatabase
	{
		public DataTable ExecuteSQL(string sql)
		{
			sql.ThrowExceptionIfNull(nameof(sql), true);

			using (MySqlDataAdapter da = new MySqlDataAdapter(sql, GetDatabaseConnection<MySqlConnection>()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}
