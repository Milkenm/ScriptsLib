namespace ScriptsLib.nDatabases
{
	public static partial class MySqlDatabase
	{
		/// <summary>The base connection to connect to the MySql database server.</summary>
		public static string _BaseConnection = @"Server={0}; Port={1}; User ID={2}; Password={3}; Database={4}; SslMode={5}";

		/// <summary>The server IP/domain.</summary>
		public static string _Server { get; set; }

		/// <summary>The server port.</summary>
		public static int _Port { get; set; }

		/// <summary>The server database name.</summary>
		public static string _Database { get; set; }

		/// <summary>User required to login into the MySql database.</summary>
		public static string _User { get; set; }

		/// <summary>Password for the given user used to connect to the MySql database.</summary>
		public static string _Password { get; set; }

		/// <summary>idk (TODO - report this if u see)</summary>
		public static string _SslMode { get; set; }
	}
}
