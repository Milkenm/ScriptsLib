using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;

namespace ScriptsLibR.Databases.AccessDB.Tests
{
	[TestClass()]
	public class DeleteTable
	{
		[TestMethod()]
		public void TEST_DeleteTable()
		{
			string dbPath = @"C:\Dados\TestDB_DeleteTable.accdb";
			File.Delete(dbPath);
			AccessDB db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + dbPath);

			AccessTableColumn idField = new AccessTableColumn("ID", AccessDataType.Counter);
			db.CreateTable("Table", idField);
			db.DeleteTable("Table");

			db.CloseConnection();
		}
	}
}
