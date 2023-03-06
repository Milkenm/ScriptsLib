using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using ScriptsLibV2.Databases;

namespace Databases
{
	internal class SQLite_DatabaseObjectWrite
	{
		private SQLiteDB Database;

		[SetUp]
		public void Setup()
		{
			Database = new SQLiteDB(string.Format(SQLiteDB.DEFAULT_CONNECTION_STRING, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\TestDB.db"));
		}

		[Test]
		public void SQLite_DatabaseObject_Write()
		{
			TestDatabaseObject obj = new TestDatabaseObject(Database, "Test");
			obj.SetName("Lmao");
			long id = obj.SaveToDatabase();

			Assert.AreEqual(Database.GetLastRowId("Test"), id);
		}

		[TearDown]
		public void Cleanup()
		{
			Database.CloseConnection();
		}
	}
}
