﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Threading.Tasks;

namespace ScriptsLib.Databases
{
	public class AccessDB
	{
		public AccessDB(string databasePath)
		{
			DatabasePath = databasePath;
		}

		public AccessDB(string databasePath, string baseConnection)
		{
			DatabasePath = databasePath;
			BaseConnection = baseConnection;
		}

		/// <summary>The provider and stuff to connect to the database.</summary>
		public string BaseConnection { get; private set; } = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
		/// <summary>The path where the .MDB database file is located.</summary>
		public string DatabasePath { get; private set; }

		/// <summary>Creates a database file in the given path.</summary>
		/// <param name="filepath">The path (including the file name and extension) where the database will be created.</param>
		public async Task CreateDatabaseAsync(string filepath)
		{
			if (!File.Exists(filepath))
			{
				string dbName = Path.GetFileNameWithoutExtension(filepath);

				using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;"))
				{
					using (OleDbCommand cmd = con.CreateCommand())
					{
						cmd.CommandText = $"CREATE DATABASE {dbName} ON PRIMARY (NAME={dbName}, FILENAME='{filepath}')";
						await cmd.ExecuteNonQueryAsync();

						cmd.CommandText = $"EXEC sp_detach_db '{dbName}', 'true'";
						await cmd.ExecuteNonQueryAsync();
					}
				}
			}
			else
			{
				throw new Exception("Database file already exists.");
			}
		}

		public async Task CreateTableAsync(string tableName, List<AccessTableFields> fields)
		{
			List<string> columns = new List<string>();
			foreach (AccessTableFields field in fields)
			{
				string dataType = field.DataType switch
				{
					AccessDataTypes.Text => "text",
					AccessDataTypes.Number => "long",
					AccessDataTypes.Currency => "currency",
					AccessDataTypes.Decimal => "double",
					AccessDataTypes.DateTime => "date/time",
					AccessDataTypes.PrimaryKey => "key",
					_ => throw new Exception("Invalid Field DataType."),
				};

				if (field.DataType == AccessDataTypes.PrimaryKey)
				{
					columns.Add($"[{field.Name}] AUTOINCREMENT PRIMARY KEY");
				}
				else
				{
					columns.Add($"[{field.Name}] {dataType}");
				}
			}
			string columnsString = string.Join(", ", columns.ToArray());

			using (OleDbConnection con = new OleDbConnection(BaseConnection + DatabasePath))
			{
				using (OleDbCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"CREATE TABLE {tableName} ({columnsString})";
					await cmd.ExecuteNonQueryAsync();
				}
			}
		}

		public struct AccessTableFields
		{
			public string Name;
			public AccessDataTypes DataType;
			public bool PrimaryKey;
			public bool AutoIncrement;
		}

		public enum AccessDataTypes
		{
			PrimaryKey,
			Text,
			Number,
			Currency,
			Decimal,
			DateTime,
		}

		/// <summary>Deletes a value from the database.</summary>
		/// <param name="tableName">The table from where to delete the value.</param>
		/// <param name="condition">The condition to delete the value.</param>
		public async Task DeleteAsync(string tableName, string condition)
		{
			using (OleDbConnection con = new OleDbConnection(BaseConnection + DatabasePath))
			{
				using (OleDbCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"DELETE FROM {tableName} WHERE {condition}";
					await cmd.ExecuteNonQueryAsync();
				}
			}
		}

		public async Task DeleteTableAsync(string tableName)
		{
			using (OleDbConnection con = new OleDbConnection(BaseConnection + DatabasePath))
			{
				using (OleDbCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"DROP TABLE {tableName}";
					await cmd.ExecuteNonQueryAsync();
				}
			}
		}

		public async Task InsertInto(string tableName, string[] columns, string values)
		{
			string columnsString = string.Join<string>(", ", columns);

			using (OleDbConnection con = new OleDbConnection(BaseConnection + DatabasePath))
			{
				using (OleDbCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"INSERT INTO {tableName} ({columnsString}) VALUES ({values})";
					await cmd.ExecuteNonQueryAsync();
				}
			}
		}

		public DataTable Select(string tableName, string selection = "*", string condition = null)
		{
			using (OleDbConnection con = new OleDbConnection(BaseConnection + DatabasePath))
			{
				using (OleDbCommand cmd = con.CreateCommand())
				{
					if (!string.IsNullOrEmpty(condition))
					{
						cmd.CommandText = $"SELECT {selection} FROM [{tableName}] WHERE {condition}";
					}
					else
					{
						cmd.CommandText = $"SELECT {selection} FROM [{tableName}]";
					}

					using (OleDbDataAdapter da = new OleDbDataAdapter(cmd.CommandText, con))
					{
						DataTable dt = new DataTable();
						da.Fill(dt);
						return dt;
					}
				}
			}
		}

		public async Task Update(string _Table, string _Update, string _Condition)
		{
			using (OleDbConnection con = new OleDbConnection(BaseConnection + DatabasePath))
			{
				using (OleDbCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"UPDATE [{_Table}] SET {_Update} WHERE {_Condition}";
					await cmd.ExecuteNonQueryAsync();
				}
			}
		}

		public DataTable ExecuteSQL(string sql)
		{
			using (OleDbConnection con = new OleDbConnection($"Data Source={DatabasePath}; Version=3;"))
			{
				using (OleDbCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = sql;

					using (OleDbDataAdapter da = new OleDbDataAdapter(cmd.CommandText, con))
					{
						DataTable dt = new DataTable();
						da.Fill(dt);
						return dt;
					}
				}
			}
		}
	}
}
