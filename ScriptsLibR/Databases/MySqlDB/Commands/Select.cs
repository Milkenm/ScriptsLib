using MySql.Data.MySqlClient;

using System.Data;

namespace ScriptsLibR.Databases.MySqlDB
{
	public partial class MySqlDB
	{
		public DataTable Select(string tableName, string selection = "*", string condition = null)
		{
			string sql = $"SELECT {selection} FROM [{tableName}]" + (condition != null ? " WHERE {condition}" : null);

			using (MySqlDataAdapter da = new MySqlDataAdapter(sql, this.GetDbConnection()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}
