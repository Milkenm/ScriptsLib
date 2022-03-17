using ScriptsLibR.Exceptions;

using System.Data.OleDb;
using System.IO;

namespace ScriptsLibR.Databases.AccessDB
{
    public partial class AccessDB
    {
        private static AccessDB Instance;

        public AccessDB GetInstance()
        {
            if (Instance == null)
            {
                throw new NotInitializedException(this);
            }
            return Instance;
        }

        public AccessDB(string databasePath)
        {
            Instance = this;
            this.DatabasePath = databasePath;
        }

        public AccessDB(string databasePath, string baseConnection)
        {
            Instance = this;
            this.DatabasePath = databasePath;
            this.BaseConnection = baseConnection;
        }

        private OleDbConnection DbConnection;

        private OleDbConnection GetDbConnection(bool requiresDatabaseToExist)
        {
            if (DbConnection != null)
            {
                return DbConnection;
            }

            string connectionString = this.BaseConnection;
            if (File.Exists(this.DatabasePath))
            {
                connectionString += this.DatabasePath;
            }
            else if (requiresDatabaseToExist)
            {
                throw new DatabaseFileNotFoundException(this.DatabasePath);
            }
            return DbConnection = new OleDbConnection(connectionString); ;
        }

        /// <summary>The provider and stuff to connect to the database.</summary>
        public string BaseConnection { get; } = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";

        /// <summary>The path where the .MDB database file is located.</summary>
        public string DatabasePath { get; }

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
    }
}
