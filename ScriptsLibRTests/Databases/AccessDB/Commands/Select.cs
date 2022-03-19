using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Data;
using System.IO;

namespace ScriptsLibR.Databases.AccessDB.Tests
{
	[TestClass()]
	public class Select
	{
		[TestMethod()]
		public void TEST_Select()
		{
			string dbPath = @"C:\Dados\TestDb_Select.accdb";
			File.Delete(dbPath);
			AccessDB db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + dbPath);

			AccessTableColumn idColumn = new AccessTableColumn("ID");
			AccessTableColumn textColumn = new AccessTableColumn("Text", AccessDataType.Text);
			db.CreateTable("Test_Select", idColumn, textColumn);
			db.Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 1'" });
			db.Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 2'" });
			db.Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 3'" });
			db.Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 4'" });
			db.Insert("Test_Select", new string[] { "Text" }, new object[] { "'Value 5'" });

			DataTable dt = db.Select("Test_Select");
			Console.WriteLine("ID | Text\n---------");
			foreach (DataRow row in dt.Rows)
			{
				Console.WriteLine($"{row["ID"]} | '{row["Text"]}'");
			}
			db.CloseConnection();

			Assert.IsTrue(dt.Rows.Count == 5 && (string)dt.Rows[0]["Text"] == "Value 1");
			db.CloseConnection();
		}
	}
}