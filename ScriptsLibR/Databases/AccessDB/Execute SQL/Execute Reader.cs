using System.Data.Common;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB
{
    public partial class AccessDB
    {
        public OleDbDataReader ExecuteReader(string sql, bool requiresDatabaseToExist)
        {
            using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
            {
                cmd.CommandText = sql;
                return cmd.ExecuteReader();
            }
        }

        public OleDbDataReader ExecuteReader(string sql, OleDbCommand cmd)
        {
            cmd.CommandText = sql;
            return cmd.ExecuteReader();
        }


        public OleDbDataReader[] ExecuteReader(string[] sqls, bool requiresDatabaseToExist)
        {
            OleDbDataReader[] returnValue = new OleDbDataReader[sqls.Length];
            using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
            {
                for (int i = 0; i < sqls.Length; i++)
                {
                    cmd.CommandText = sqls[i];
                    returnValue[i] = cmd.ExecuteReader();
                }
            }
            return returnValue;
        }

        public OleDbDataReader[] ExecuteReader(string[] sqls, OleDbCommand cmd)
        {
            OleDbDataReader[] returnValue = new OleDbDataReader[sqls.Length];
            for (int i = 0; i < sqls.Length; i++)
            {
                cmd.CommandText = sqls[i];
                returnValue[i] = cmd.ExecuteReader();
            }
            return returnValue;
        }

        public async Task<DbDataReader> ExecuteReaderAsync(string sql, bool requiresDatabaseToExist)
        {
            using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
            {
                cmd.CommandText = sql;
                return await cmd.ExecuteReaderAsync();
            }
        }

        public async Task<DbDataReader> ExecuteReaderAsync(string sql, OleDbCommand cmd)
        {
            cmd.CommandText = sql;
            return await cmd.ExecuteReaderAsync();
        }


        public async Task<DbDataReader[]> ExecuteReaderAsync(string[] sqls, bool requiresDatabaseToExist)
        {
            DbDataReader[] returnValue = new DbDataReader[sqls.Length];
            using (OleDbCommand cmd = this.GetDbConnection(requiresDatabaseToExist).CreateCommand())
            {
                for (int i = 0; i < sqls.Length; i++)
                {
                    cmd.CommandText = sqls[i];
                    returnValue[i] = await cmd.ExecuteReaderAsync();
                }
            }
            return returnValue;
        }

        public async Task<DbDataReader[]> ExecuteReaderAsync(string[] sqls, OleDbCommand cmd)
        {
            DbDataReader[] returnValue = new DbDataReader[sqls.Length];
            for (int i = 0; i < sqls.Length; i++)
            {
                cmd.CommandText = sqls[i];
                returnValue[i] = await cmd.ExecuteReaderAsync();
            }
            return returnValue;
        }
    }
}
