using System.Data;

using MySql.Data.MySqlClient;

namespace ScriptsLibV2.Databases
{
	public partial class MySqlDB : DatabaseRunner, IDatabase
	{
		public DataTable Select(string tableName, string selection = "*", string condition = null)
		{
			string sql = $"SELECT {selection} FROM [{tableName}]" + (condition != null ? " WHERE {condition}" : null);

			using (MySqlDataAdapter da = new MySqlDataAdapter(sql, GetDatabaseConnection<MySqlConnection>()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}
