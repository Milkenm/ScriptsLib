using System;

using NUnit.Framework;

using ScriptsLibV2.Databases;

namespace Databases
{
	internal class Access_DatabaseObjectRead
	{
		private AccessDB Database;

		[SetUp]
		public void Setup()
		{
			Database = new AccessDB(string.Format(AccessDB.DEFAULT_CONNECTION_ACE120, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\TestDB.accdb"));
		}

		[Test]
		public void Access_DatabaseObject_Read()
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