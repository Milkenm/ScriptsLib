using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ScriptsLib.Databases
{
	public class MySqlDB
	{
		public MySqlDB(string server, short port, string database, string user, string password, string sslMode)
		{
			Server = server;
			Port = port;
			Database = database;
			User = user;
			Password = password;
			SslMode = sslMode;
		}

		public MySqlDB(string server, short port, string database, string user, string password, string sslMode, string baseConnection)
		{
			Server = server;
			Port = port;
			Database = database;
			User = user;
			Password = password;
			SslMode = sslMode;

			BaseConnection = baseConnection;
		}

		/// <summary>The base connection to connect to the MySql database server.</summary>
		public static string BaseConnection { get; private set; } = @"Server={0}; Port={1}; User ID={2}; Password={3}; Database={4}; SslMode={5}";
		/// <summary>The server IP/domain.</summary>
		public static string Server { get; private set; }
		/// <summary>The server port.</summary>
		public static int Port { get; private set; }
		/// <summary>The server database name.</summary>
		public static string Database { get; private set; }
		/// <summary>User required to login into the MySql database.</summary>
		public static string User { get; private set; }
		/// <summary>Password for the given user used to connect to the MySql database.</summary>
		public static string Password { get; private set; }
		public static string SslMode { get; private set; }

		public struct MySqlTableFields
		{
			public string Name;
			public MySqlDataTypes DataType;
			public bool PrimaryKey;
			public bool AutoIncrement;
		}

		public enum MySqlDataTypes
		{
			Key,
			Text,
			Number,
			Money,
			Decimal,
			DateAndTime,
			Boolean,
			Timestamp,
			Year,
		}

		private string GetConnectionString()
		{
			return string.Format(BaseConnection, Server, Port, User, Password, Database, SslMode);
		}

		public async Task CreateTableAsync(string tableName, List<MySqlTableFields> fields)
		{
			List<string> columns = new List<string>();
			foreach (MySqlTableFields field in fields)
			{
				string dataType = field.DataType switch
				{
					MySqlDataTypes.Text => "longtext",
					MySqlDataTypes.Number => "bigint",
					MySqlDataTypes.Money => "currency",
					MySqlDataTypes.Decimal => "double",
					MySqlDataTypes.DateAndTime => "datetime",
					MySqlDataTypes.Key => "key",
					MySqlDataTypes.Boolean => "boolean",
					MySqlDataTypes.Timestamp => "timestamp",
					MySqlDataTypes.Year => "year",
					_ => throw new Exception("Invalid Field DataType."),
				};

				if (dataType == "key")
				{
					columns.Add($"{field.Name} INT NOT NULL AUTO_INCREMENT, PRIMARY KEY ({field.Name})");
				}
				else
				{
					columns.Add($"{field.Name} {dataType}");
				}
			}

			using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
			{
				using (MySqlCommand cmd = con.CreateCommand())
				{
					string columnsString = string.Join(", ", columns.ToArray());
					cmd.CommandText = $"CREATE TABLE {tableName} ({columns})";
					await cmd.ExecuteNonQueryAsync();
				}
			}
		}

		public async Task<int> DeleteTableAsync(string tableName)
		{
			using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
			{
				using (MySqlCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = $"DROP TABLE {tableName}";
					return await cmd.ExecuteNonQueryAsync();
				}
			}
		}

		public DataTable ExecuteSQL(string sql)
		{
			using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
			{
				using (MySqlCommand cmd = con.CreateCommand())
				{
					cmd.CommandText = sql;

					using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
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
