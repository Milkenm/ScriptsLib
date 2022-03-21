using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.IO;

namespace SlTestingR
{
	internal class CreateDatabase
	{
		private const string DB_PATH = @"C:\Dados\TestDb_CreateDatabase.accdb";
		private AccessDB Db;

		[Test]
		public void Test()
		{
			Db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE150 + DB_PATH);
			Assert.IsTrue(File.Exists(DB_PATH));
		}

		[TearDown]
		public void Cleanup()
		{
			File.Delete(DB_PATH);
		}
	}
}
