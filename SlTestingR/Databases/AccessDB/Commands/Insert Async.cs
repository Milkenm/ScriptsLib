using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.IO;
using System.Threading.Tasks;

namespace SlTestingR
{
	internal class InsertAsync
	{
		private const string DB_PATH = @"C:\Dados\TestDB_InsertAsync.accdb";
		private AccessDB Db;

		[SetUp]
		public void Setup()
		{
			Db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DB_PATH);

			AccessTableColumn textColumn = new AccessTableColumn("TextColumn", AccessDataType.Text);
			Db.CreateTable("Test", textColumn);
		}

		[Test]
		public async Task Test()
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
