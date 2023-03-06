using System;

using NUnit.Framework;

using ScriptsLibV2.Databases;

namespace Databases
{
	internal class Access_DatabaseObjectWrite
	{
		private AccessDB Database;

		[SetUp]
		public void Setup()
		{
			Database = new AccessDB(string.Format(AccessDB.DEFAULT_CONNECTION_ACE120, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\TestDB.accdb"));
		}

		[Test]
		public void Access_DatabaseObject_Write()
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
