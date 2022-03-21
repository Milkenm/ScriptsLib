﻿using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.IO;

namespace SlTestingR.Databases.AccessDBTests
{
	internal class CreateDatabase
	{
		private const string DB_PATH = @"C:\Dados\TestDb_CreateDatabase.accdb";
		private AccessDB Db;

		[Test]
		public void TEST_CreateDatabase()
		{
			Db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DB_PATH);
			Assert.IsTrue(File.Exists(DB_PATH));
		}

		[TearDown]
		public void Cleanup()
		{
			File.Delete(DB_PATH);
		}
	}
}