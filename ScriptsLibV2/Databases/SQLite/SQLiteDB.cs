using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

using ScriptsLibV2.Exceptions;
using ScriptsLibV2.Util;

namespace ScriptsLibV2.Databases
{
	public partial class SQLiteDB : DatabaseRunner, IDatabase
	{
		private static SQLiteDB Instance;

		public static SQLiteDB GetInstance()
		{
			if (Instance == null)
			{
				throw new NotInitializedException(typeof(SQLiteDB));
			}
			return Instance;
		}

		public SQLiteDB(string connectionString) : base(typeof(SQLiteConnection))
		{
			Utils.NullChecker((connectionString, nameof(connectionString)));
			Instance = this;

			ConnectionString = connectionString;

			string dbName = GetDatabasePath(ConnectionString);
			if (!string.IsNullOrEmpty(dbName))
			{
				FilePath = dbName;
				if (!File.Exists(dbName))
				{
					CreateDatabase();
				}
			}
		}

		public SQLiteDB() : this(":memory:")
		{
		}

		~SQLiteDB()
		{
			try
			{
				Instance = null;
				CloseConnection();
			}
			catch { }
		}

		private readonly string ConnectionString;
		private readonly string FilePath;

		public const string DEFAULT_CONNECTION_STRING = "Data Source={0};Version=3;";

		private string GetDatabasePath(string connectionString)
		{
			connectionString = connectionString.Replace(" ", "");
			string[] split = connectionString.Split(';');

			foreach (string part in split)
			{
				if (part.Contains("Data Source"))
				{
					string dbName = part.Replace("Data Source", "");
					if (dbName.ToLower() == ":memory:")
					{
						return null;
					}
					return dbName;
				}
			}

			return null;
		}

		private void CreateDatabase()
		{
			SQLiteConnection.CreateFile(FilePath);
		}

		public override string GetConnectionString()
		{
			return ConnectionString;
		}

		public DbCommand CreateCommand()
		{
			return GetDatabaseConnection().CreateCommand();
		}

		public long GetLastRowId(string tableName)
		{
			DataTable result = ExecuteSql($"SELECT ROWID AS LAST FROM {tableName} ORDER BY LAST DESC");
			return Convert.ToInt64(result.Rows[0]["LAST"]);
		}
	}
}
