using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.IO;

namespace ScriptsLibR.Databases.AccessDB.Tests
{
	[TestClass()]
	public class CreateTable
	{
		[TestMethod()]
		public void TEST_CreateTable()
		{
			string dbPath = @"C:\Dados\TestDB_CreateTable.accdb";
			File.Delete(dbPath);
			AccessDB db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + dbPath);



			AccessTableColumn bigBinaryField = new AccessTableColumn("BigBinary", AccessDataType.BigBinary);
			db.CreateTable("Table_BigBinary", bigBinaryField);

			AccessTableColumn binaryField = new AccessTableColumn("Binary", AccessDataType.Binary);
			db.CreateTable("Table_Binary", binaryField);

			AccessTableColumn bitField = new AccessTableColumn("Bit", AccessDataType.Bit);
			db.CreateTable("Table_Bit", bitField);

			AccessTableColumn counterField = new AccessTableColumn("Counter", AccessDataType.Counter);
			db.CreateTable("Table_Counter", counterField);

			AccessTableColumn currencyField = new AccessTableColumn("Currency", AccessDataType.Currency);
			db.CreateTable("Table_Currency", currencyField);

			AccessTableColumn dateTimeField = new AccessTableColumn("DateTime", AccessDataType.DateTime);
			db.CreateTable("Table_DateTime", dateTimeField);

			AccessTableColumn guidField = new AccessTableColumn("Guid", AccessDataType.Guid);
			db.CreateTable("Table_Guid", guidField);

			AccessTableColumn longTextField = new AccessTableColumn("LongText", AccessDataType.LongText);
			db.CreateTable("Table_LongText", longTextField);

			AccessTableColumn numberSingleField = new AccessTableColumn("NumberSingle", AccessDataType.NumberSingle);
			db.CreateTable("Table_NumberSingle", numberSingleField);

			AccessTableColumn numberDoubleField = new AccessTableColumn("NumberDouble", AccessDataType.NumberDouble);
			db.CreateTable("Table_NumberDouble", numberDoubleField);

			AccessTableColumn numberByteField = new AccessTableColumn("NumberByte", AccessDataType.NumberByte);
			db.CreateTable("Table_NumberByte", numberByteField);

			AccessTableColumn numberIntegerField = new AccessTableColumn("NumberInteger", AccessDataType.NumberInteger);
			db.CreateTable("Table_NumberInteger", numberIntegerField);

			AccessTableColumn numberLongIntegerField = new AccessTableColumn("NumberLongInteger", AccessDataType.NumberLongInteger);
			db.CreateTable("Table_NumberLongInteger", numberLongIntegerField);

			AccessTableColumn numericField = new AccessTableColumn("Numeric", AccessDataType.Numeric);
			db.CreateTable("Table_Numeric", numericField);

			AccessTableColumn oleField = new AccessTableColumn("Ole", AccessDataType.Ole);
			db.CreateTable("Table_Ole", oleField);

			AccessTableColumn textField = new AccessTableColumn("Text", AccessDataType.Text);
			db.CreateTable("Table_Text", textField);



			db.CloseConnection();
			File.Delete(dbPath);
		}
	}
}
