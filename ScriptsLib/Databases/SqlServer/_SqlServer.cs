namespace ScriptsLib.Databases
{
	public static partial class SqlServerDatabase
	{
		/// <summary>The provider and stuff to connect to the database.</summary>
		internal static readonly string _BaseConnection = @"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=";

		/// <summary>The path where the .mdf database file is located.</summary>
		public static string _DatabasePath { get; set; }
	}
}
