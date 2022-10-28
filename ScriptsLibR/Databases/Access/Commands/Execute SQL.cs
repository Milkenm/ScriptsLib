using ScriptsLibR.Extensions;
using ScriptsLibR.Interfaces;

using System.Data;
using System.Data.OleDb;

namespace ScriptsLibR.Databases
{
	public partial class AccessDB 
	{
		public DataTable ExecuteSQL(string sql, bool requiresDatabaseToExist)
		{
			sql.ThrowArgumentNullExceptionIfNull("sql", true);

			using (OleDbDataAdapter da = new OleDbDataAdapter(sql, this.GetDbConnection()))
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}
