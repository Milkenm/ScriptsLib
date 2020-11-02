using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

namespace ScriptsLib.Databases
{
	public class SqlServerDB
	{
		public SqlServerDB(string databasePath)
		{
			DatabasePath = databasePath;
		}

		public SqlServerDB(string databasePath, string baseConnection)
		{
			DatabasePath = databasePath;
			BaseConnection = baseConnection;
		}

		/// <summary>The provider and stuff to connect to the database.</summary>
		internal string BaseConnection { get; } = @"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=";

		/// <summary>The path where the .MDF database file is located.</summary>
		public string DatabasePath { get; }

		/// <summary>Creates a database file in the given path.</summary>
		/// <param name="filePath">The path (including the file name and extension) where the database will be created.</param>
		public async Task CreateDatabaseAsync(string filePath)
		{
			if (!File.Exists(filePath))
			{
				string dbName = Path.GetFileNameWithoutExtension(filePath);

				using (SqlConnection con = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true"))
				{
					using (SqlCommand cmd = con.CreateCommand())
					{
						cmd.CommandText = $"CREATE DATABASE {dbName} ON PRIMARY (NAME={dbName}, FILENAME='{filePath}')";
						await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
					}
				}
			}
			else
			{
				throw new Exception("Database file already exists.");
			}
		}

		public async Task CreateTableAsync(string tableName, List<SqlServerTableFields> fields)
		{
			List<string> columns = new List<string>();
			foreach (SqlServerTableFields field in fields)
			{
				string dataType = field.DataType switch
				{
					SqlServerDataTypes.Text => "ntext",
					SqlServerDataTypes.Number => "bigint",
					SqlServerDataTypes.Image => "image",
					SqlServerDataTypes.Money => "money",
					SqlServerDataTypes.Decimal => "decimal(38,38)",
					SqlServerDataTypes.DateAndTime => "datetime2",
					SqlServerDataTypes.Date => "date",
					SqlServerDataTypes.Time => "time",
					_ => throw new Exception("Invalid Field DataType."),
				};

				columns.Add($"{field.Name} {dataType}");
			}

			string columnsString = string.Join(", ", columns.ToArray());

			using (SqlConnection con = new SqlConnection(BaseConnection + DatabasePath))
			{
				using (SqlCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"CREATE TABLE {tableName} ({columnsString})";
					await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
				}
			}
		}

		public struct SqlServerTableFields
		{
			public string Name;
			public SqlServerDataTypes DataType;
			public bool PrimaryKey;
			public bool AutoIncrement;
		}

		public enum SqlServerDataTypes
		{
			Text,
			Number,
			Image,
			Money,
			Decimal,
			DateAndTime,
			Date,
			Time,
		}

		public async Task<int> DeleteAsync(string _Table, string _Condition)
		{
			using (SqlConnection con = new SqlConnection(BaseConnection + DatabasePath))
			{
				using (SqlCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"DELETE FROM {_Table} WHERE {_Condition}";
					return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
				}
			}
		}

		public async Task DeleteTableAsync(string tableName)
		{
			using (SqlConnection con = new SqlConnection(BaseConnection + DatabasePath))
			{
				using (SqlCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"DROP TABLE {tableName}";
					await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
				}
			}
		}

		public async Task<int> InsertIntoAsync(string tableName, string[] columns, object[] values)
		{
			string columnsString = string.Join<string>(", ", columns);
			object valuesObejct = string.Join<object>(", ", values);

			using (SqlConnection con = new SqlConnection(BaseConnection + DatabasePath))
			{
				using (SqlCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"INSERT INTO {tableName} ({columnsString}) VALUES ({valuesObejct})";
					return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
				}
			}
		}

		public DataTable Select(string table, string selection = "*", string condition = null)
		{
			using (SqlConnection con = new SqlConnection(BaseConnection + DatabasePath))
			{
				using (SqlCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"SELECT {selection} FROM {table}" + (!string.IsNullOrEmpty(condition) ? $" WHERE {condition}" : null);

					using (SqlDataAdapter da = new SqlDataAdapter(cmd))
					{
						DataTable dt = new DataTable();
						da.Fill(dt);
						return dt;
					}
				}
			}
		}

		public async Task<int> UpdateAsync(string table, string update, string condition)
		{
			using (SqlConnection con = new SqlConnection(BaseConnection + DatabasePath))
			{
				using (SqlCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"UPDATE {table} SET {update} WHERE {condition}";
					return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
				}
			}
		}
	}
}