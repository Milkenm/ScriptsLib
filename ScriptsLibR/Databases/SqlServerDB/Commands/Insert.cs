using ScriptsLibR.Extensions;

using System.Threading.Tasks;

namespace ScriptsLibR.Databases.SqlServerDB
{
	public partial class SqlServerDB
	{
		public int Insert(string tableName, string[] columns, object[] values)
		{
			(string columnsString, object valuesObject) = this.InsertCode(tableName, columns, values);
			return this.ExecuteNonQuery($"INSERT INTO {tableName} ({columnsString}) VALUES ({valuesObject})", true);
		}

		public async Task<int> InsertAsync(string tableName, string[] columns, object[] values)
		{
			(string ColumnsString, object ValuesObject) items = this.InsertCode(tableName, columns, values);
			return await this.ExecuteNonQueryAsync($"INSERT INTO {tableName} ({items.ColumnsString}) VALUES ({items.ValuesObject})", true);
		}

		private (string columnsString, object valuesObject) InsertCode(string tableName, string[] columns, object[] values)
		{
			tableName.ThrowArgumentNullExceptionIfNull("tableName", true);
			columns.ThrowArgumentNullExceptionIfNull("columns", true);
			values.ThrowArgumentNullExceptionIfNull("values");

			string columnsString = string.Join<string>(", ", columns);
			object valuesObject = string.Join<object>(", ", values);
			return (columnsString, valuesObject);
		}
	}
}
