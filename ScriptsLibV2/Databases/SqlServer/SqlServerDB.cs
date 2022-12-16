using System.Data.SqlClient;
using System.IO;

using ScriptsLibV2.Exceptions;

namespace ScriptsLibV2.Databases
{
	public partial class SqlServerDB : DatabaseRunner, IDatabase
	{
		private static SqlServerDB Instance;

		public SqlServerDB GetInstance()
		{
			if (Instance == null)
			{
				throw new NotInitializedException(this);
			}
			return Instance;
		}

		public SqlServerDB(string databasePath) : base(typeof(SqlConnection))
		{
			Instance = this;

			DatabasePath = databasePath;
			UsesDatabaseFile = true;
		}

		public SqlServerDB(string baseConnection, string databasePath = null) : base(typeof(SqlConnection))
		{
			Instance = this;

			ConnectionString = baseConnection;
			DatabasePath = databasePath;
			UsesDatabaseFile = databasePath != null;
		}

		~SqlServerDB()
		{
			try
			{
				Instance = null;
				CloseConnection();
			}
			catch { }
		}

		/// <summary>The provider and stuff to connect to the database.</summary>
		public string ConnectionString { get; }

		/// <summary>The path where the .MDF database file is located.</summary>
		public string DatabasePath { get; }

		private bool UsesDatabaseFile { get; }

		public override string GetConnectionString()
		{
			if (!UsesDatabaseFile)
			{
				return ConnectionString;
			}

			SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder
			{
				IntegratedSecurity = true
			};

			if (!File.Exists(DatabasePath))
			{
				throw new DatabaseFileNotFoundException(DatabasePath);
			}
			connectionStringBuilder.AttachDBFilename = DatabasePath;

			return connectionStringBuilder.ToString();
		}
	}
}