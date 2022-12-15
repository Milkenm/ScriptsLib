using System.Data;
using System.Data.Common;

using MySql.Data.MySqlClient;

using ScriptsLibR.Exceptions;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB : DatabaseRunner, IDatabase
	{
		private static MySqlDB Instance;

		public MySqlDB GetInstance()
		{
			if (Instance == null)
			{
				throw new NotInitializedException(this);
			}
			return Instance;
		}

		public MySqlDB(string server, short port, string database, string user, string password, string sslMode) : base(typeof(MySqlConnection))
		{
			Instance = this;

			Server = server;
			Port = port;
			Database = database;
			User = user;
			Password = password;
			SslMode = sslMode;
		}

		public MySqlDB(string server, short port, string database, string user, string password, string sslMode, string baseConnection) : base(typeof(MySqlConnection))
		{
			Instance = this;

			Server = server;
			Port = port;
			Database = database;
			User = user;
			Password = password;
			SslMode = sslMode;

			BaseConnection = baseConnection;
		}

		~MySqlDB()
		{
			try
			{
				Instance = null;
				CloseConnection();
			}
			catch { }
		}

		/// <summary>The base connection to connect to the MySql database server.</summary>
		public static string BaseConnection { get; private set; } = "Server={0}; Port={1}; User ID={2}; Password={3}; Database={4}; SslMode={5}";

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

		public override string GetConnectionString()
		{
			return string.Format(BaseConnection, Server, Port, User, Password, Database, SslMode);
		}
	}
}
