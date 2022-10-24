using NUnit.Framework;

using ScriptsLibR.Databases;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SlTestingR.Databases_MySqlDB_Tests
{
	internal class CreateTable
	{
		MySqlDB Db;

		[SetUp]
		public void Setup()
		{
			Db = new MySqlDB("localhost", 3306, "testing", "TestUser", "testpassword", null);
		}

		[Test]
		public void TEST_CreateTable()
		{
			//Db.CreateTable();
		}

		[Test]
		public async Task TEST_CreateTableAsync()
		{
			//Db.CreateTable("")
		}

		[TearDown]
		public void Cleanup()
		{

		}
	}
}
