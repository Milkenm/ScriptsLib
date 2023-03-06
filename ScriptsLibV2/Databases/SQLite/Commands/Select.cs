using System.Data;
using System.Data.SQLite;

namespace ScriptsLibV2.Databases
{
	public partial class SQLiteDB
	{
		public DataTable Select(string tableName, string selection = "*", string condition = null)
		{
			string sql = $"SELECT {selection} FROM {tableName} {(condition != null ? $" WHERE {condition}" : null)}";

			using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, GetDatabaseConnection<SQLiteConnection>()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}