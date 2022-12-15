using System.Data;
using System.Data.OleDb;

namespace ScriptsLibR.Databases
{
	public partial class AccessDB : DatabaseRunner, IDatabase
	{
		public DataTable Select(string tableName, string selection = "*", string condition = null)
		{
			string sql = $"SELECT {selection} FROM [{tableName}]" + (condition != null ? " WHERE {condition}" : null);

			using (OleDbDataAdapter da = new OleDbDataAdapter(sql, GetDatabaseConnection<OleDbConnection>()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}
