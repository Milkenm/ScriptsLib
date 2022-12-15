using System.Threading.Tasks;

using ScriptsLibR.Extensions;

namespace ScriptsLibR.Databases
{
	public partial class SqlServerDB
	{
		public int Insert(string tableName, string[] columns, object[] values)
		{
			(string columnsString, object valuesObject) = InsertCode(tableName, columns, values);
			return ExecuteNonQuery(GetDatabaseConnection(), $"INSERT INTO {tableName} ({columnsString}) VALUES ({valuesObject})");
		}

		public async Task<int> InsertAsync(string tableName, string[] columns, object[] values)
		{
			(string ColumnsString, object ValuesObject) items = InsertCode(tableName, columns, values);
			return await ExecuteNonQueryAsync(GetDatabaseConnection(), $"INSERT INTO {tableName} ({items.ColumnsString}) VALUES ({items.ValuesObject})");
		}

		private (string columnsString, object valuesObject) InsertCode(string tableName, string[] columns, object[] values)
		{
			tableName.ThrowExceptionIfNull(nameof(tableName), true);
			columns.ThrowExceptionIfNull(nameof(columns), true);
			values.ThrowExceptionIfNull(nameof(values));

			string columnsString = string.Join<string>(", ", columns);
			object valuesObject = string.Join<object>(", ", values);
			return (columnsString, valuesObject);
		}
	}
}