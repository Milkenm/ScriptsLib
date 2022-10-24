using NUnit.Framework;

using ScriptsLibR.Databases;

using System.Threading.Tasks;

namespace SlTestingR.Databases_AccessDB_Tests
{
	internal class DeleteTable
	{
		private readonly string[] DbPaths = { @"C:\Dados\TestDB_DeleteTable.accdb", @"C:\Dados\TestDB_DeleteTableAsync.accdb" };
		private readonly AccessDB[] Dbs = new AccessDB[2];

		[SetUp]
		public void Setup()
		{
			AccessTableColumn idField = new AccessTableColumn("ID", AccessDataType.Counter);

			Dbs[0] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[0]);
			Dbs[0].CreateTable("Table", idField);
			Dbs[1] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[1]);
			Dbs[1].CreateTable("Table", idField);
		}

		[Test]
		public void TEST_DeleteTable()
		{
			Dbs[0].DeleteTable("Table");
		}

		[Test]
		public async Task TEST_DeleteTableAsync()
		{
			await Dbs[1].DeleteTableAsync("Table");
		}

		[TearDown]
		public void Cleanup()
		{
			TestUtils.CleanupAccessTesting(DbPaths, Dbs);
		}
	}
}