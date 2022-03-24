using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.Threading.Tasks;

namespace SlTestingR.Databases_AccessDB_Tests
{
	internal class Insert
	{
		private readonly string[] DbPaths = { @"C:\Dados\TestDB_Insert.accdb", @"C:\Dados\TestDB_InsertAsync.accdb" };
		private readonly AccessDB[] Dbs = new AccessDB[2];

		[SetUp]
		public void Setup()
		{
			AccessTableColumn textColumn = new AccessTableColumn("TextColumn", AccessDataType.Text);

			Dbs[0] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[0]);
			Dbs[0].CreateTable("Test", textColumn);
			Dbs[1] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[1]);
			Dbs[1].CreateTable("Test", textColumn);
		}

		[Test]
		public void TEST_Insert()
		{
			int moddedRows = Dbs[0].Insert("Test", new string[] { "TextColumn" }, new object[] { "'TEST_Insert()'" });
			Assert.IsTrue(moddedRows > 0);
		}

		[Test]
		public async Task TEST_InsertAsync()
		{
			int moddedRows = await Dbs[1].InsertAsync("Test", new string[] { "TextColumn" }, new object[] { "'TEST_InsertAsync()'" });
			Assert.IsTrue(moddedRows > 0);
		}

		[TearDown]
		public void Cleanup()
		{
			TestUtils.CleanupAccessTesting(DbPaths, Dbs);
		}
	}
}