
using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.Data;
using System.IO;

namespace SlTestingR
{
	internal class Select
	{
		private const string DB_PATH = @"C:\Dados\TestDb_Select.accdb";
		private AccessDB Db;

		[SetUp]
		public void Setup()
		{
			Db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DB_PATH);

			AccessTableColumn idColumn = new AccessTableColumn("ID");
			AccessTableColumn textColumn = new AccessTableColumn("Text", AccessDataType.Text);
			Db.CreateTable("Test_Select", idColumn, textColumn);

			Db.Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 1'" });
			Db.Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 2'" });
			Db.Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 3'" });
			Db.Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 4'" });
			Db.Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 5'" });
		}

		[Test]
		public void Test()
		{
			DataTable dt = Db.Select("Test_Select");
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
			Db.CloseConnection();
			File.Delete(DB_PATH);
		}
	}
}
