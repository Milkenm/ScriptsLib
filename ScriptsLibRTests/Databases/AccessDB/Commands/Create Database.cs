using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;

namespace ScriptsLibR.Databases.AccessDB.Tests
{
	[TestClass()]
	public class CreateDatabase
	{
		[TestMethod()]
		public void TEST_CreateDatabase()
		{
			string dbPath = @"C:\Dados\TestDb_CreateDatabase.accdb";
			File.Delete(dbPath);

			AccessDB db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + dbPath);

			Assert.IsTrue(File.Exists(dbPath));
			db.CloseConnection();
		}
	}
}