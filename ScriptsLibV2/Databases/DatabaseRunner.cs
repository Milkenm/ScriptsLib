using System;
using System.Data;
using System.Data.Common;

namespace ScriptsLibV2.Databases
{
	public abstract partial class DatabaseRunner
	{
		private readonly Type DatabaseType;

		public DatabaseRunner(Type databaseConnectionType)
		{
			DatabaseType = databaseConnectionType;
		}

		private DbConnection DbConnection;

		public abstract string GetConnectionString();

		public T GetDatabaseConnection<T>()
		{
			return (T)Convert.ChangeType(GetDatabaseConnection(), typeof(T));
		}

		public DbConnection GetDatabaseConnection()
		{
			if (DbConnection != null)
			{
				return DbConnection;
			}

			OpenConnection();

			return DbConnection;
		}

		public void OpenConnection()
		{
			DbConnection ??= (DbConnection)Activator.CreateInstance(DatabaseType, args: GetConnectionString());

			if (DbConnection.State != ConnectionState.Open)
			{
				DbConnection.Open();
			}
		}

		public void CloseConnection()
		{
			if (DbConnection != null && DbConnection.State == ConnectionState.Open)
			{
				DbConnection.Close();
			}
		}
	}
}
