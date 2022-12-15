using System.IO;
using ScriptsLibR.Databases;

namespace SlTestingR
{
    internal static class TestUtils
	{
		public static void CleanupAccessTesting(string[] dbPaths, IDatabase[] dbs)
		{
			foreach (IDatabase db in dbs)
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
