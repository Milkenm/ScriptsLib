using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;
using System.Threading.Tasks;

namespace ScriptsLibR.Databases.AccessDB.Tests
{
	[TestClass()]
	public class Insert
	{
		[TestMethod()]
		public void TEST_Insert()
		{
			string dbPath = @"C:\Dados\TestDB_Insert.accdb";
			File.Delete(dbPath);
			AccessDB db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + dbPath);

			AccessTableColumn textColumn = new AccessTableColumn("TextColumn", AccessDataType.Text);
			db.CreateTable("Test", textColumn);

			int moddedRows = db.Insert("Test", new string[] { "TextColumn" }, new object[] { "'TEST_Insert()'" });
			db.CloseConnection();

			Assert.IsTrue(moddedRows > 0);
			db.CloseConnection();
		}

		[TestMethod()]
		public async Task TEST_InsertAsync()
		{
			string dbPath = @"C:\Dados\TestDB_InsertAsync.accdb";
			File.Delete(dbPath);
			AccessDB db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + dbPath);

			AccessTableColumn textColumn = new AccessTableColumn("TextColumn", AccessDataType.Text);
			db.CreateTable("Test", textColumn);

			int moddedRows = await db.InsertAsync("Test", new string[] { "TextColumn" }, new object[] { "'TEST_InsertAsync()'" });
			db.CloseConnection();

			Assert.IsTrue(moddedRows > 0);
			db.CloseConnection();
		}
	}
}