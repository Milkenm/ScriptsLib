using ScriptsLibR.Databases.AccessDB;

using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ScriptsLibR.Interfaces
{
	public interface IDatabase
	{
		string ConnectionString { get; }

		void CloseConnection();
		int CreateTable(string tableName, params IDatabaseTableColumn[] fields);
		Task<int> CreateTableAsync(string tableName, params IDatabaseTableColumn[] fields);
		int Delete(string tableName, string condition);
		Task<int> DeleteAsync(string tableName, string condition);
		int DeleteTable(string tableName);
		Task<int> DeleteTableAsync(string tableName);
		int ExecuteNonQuery(string sql);
		int ExecuteNonQuery(string sql, OleDbCommand cmd);
		int[] ExecuteNonQuery(string[] sqls);
		int[] ExecuteNonQuery(string[] sqls, OleDbCommand cmd);
		Task<int> ExecuteNonQueryAsync(string sql);
		Task<int> ExecuteNonQueryAsync(string sql, OleDbCommand cmd);
		Task<int[]> ExecuteNonQueryAsync(string[] sqls);
		Task<int[]> ExecuteNonQueryAsync(string[] sqls, OleDbCommand cmd);
		DataTable ExecuteReader(string sql);
		DataTable ExecuteReader(string sql, OleDbCommand cmd);
		DataTable ExecuteReader(string[] sqls);
		DataTable ExecuteReader(string[] sqls, OleDbCommand cmd);
		Task<DataTable> ExecuteReaderAsync(string sql);
		Task<DataTable> ExecuteReaderAsync(string sql, OleDbCommand cmd);
		Task<DataTable> ExecuteReaderAsync(string[] sqls);
		Task<DataTable> ExecuteReaderAsync(string[] sqls, OleDbCommand cmd);
		object ExecuteScalar(string sql);
		object ExecuteScalar(string sql, OleDbCommand cmd);
		object[] ExecuteScalar(string[] sqls);
		object[] ExecuteScalar(string[] sqls, OleDbCommand cmd);
		Task<object> ExecuteScalarAsync(OleDbCommand cmd, string sql);
		Task<object> ExecuteScalarAsync(string sql);
		Task<object[]> ExecuteScalarAsync(string[] sqls);
		Task<object[]> ExecuteScalarAsync(string[] sqls, OleDbCommand cmd);
		DataTable ExecuteSQL(string sql, bool requiresDatabaseToExist);
		int Insert(string tableName, string[] columns, object[] values);
		Task<int> InsertAsync(string tableName, string[] columns, object[] values);
		DataTable Select(string tableName, string selection = "*", string condition = null);
		int Update(string table, string update, string condition);
		Task<int> UpdateAsync(string table, string update, string condition);
	}
}