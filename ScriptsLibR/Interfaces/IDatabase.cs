using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ScriptsLibR.Interfaces
{
	public interface IDatabase
	{
		public string ConnectionString { get; }

		public void CloseConnection();
		public int Delete(string tableName, string condition);
		public Task<int> DeleteAsync(string tableName, string condition);
		public int DeleteTable(string tableName);
		public Task<int> DeleteTableAsync(string tableName);
		public int ExecuteNonQuery(string sql);
		public int ExecuteNonQuery(string sql, OleDbCommand cmd);
		public int[] ExecuteNonQuery(string[] sqls);
		public int[] ExecuteNonQuery(string[] sqls, OleDbCommand cmd);
		public Task<int> ExecuteNonQueryAsync(string sql);
		public Task<int> ExecuteNonQueryAsync(string sql, OleDbCommand cmd);
		public Task<int[]> ExecuteNonQueryAsync(string[] sqls);
		public Task<int[]> ExecuteNonQueryAsync(string[] sqls, OleDbCommand cmd);
		public DataTable ExecuteReader(string sql);
		public DataTable ExecuteReader(string sql, OleDbCommand cmd);
		public DataTable ExecuteReader(string[] sqls);
		public DataTable ExecuteReader(string[] sqls, OleDbCommand cmd);
		public Task<DataTable> ExecuteReaderAsync(string sql);
		public Task<DataTable> ExecuteReaderAsync(string sql, OleDbCommand cmd);
		public Task<DataTable> ExecuteReaderAsync(string[] sqls);
		public Task<DataTable> ExecuteReaderAsync(string[] sqls, OleDbCommand cmd);
		public object ExecuteScalar(string sql);
		public object ExecuteScalar(string sql, OleDbCommand cmd);
		public object[] ExecuteScalar(string[] sqls);
		public object[] ExecuteScalar(string[] sqls, OleDbCommand cmd);
		public Task<object> ExecuteScalarAsync(OleDbCommand cmd, string sql);
		public Task<object> ExecuteScalarAsync(string sql);
		public Task<object[]> ExecuteScalarAsync(string[] sqls);
		public Task<object[]> ExecuteScalarAsync(string[] sqls, OleDbCommand cmd);
		public DataTable ExecuteSQL(string sql, bool requiresDatabaseToExist);
		public int Insert(string tableName, string[] columns, object[] values);
		public Task<int> InsertAsync(string tableName, string[] columns, object[] values);
		public DataTable Select(string tableName, string selection = "*", string condition = null);
		public int Update(string table, string update, string condition);
		public Task<int> UpdateAsync(string table, string update, string condition);
	}
}