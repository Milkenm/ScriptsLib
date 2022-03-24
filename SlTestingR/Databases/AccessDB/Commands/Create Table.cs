using NUnit.Framework;

using ScriptsLibR.Databases.AccessDB;

using System.IO;
using System.Threading.Tasks;

namespace SlTestingR.Databases_AccessDB_Tests
{
	internal class CreateTable
	{
		private readonly string[] DbPaths = { @"C:\Dados\TestDB_CreateTable.accdb", @"C:\Dados\TestDB_CreateTableAsync.accdb" };
		private readonly AccessDB[] Dbs = new AccessDB[2];

		[SetUp]
		public void Setup()
		{
			Dbs[0] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[0]);
			Dbs[1] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[1]);
		}

		[Test]
		public void TEST_CreateTable()
		{
			AccessTableColumn bigBinaryField = new AccessTableColumn("BigBinary", AccessDataType.BigBinary);
			Dbs[0].CreateTable("Table_BigBinary", bigBinaryField);

			AccessTableColumn binaryField = new AccessTableColumn("Binary", AccessDataType.Binary);
			Dbs[0].CreateTable("Table_Binary", binaryField);

			AccessTableColumn bitField = new AccessTableColumn("Bit", AccessDataType.Bit);
			Dbs[0].CreateTable("Table_Bit", bitField);

			AccessTableColumn counterField = new AccessTableColumn("Counter", AccessDataType.Counter);
			Dbs[0].CreateTable("Table_Counter", counterField);

			AccessTableColumn currencyField = new AccessTableColumn("Currency", AccessDataType.Currency);
			Dbs[0].CreateTable("Table_Currency", currencyField);

			AccessTableColumn dateTimeField = new AccessTableColumn("DateTime", AccessDataType.DateTime);
			Dbs[0].CreateTable("Table_DateTime", dateTimeField);

			AccessTableColumn guidField = new AccessTableColumn("Guid", AccessDataType.Guid);
			Dbs[0].CreateTable("Table_Guid", guidField);

			AccessTableColumn longTextField = new AccessTableColumn("LongText", AccessDataType.LongText);
			Dbs[0].CreateTable("Table_LongText", longTextField);

			AccessTableColumn numberSingleField = new AccessTableColumn("NumberSingle", AccessDataType.NumberSingle);
			Dbs[0].CreateTable("Table_NumberSingle", numberSingleField);

			AccessTableColumn numberDoubleField = new AccessTableColumn("NumberDouble", AccessDataType.NumberDouble);
			Dbs[0].CreateTable("Table_NumberDouble", numberDoubleField);

			AccessTableColumn numberByteField = new AccessTableColumn("NumberByte", AccessDataType.NumberByte);
			Dbs[0].CreateTable("Table_NumberByte", numberByteField);

			AccessTableColumn numberIntegerField = new AccessTableColumn("NumberInteger", AccessDataType.NumberInteger);
			Dbs[0].CreateTable("Table_NumberInteger", numberIntegerField);

			AccessTableColumn numberLongIntegerField = new AccessTableColumn("NumberLongInteger", AccessDataType.NumberLongInteger);
			Dbs[0].CreateTable("Table_NumberLongInteger", numberLongIntegerField);

			AccessTableColumn numericField = new AccessTableColumn("Numeric", AccessDataType.Numeric);
			Dbs[0].CreateTable("Table_Numeric", numericField);

			AccessTableColumn oleField = new AccessTableColumn("Ole", AccessDataType.Ole);
			Dbs[0].CreateTable("Table_Ole", oleField);

			AccessTableColumn textField = new AccessTableColumn("Text", AccessDataType.Text);
			Dbs[0].CreateTable("Table_Text", textField);
		}

		[Test]
		public async Task TEST_CreateTableAsync()
		{
			AccessTableColumn bigBinaryField = new AccessTableColumn("BigBinary", AccessDataType.BigBinary);
			await Dbs[1].CreateTableAsync("Table_BigBinary", bigBinaryField);

			AccessTableColumn binaryField = new AccessTableColumn("Binary", AccessDataType.Binary);
			await Dbs[1].CreateTableAsync("Table_Binary", binaryField);

			AccessTableColumn bitField = new AccessTableColumn("Bit", AccessDataType.Bit);
			await Dbs[1].CreateTableAsync("Table_Bit", bitField);

			AccessTableColumn counterField = new AccessTableColumn("Counter", AccessDataType.Counter);
			await Dbs[1].CreateTableAsync("Table_Counter", counterField);

			AccessTableColumn currencyField = new AccessTableColumn("Currency", AccessDataType.Currency);
			await Dbs[1].CreateTableAsync("Table_Currency", currencyField);

			AccessTableColumn dateTimeField = new AccessTableColumn("DateTime", AccessDataType.DateTime);
			await Dbs[1].CreateTableAsync("Table_DateTime", dateTimeField);

			AccessTableColumn guidField = new AccessTableColumn("Guid", AccessDataType.Guid);
			await Dbs[1].CreateTableAsync("Table_Guid", guidField);

			AccessTableColumn longTextField = new AccessTableColumn("LongText", AccessDataType.LongText);
			await Dbs[1].CreateTableAsync("Table_LongText", longTextField);

			AccessTableColumn numberSingleField = new AccessTableColumn("NumberSingle", AccessDataType.NumberSingle);
			await Dbs[1].CreateTableAsync("Table_NumberSingle", numberSingleField);

			AccessTableColumn numberDoubleField = new AccessTableColumn("NumberDouble", AccessDataType.NumberDouble);
			await Dbs[1].CreateTableAsync("Table_NumberDouble", numberDoubleField);

			AccessTableColumn numberByteField = new AccessTableColumn("NumberByte", AccessDataType.NumberByte);
			await Dbs[1].CreateTableAsync("Table_NumberByte", numberByteField);

			AccessTableColumn numberIntegerField = new AccessTableColumn("NumberInteger", AccessDataType.NumberInteger);
			await Dbs[1].CreateTableAsync("Table_NumberInteger", numberIntegerField);

			AccessTableColumn numberLongIntegerField = new AccessTableColumn("NumberLongInteger", AccessDataType.NumberLongInteger);
			await Dbs[1].CreateTableAsync("Table_NumberLongInteger", numberLongIntegerField);

			AccessTableColumn numericField = new AccessTableColumn("Numeric", AccessDataType.Numeric);
			await Dbs[1].CreateTableAsync("Table_Numeric", numericField);

			AccessTableColumn oleField = new AccessTableColumn("Ole", AccessDataType.Ole);
			await Dbs[1].CreateTableAsync("Table_Ole", oleField);

			AccessTableColumn textField = new AccessTableColumn("Text", AccessDataType.Text);
			await Dbs[1].CreateTableAsync("Table_Text", textField);
		}

		[TearDown]
		public void Cleanup()
		{
			TestUtils.CleanupAccessTesting(DbPaths, Dbs);
		}
	}
}