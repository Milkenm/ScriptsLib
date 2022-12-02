﻿using ScriptsLibR.Extensions;

using System;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		public int DeleteTable(string tableName)
		{
			this.DeleteTableCode(tableName);
			return this.ExecuteNonQuery($"DROP TABLE {tableName}");
		}

		public async Task<int> DeleteTableAsync(string tableName)
		{
			this.DeleteTableCode(tableName);
			return await this.ExecuteNonQueryAsync($"DROP TABLE {tableName}");
		}

		private void DeleteTableCode(string tableName)
		{
			tableName.ThrowExceptionIfNull("tableName", true);
		}
	}
}
