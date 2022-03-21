
using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.IO;

namespace SlTestingR
{
	internal class CreateTable
	{
		private const string DB_PATH = @"C:\Dados\TestDB_CreateTable.accdb";
		private AccessDB Db;

		[SetUp]
		public void Setup()
		{
			Db = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DB_PATH);
		}

		[Test]
		public void Test()
		{
			AccessTableColumn bigBinaryField = new AccessTableColumn("BigBinary", AccessDataType.BigBinary);
			Db.CreateTable("Table_BigBinary", bigBinaryField);

			AccessTableColumn binaryField = new AccessTableColumn("Binary", AccessDataType.Binary);
			Db.CreateTable("Table_Binary", binaryField);

			AccessTableColumn bitField = new AccessTableColumn("Bit", AccessDataType.Bit);
			Db.CreateTable("Table_Bit", bitField);

			AccessTableColumn counterField = new AccessTableColumn("Counter", AccessDataType.Counter);
			Db.CreateTable("Table_Counter", counterField);

			AccessTableColumn currencyField = new AccessTableColumn("Currency", AccessDataType.Currency);
			Db.CreateTable("Table_Currency", currencyField);

			AccessTableColumn dateTimeField = new AccessTableColumn("DateTime", AccessDataType.DateTime);
			Db.CreateTable("Table_DateTime", dateTimeField);

			AccessTableColumn guidField = new AccessTableColumn("Guid", AccessDataType.Guid);
			Db.CreateTable("Table_Guid", guidField);

			AccessTableColumn longTextField = new AccessTableColumn("LongText", AccessDataType.LongText);
			Db.CreateTable("Table_LongText", longTextField);

			AccessTableColumn numberSingleField = new AccessTableColumn("NumberSingle", AccessDataType.NumberSingle);
			Db.CreateTable("Table_NumberSingle", numberSingleField);

			AccessTableColumn numberDoubleField = new AccessTableColumn("NumberDouble", AccessDataType.NumberDouble);
			Db.CreateTable("Table_NumberDouble", numberDoubleField);

			AccessTableColumn numberByteField = new AccessTableColumn("NumberByte", AccessDataType.NumberByte);
			Db.CreateTable("Table_NumberByte", numberByteField);

			AccessTableColumn numberIntegerField = new AccessTableColumn("NumberInteger", AccessDataType.NumberInteger);
			Db.CreateTable("Table_NumberInteger", numberIntegerField);

			AccessTableColumn numberLongIntegerField = new AccessTableColumn("NumberLongInteger", AccessDataType.NumberLongInteger);
			Db.CreateTable("Table_NumberLongInteger", numberLongIntegerField);

			AccessTableColumn numericField = new AccessTableColumn("Numeric", AccessDataType.Numeric);
			Db.CreateTable("Table_Numeric", numericField);

			AccessTableColumn oleField = new AccessTableColumn("Ole", AccessDataType.Ole);
			Db.CreateTable("Table_Ole", oleField);

			AccessTableColumn textField = new AccessTableColumn("Text", AccessDataType.Text);
			Db.CreateTable("Table_Text", textField);
		}

		[TearDown]
		public void Cleanup()
		{
			Db.CloseConnection();
			File.Delete(DB_PATH);
		}
	}
}
