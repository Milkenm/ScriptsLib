using System.Data.SqlClient;
using System.IO;

using ScriptsLibR.Databases.SqlServer.Types;
using ScriptsLibR.Exceptions;

namespace ScriptsLibR.Databases.SqlServer
{
	public partial class SqlServerDB
	{
		private static readonly SqlServerDB Instance;

		public SqlServerDB GetInstance()
		{
			if (Instance == null)
			{
				throw new NotInitializedException(this);
			}
			return Instance;
		}

		public SqlServerDB(string databasePath)
		{
			this.DatabasePath = databasePath;
			this.UsesDatabaseFile = true;
		}

		public SqlServerDB(string baseConnection, string databasePath = null)
		{
			this.BaseConnection = baseConnection;
			this.DatabasePath = databasePath;
			this.UsesDatabaseFile = databasePath != null;
		}

		/// <summary>The provider and stuff to connect to the database.</summary>
		public string BaseConnection { get; } = @"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=";

		/// <summary>The path where the .MDF database file is located.</summary>
		public string DatabasePath { get; }

		private bool UsesDatabaseFile { get; }

		private SqlConnection DbConnection;

		private SqlConnection GetDbConnection(bool requiresDatabaseToExist)
		{
			if (DbConnection != null)
			{
				return DbConnection;
			}

			string connectionString = this.BaseConnection;
			if (File.Exists(this.DatabasePath) && this.UsesDatabaseFile)
			{
				connectionString += this.DatabasePath;
			}
			else if (requiresDatabaseToExist && this.UsesDatabaseFile)
			{
				throw new DatabaseFileNotFoundException(this.DatabasePath);
			}
			return DbConnection = new SqlConnection(connectionString); ;
		}

		public struct SqlServerTableFields
		{
			public string Name;
			public SqlServerDataType DataType;
			public bool PrimaryKey;
			public bool AutoIncrement;
		}
	}
}
