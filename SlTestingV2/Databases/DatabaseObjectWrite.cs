﻿using System;

using NUnit.Framework;

using ScriptsLibV2.Databases;

using SlTestingV2.Databases;

namespace SlTestingR.Databases
{
	internal class DatabaseObjectWrite
	{
		private AccessDB Database;

		[SetUp]
		public void Setup()
		{
			Database = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\TestDB.accdb");
		}

		[Test]
		public void TEST_DatabaseObjectWrite()
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
