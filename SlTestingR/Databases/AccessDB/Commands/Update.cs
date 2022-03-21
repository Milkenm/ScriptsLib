using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.IO;

namespace SlTestingR.Databases.AccessDBTests
{
	internal class Update
	{
		private const string DB_PATH = @"C:\Dados\TestDb_Update.accdb";
		private AccessDB Db;
		private string Before;

		[SetUp]
		public void Setup()
		{
			Db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DB_PATH);

			AccessTableColumn idColumn = new AccessTableColumn("ID");
			AccessTableColumn textColumn = new AccessTableColumn("Text", AccessDataType.Text);
			Db.CreateTable("Test_Update", idColumn, textColumn);

			Db.Insert("Test_Update", new string[] { "Text" }, new object[] { "'Value 1'" });
			Before = (string)Db.Select("Test_Update").Rows[0]["Text"];
		}

		[Test]
		public void TEST_Update()
		{
			Db.Update("Test_Update", "[Text]='Updated Value 1'", "[Text]='Value 1'");
			string after = (string)Db.Select("Test_Update").Rows[0]["Text"];

			Assert.IsTrue(Before != after && after == "Updated Value 1");
		}

		[TearDown]
		public void Cleanup()
		{
			Db.CloseConnection();
			File.Delete(DB_PATH);
		}
	}
}