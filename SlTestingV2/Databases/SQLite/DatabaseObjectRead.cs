using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using ScriptsLibV2.Databases;

namespace Databases
{
	internal class SQLite_DatabaseObjectRead
	{
		private SQLiteDB Database;

		[SetUp]
		public void Setup()
		{
			Database = new SQLiteDB(string.Format(SQLiteDB.DEFAULT_CONNECTION_STRING, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\TestDB.db"));
		}

		[Test]
		public void SQLite_DatabaseObject_Read()
		{
			TestDatabaseObject obj = new TestDatabaseObject(Database, "Test");
			obj.LoadFromDatabase(1);

			Assert.AreEqual("a", obj.Name);
		}

		[TearDown]
		public void Cleanup()
		{
			Database.CloseConnection();
		}
	}
}
