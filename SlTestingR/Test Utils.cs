using ScriptsLibR.Databases.AccessDB;

using System.IO;

namespace SlTestingR
{
	internal static class TestUtils
	{
		public static void CleanupAccessTesting(string[] dbPaths, AccessDB[] dbs)
		{
			foreach (AccessDB db in dbs)
			{
				if (db != null)
				{
					db.CloseConnection();
				}
			}
			foreach (string dbPath in dbPaths)
			{
				File.Delete(dbPath);
			}
		}
	}
}
