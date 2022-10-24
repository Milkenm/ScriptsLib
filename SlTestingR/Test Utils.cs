using ScriptsLibR.Interfaces;

using System.IO;

namespace SlTestingR
{
	internal static class TestUtils
	{
		public static void CleanupAccessTesting<T>(string[] dbPaths, IDatabase<T>[] dbs)
		{
			foreach (IDatabase<T> db in dbs)
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
