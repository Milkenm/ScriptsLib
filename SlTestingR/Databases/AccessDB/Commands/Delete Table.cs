
using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.IO;

namespace SlTestingR
{
	internal class DeleteTable
	{
		private const string DB_PATH = @"C:\Dados\TestDB_DeleteTable.accdb";
		private AccessDB Db;

		[SetUp]
		public void Setup()
		{
			Db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DB_PATH);

			AccessTableColumn idField = new AccessTableColumn("ID", AccessDataType.Counter);
			Db.CreateTable("Table", idField);
		}

		[Test]
		public void Test()
		{
			Db.DeleteTable("Table");
		}

		[TearDown]
		public void Cleanup()
		{
			Db.CloseConnection();
			File.Delete(DB_PATH);
		}
	}
}
