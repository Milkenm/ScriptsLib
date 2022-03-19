using ADOX;

using ScriptsLibR.Exceptions;
using ScriptsLibR.Extensions;

using System.Data;
using System.Data.OleDb;
using System.IO;

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

			this.ConnectionString = connectionString;

			this.CreateDatabaseIfNotExists();
		}

		public string GetDatabasePath()
		{
			string databasePath = null;
			foreach (string split in this.ConnectionString.Split(';'))
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
			string databasePath = this.GetDatabasePath();

			if (!databasePath.IsEmpty() && !File.Exists(databasePath))
			{
				Catalog CreateDB = new Catalog();
				CreateDB.Create(this.ConnectionString);

				DbConnection = CreateDB.ActiveConnection as OleDbConnection;
			}
		}

		private OleDbConnection DbConnection;

		private OleDbConnection GetDbConnection()
		{
			if (DbConnection != null)
			{
				return DbConnection;
			}

			if (!this.GetDatabasePath().IsEmpty() && !File.Exists(this.GetDatabasePath()))
			{
				this.CreateDatabaseIfNotExists();
			}
			DbConnection = new OleDbConnection(this.ConnectionString);
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