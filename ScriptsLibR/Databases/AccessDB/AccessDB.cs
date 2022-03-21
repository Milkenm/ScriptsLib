using ADOX;

using ScriptsLibR.Exceptions;
using ScriptsLibR.Extensions;

using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;

namespace ScriptsLibR.Databases.AccessDB
{
    public partial class AccessDB
    {
        private static AccessDB Instance;

        public static AccessDB GetInstance()
        {
            if (Instance == null)
            {
                throw new NotInitializedException(Instance);
            }
            return Instance;
        }

        public AccessDB(string connectionString)
        {
            Instance = this;

            ConnectionString = connectionString;

            CreateDatabaseIfNotExists();
        }

        public string GetDatabasePath()
        {
            string databasePath = null;
            foreach (string split in ConnectionString.Split(';'))
            {
                if (split.ToLower().Replace(" ", "").StartsWith("datasource=") && (split.ToLower().EndsWith(".mdb") || split.ToLower().EndsWith(".accdb")))
                {
                    databasePath = split.Split('=')[1];
                }
            }
            return databasePath;
        }

        public void CreateDatabaseIfNotExists()
        {
            string databasePath = GetDatabasePath();

            if (!databasePath.IsEmpty() && !File.Exists(databasePath))
            {
                Catalog cat = new Catalog();
                cat.Create(ConnectionString);

                // https://stackoverflow.com/a/14102594
                // This took me 4 days to fix because I had two different computers where one worked fine and the other didn't...
                Marshal.FinalReleaseComObject(cat.Tables);
                Marshal.FinalReleaseComObject(cat.ActiveConnection);
                Marshal.FinalReleaseComObject(cat);
            }
        }

        private OleDbConnection DbConnection;

        private OleDbConnection GetDbConnection()
        {
            if (DbConnection != null)
            {
                return DbConnection;
            }

            if (!GetDatabasePath().IsEmpty() && !File.Exists(GetDatabasePath()))
            {
                CreateDatabaseIfNotExists();
            }
            DbConnection = new OleDbConnection(ConnectionString);
            if (DbConnection.State != ConnectionState.Open)
            {
                DbConnection.Open();
            }
            return DbConnection;
        }

        public void CloseConnection()
        {
            if (DbConnection != null && DbConnection.State == ConnectionState.Open)
            {
                DbConnection.Close();
            }
        }

        public const string DEFAULT_BASECONNECTION_JET40 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public const string DEFAULT_BASECONNECTION_ACE120 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";

        /// <summary>
        /// The provider and stuff to connect to the database.
        /// <para>Visit <see href="https://www.connectionstrings.com/access/">ConnectionStrings.com</see> for more connection strings.</para>
        /// </summary>
        public string ConnectionString { get; } = DEFAULT_BASECONNECTION_JET40;
    }
}