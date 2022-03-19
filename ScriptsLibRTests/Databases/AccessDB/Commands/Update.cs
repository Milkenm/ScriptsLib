using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;

namespace ScriptsLibR.Databases.AccessDB.Tests
{
	[TestClass()]
	public class Update
	{
		[TestMethod()]
		public void Test_Update()
		{
			string dbPath = @"C:\Dados\TestDb_Update.accdb";
			File.Delete(dbPath);
			AccessDB db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + dbPath);

			AccessTableColumn idColumn = new AccessTableColumn("ID");
			AccessTableColumn textColumn = new AccessTableColumn("Text", AccessDataType.Text);
			db.CreateTable("Test_Update", idColumn, textColumn);

			db.Insert("Test_Update", new string[] { "Text" }, new object[] { "'Value 1'" });
			string before = (string)db.Select("Test_Update").Rows[0]["Text"];

			db.Update("Test_Update", "[Text]='Updated Value 1'", "[Text]='Value 1'");
			string after = (string)db.Select("Test_Update").Rows[0]["Text"];



			db.CloseConnection();
			Assert.IsTrue(before != after && after == "Updated Value 1");
		}
	}
}