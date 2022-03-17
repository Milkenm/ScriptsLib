using System.Data.OleDb;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB
{
    public partial class AccessDB
    {
        public int ExecuteNonQuery(string sql, bool requiresDatabaseToExist)
        {
            using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
            {
                cmd.CommandText = sql;
                return cmd.ExecuteNonQuery();
            }
        }

        public int ExecuteNonQuery(string sql, OleDbCommand cmd)
        {
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public int[] ExecuteNonQuery(string[] sqls, bool requiresDatabaseToExist)
        {
            int[] returnValue = new int[sqls.Length];
            using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
            {
                for (int i = 0; i < sqls.Length; i++)
                {
                    cmd.CommandText = sqls[i];
                    returnValue[i] = cmd.ExecuteNonQuery();
                }
            }
            return returnValue;
        }

        public int[] ExecuteNonQuery(string[] sqls, OleDbCommand cmd)
        {
            int[] returnValue = new int[sqls.Length];
            for (int i = 0; i < sqls.Length; i++)
            {
                cmd.CommandText = sqls[i];
                returnValue[i] = cmd.ExecuteNonQuery();
            }
            return returnValue;
        }

        public async Task<int> ExecuteNonQueryAsync(string sql, bool requiresDatabaseToExist)
        {
            using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
            {
                cmd.CommandText = sql;
                return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
            }
        }

        public async Task<int> ExecuteNonQueryAsync(string sql, OleDbCommand cmd,)
        {
            cmd.CommandText = sql;
            return await cmd.ExecuteNonQueryAsync();
        }

        public async Task<int[]> ExecuteNonQueryAsync(string[] sqls, bool requiresDatabaseToExist)
        {
            int[] returnValue = new int[sqls.Length];
            using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
            {
                for (int i = 0; i < sqls.Length; i++)
                {
                    cmd.CommandText = sqls[i];
                    returnValue[i] = await cmd.ExecuteNonQueryAsync();
                }
            }
            return returnValue;
        }

        public async Task<int[]> ExecuteNonQueryAsync(string[] sqls, OleDbCommand cmd)
        {
            int[] returnValue = new int[sqls.Length];
            for (int i = 0; i < sqls.Length; i++)
            {
                cmd.CommandText = sqls[i];
                returnValue[i] = await cmd.ExecuteNonQueryAsync();
            }
            return returnValue;
        }
    }
}
