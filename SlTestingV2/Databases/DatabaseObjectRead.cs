using System;

using NUnit.Framework;

using ScriptsLibV2.Databases;

using SlTestingV2.Databases;

namespace SlTestingR.Databases
{
	internal class DatabaseObjectRead
	{
		private AccessDB Database;

		[SetUp]
		public void Setup()
		{
			Database = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\TestDB.accdb");
		}

		[Test]
		public void TEST_DatabaseObjectRead()
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