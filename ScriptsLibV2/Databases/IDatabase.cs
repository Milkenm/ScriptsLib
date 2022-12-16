using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace ScriptsLibV2.Databases
{
	public interface IDatabase
	{
		public void OpenConnection();

		public void CloseConnection();

		public DbConnection GetDatabaseConnection();

		public int Delete(string tableName, string condition);

		public Task<int> DeleteAsync(string tableName, string condition);

		public int DeleteTable(string tableName);

		public Task<int> DeleteTableAsync(string tableName);

		// ==================================================================== \\

		public int ExecuteNonQuery(DbConnection con, string sql);

		public int ExecuteNonQuery(DbCommand cmd, string sql);

		public int ExecuteNonQuery(DbCommand cmd);

		// ==================================================================== \\

		public int[] ExecuteNonQuery(DbConnection con, params string[] sqls);

		public int[] ExecuteNonQuery(DbCommand cmd, params string[] sqls);

		public int[] ExecuteNonQuery(DbCommand[] cmds);

		// ==================================================================== \\

		public Task<int> ExecuteNonQueryAsync(DbConnection con, string sql);

		public Task<int> ExecuteNonQueryAsync(DbCommand cmd, string sql);

		public Task<int> ExecuteNonQueryAsync(DbCommand cmd);

		// ==================================================================== \\

		public Task<int[]> ExecuteNonQueryAsync(DbConnection con, params string[] sqls);

		public Task<int[]> ExecuteNonQueryAsync(DbCommand cmd, params string[] sqls);

		public Task<int[]> ExecuteNonQueryAsync(DbCommand[] cmds);

		// ==================================================================== \\

		public DataTable ExecuteReader(DbConnection con, string sql);

		public DataTable ExecuteReader(DbCommand cmd, string sql);

		public DataTable ExecuteReader(DbCommand cmd);

		// ==================================================================== \\

		public DataTable[] ExecuteReader(DbConnection con, params string[] sqls);

		public DataTable[] ExecuteReader(DbCommand cmd, params string[] sqls);

		public DataTable[] ExecuteReader(DbCommand[] cmds);

		// ==================================================================== \\

		public Task<DataTable> ExecuteReaderAsync(DbConnection con, string sql);

		public Task<DataTable> ExecuteReaderAsync(DbCommand cmd, string sql);

		public Task<DataTable> ExecuteReaderAsync(DbCommand cmd);

		// ==================================================================== \\

		public Task<DataTable[]> ExecuteReaderAsync(DbConnection con, params string[] sqls);

		public Task<DataTable[]> ExecuteReaderAsync(DbCommand cmd, params string[] sqls);

		public Task<DataTable[]> ExecuteReaderAsync(DbCommand[] cmds);

		// ==================================================================== \\

#nullable enable
		public object? ExecuteScalar(DbConnection con, string sql);

		public object? ExecuteScalar(DbCommand cmd, string sql);

		public object? ExecuteScalar(DbCommand cmd);

		// ==================================================================== \\

		public object?[] ExecuteScalar(DbConnection con, params string[] sqls);

		public object?[] ExecuteScalar(DbCommand cmd, params string[] sqls);

		public object?[] ExecuteScalar(DbCommand[] cmds);

		// ==================================================================== \\

		public Task<object?> ExecuteScalarAsync(DbConnection con, string sql);

		public Task<object?> ExecuteScalarAsync(DbCommand cmd, string sql);

		public Task<object?> ExecuteScalarAsync(DbCommand cmd);

		// ==================================================================== \\

		public Task<object?[]> ExecuteScalarAsync(DbConnection con, params string[] sqls);

		public Task<object?[]> ExecuteScalarAsync(DbCommand cmd, params string[] sqls);

		public Task<object?[]> ExecuteScalarAsync(DbCommand[] cmds);
#nullable disable

		// ==================================================================== \\

		public int Insert(string tableName, string[] columns, object[] values);

		public Task<int> InsertAsync(string tableName, string[] columns, object[] values);

		public DataTable Select(string tableName, string selection = "*", string condition = null);

		public int Update(string table, string update, string condition);

		public Task<int> UpdateAsync(string table, string update, string condition);
	}
}