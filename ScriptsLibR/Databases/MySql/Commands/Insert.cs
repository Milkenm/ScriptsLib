using ScriptsLibR.Extensions;

using System.Threading.Tasks;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		public int Insert(string tableName, string[] columns, object[] values)
		{
			(string columnsString, object valuesObject) = this.InsertCode(tableName, columns, values);
			return this.ExecuteNonQuery($"INSERT INTO {tableName} ({columnsString}) VALUES ({valuesObject})");
		}

		public async Task<int> InsertAsync(string tableName, string[] columns, object[] values)
		{
			(string ColumnsString, object ValuesObject) items = this.InsertCode(tableName, columns, values);
			return await this.ExecuteNonQueryAsync($"INSERT INTO {tableName} ({items.ColumnsString}) VALUES ({items.ValuesObject})");
		}

		private (string ColumnsString, object ValuesObject) InsertCode(string tableName, string[] columns, object[] values)
		{
			tableName.ThrowExceptionIfNull("tableName", true);
			columns.ThrowExceptionIfNull("columns", true);
			values.ThrowExceptionIfNull("values");

			string columnsString = string.Join<string>(", ", columns);
			object valuesObject = string.Join<object>(", ", values);
			return (columnsString, valuesObject);
		}
	}
}
