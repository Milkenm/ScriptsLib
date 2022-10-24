using NUnit.Framework;

using ScriptsLibR.Databases;

using System.Data;

namespace SlTestingR.Databases_AccessDB_Tests
{
	internal class Select
	{
		private readonly string[] DbPaths = { @"C:\Dados\TestDb_Select.accdb" };
		private readonly AccessDB[] Dbs = new AccessDB[1];

		[SetUp]
		public void Setup()
		{
			Dbs[0] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[0]);

			AccessTableColumn idColumn = new AccessTableColumn("ID");
			AccessTableColumn textColumn = new AccessTableColumn("Text", AccessDataType.Text);
			Dbs[0].CreateTable("Test_Select", idColumn, textColumn);

			Dbs[0].Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 1'" });
			Dbs[0].Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 2'" });
			Dbs[0].Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 3'" });
			Dbs[0].Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 4'" });
			Dbs[0].Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 5'" });
		}

		[Test]
		public void TEST_Select()
		{
			DataTable dt = Dbs[0].Select("Test_Select");
			Assert.IsTrue(dt.Rows.Count == 5 && (string)dt.Rows[0]["Text"] == "Value 1");

			/*
            Console.WriteLine("ID | Text\n---------");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["ID"]} | '{row["Text"]}'");
            }
            */
		}

		[TearDown]
		public void Cleanup()
		{
			TestUtils.CleanupAccessTesting(DbPaths, Dbs);
		}
	}
}