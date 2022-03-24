using Microsoft.Office.Interop.Access.Dao;

using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.IO;

namespace SlTestingR.Databases_AccessDB_Tests
{
	internal class CreateDatabase
	{
		private readonly string[] DbPaths = { @"C:\Dados\TestDb_CreateDatabase.accdb", @"C:\Dados\TestDb_CreateDatabaseOnConstructor.accdb" };
		private readonly AccessDB[] Dbs = new AccessDB[2];

		[Test]
		public void TEST_CreateDatabase()
		{
			AccessDB.CreateDatabase(DbPaths[1], DatabaseTypeEnum.dbVersion120);
			Assert.IsTrue(File.Exists(DbPaths[1]));
		}

		[Test]
		public void TEST_CreateDatabaseOnConstructor()
		{
			Dbs[0] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[0]);
			Assert.IsTrue(File.Exists(DbPaths[0]));
		}

		[TearDown]
		public void Cleanup()
		{
			TestUtils.CleanupAccessTesting(DbPaths, Dbs);
		}
	}
}