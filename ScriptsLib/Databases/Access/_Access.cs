namespace ScriptsLib.nDatabases
{
	public static partial class AccessDatabase
	{
		/// <summary>The provider and stuff to connect to the database.</summary>
		public static string _BaseConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";

		/// <summary>The path where the .mdb database file is located.</summary>
		public static string _DatabasePath { get; set; }
	}
}