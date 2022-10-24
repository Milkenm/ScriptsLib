using NUnit.Framework;

using ScriptsLibR.Databases;

using System.Threading.Tasks;

namespace SlTestingR.Databases_AccessDB_Tests
{
	internal class Update
	{
		private readonly string[] DbPaths = { @"C:\Dados\TestDb_Update.accdb", @"C:\Dados\TestDb_UpdateAsync.accdb" };
		private readonly AccessDB[] Dbs = new AccessDB[2];

		[SetUp]
		public void Setup()
		{
			AccessTableColumn idColumn = new AccessTableColumn("ID");
			AccessTableColumn textColumn = new AccessTableColumn("Text", AccessDataType.Text);

			Dbs[0] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[0]);
			Dbs[0].CreateTable("Test_Update", idColumn, textColumn);
			Dbs[0].Insert("Test_Update", new string[] { "Text" }, new object[] { "'Value 1'" });

			Dbs[1] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[1]);
			Dbs[1].CreateTable("Test_Update", idColumn, textColumn);
			Dbs[1].Insert("Test_Update", new string[] { "Text" }, new object[] { "'Value 2'" });
		}

		[Test]
		public void TEST_Update()
		{
			string before = (string)Dbs[0].Select("Test_Update").Rows[0]["Text"];
			Dbs[0].Update("Test_Update", "[Text]='Updated Value 1'", "[Text]='Value 1'");
			string after = (string)Dbs[0].Select("Test_Update").Rows[0]["Text"];

			Assert.IsTrue(before != after && after == "Updated Value 1");
		}

		[Test]
		public async Task TEST_UpdateAsync()
		{
			string before = (string)Dbs[1].Select("Test_Update").Rows[0]["Text"];
			await Dbs[1].UpdateAsync("Test_Update", "[Text]='Updated Value 2'", "[Text]='Value 2'");
			string after = (string)Dbs[1].Select("Test_Update").Rows[0]["Text"];

			Assert.IsTrue(before != after && after == "Updated Value 2");
		}

		[TearDown]
		public void Cleanup()
		{
			TestUtils.CleanupAccessTesting(DbPaths, Dbs);
		}
	}
}