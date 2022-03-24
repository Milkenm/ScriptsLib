using ScriptsLibR.Interfaces;

using System.Data;
using System.Data.OleDb;

namespace ScriptsLibR.Databases.AccessDB
{
    public partial class AccessDB 
    {
        public DataTable Select(string tableName, string selection = "*", string condition = null)
        {
            string sql = $"SELECT {selection} FROM [{tableName}]" + (condition != null ? " WHERE {condition}" : null);

            using (OleDbDataAdapter da = new OleDbDataAdapter(sql, this.GetDbConnection()))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
