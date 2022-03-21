using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.IO;
using System.Threading.Tasks;

namespace SlTestingR.Databases.AccessDBTests
{
	internal class Insert
	{
		private const string DB_PATH = @"C:\Dados\TestDB_Insert.accdb";
		private AccessDB Db;

		[SetUp]
		public void Setup()
		{
			Db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DB_PATH);

			AccessTableColumn textColumn = new AccessTableColumn("TextColumn", AccessDataType.Text);
			Db.CreateTable("Test", textColumn);
		}

		[Test]
		public void TEST_Insert()
		{
			int moddedRows = Db.Insert("Test", new string[] { "TextColumn" }, new object[] { "'TEST_Insert()'" });
			Assert.IsTrue(moddedRows > 0);
		}

		[Test]
		public async Task TEST_InsertAsync()
		{
			int moddedRows = await Db.InsertAsync("Test", new string[] { "TextColumn" }, new object[] { "'TEST_InsertAsync()'" });
			Assert.IsTrue(moddedRows > 0);
		}

		[TearDown]
		public void Cleanup()
		{
			Db.CloseConnection();
			File.Delete(DB_PATH);
		}
	}
}