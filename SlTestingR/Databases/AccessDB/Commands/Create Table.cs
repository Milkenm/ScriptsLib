using NUnit.Framework;

using ScriptsLibR.Databases;

using System.Threading.Tasks;

namespace SlTestingR.Databases_AccessDB_Tests
{
	internal class CreateTable
	{
		private readonly string[] DbPaths = { @"C:\Dados\TestDB_CreateTable.accdb", @"C:\Dados\TestDB_CreateTableAsync.accdb" };
		private readonly AccessDB[] Dbs = new AccessDB[2];
		private readonly AccessTableColumn[] Columns = { new AccessTableColumn("BigBinary", AccessDataType.BigBinary), new AccessTableColumn("Binary", AccessDataType.Binary), new AccessTableColumn("Bit", AccessDataType.Bit), new AccessTableColumn("Counter", AccessDataType.Counter), new AccessTableColumn("Currency", AccessDataType.Currency), new AccessTableColumn("DateTime", AccessDataType.DateTime), new AccessTableColumn("Guid", AccessDataType.Guid), new AccessTableColumn("LongText", AccessDataType.LongText), new AccessTableColumn("NumberSingle", AccessDataType.NumberSingle), new AccessTableColumn("NumberDouble", AccessDataType.NumberDouble), new AccessTableColumn("NumberByte", AccessDataType.NumberByte), new AccessTableColumn("NumberInteger", AccessDataType.NumberInteger), new AccessTableColumn("NumberLongInteger", AccessDataType.NumberLongInteger), new AccessTableColumn("Numeric", AccessDataType.Numeric), new AccessTableColumn("Ole", AccessDataType.Ole), new AccessTableColumn("Text", AccessDataType.Text) };

		[SetUp]
		public void Setup()
		{
			Dbs[0] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[0]);
			Dbs[1] = new AccessDB(AccessDB.DEFAULT_BASECONNECTION_ACE120 + DbPaths[1]);
		}

		[Test]
		public void TEST_CreateTable()
		{
			Dbs[0].CreateTable("Table_BigBinary", Columns[0]);
			Dbs[0].CreateTable("Table_Binary", Columns[1]);
			Dbs[0].CreateTable("Table_Bit", Columns[2]);
			Dbs[0].CreateTable("Table_Counter", Columns[3]);
			Dbs[0].CreateTable("Table_Currency", Columns[4]);
			Dbs[0].CreateTable("Table_DateTime", Columns[5]);
			Dbs[0].CreateTable("Table_Guid", Columns[6]);
			Dbs[0].CreateTable("Table_LongText", Columns[7]);
			Dbs[0].CreateTable("Table_NumberSingle", Columns[8]);
			Dbs[0].CreateTable("Table_NumberDouble", Columns[9]);
			Dbs[0].CreateTable("Table_NumberByte", Columns[10]);
			Dbs[0].CreateTable("Table_NumberInteger", Columns[11]);
			Dbs[0].CreateTable("Table_NumberLongInteger", Columns[12]);
			Dbs[0].CreateTable("Table_Numeric", Columns[13]);
			Dbs[0].CreateTable("Table_Ole", Columns[14]);
			Dbs[0].CreateTable("Table_Text", Columns[15]);
		}

		[Test]
		public async Task TEST_CreateTableAsync()
		{
			await Dbs[1].CreateTableAsync("Table_BigBinary", Columns[0]);
			await Dbs[1].CreateTableAsync("Table_Binary", Columns[1]);
			await Dbs[1].CreateTableAsync("Table_Bit", Columns[2]);
			await Dbs[1].CreateTableAsync("Table_Counter", Columns[3]);
			await Dbs[1].CreateTableAsync("Table_Currency", Columns[4]);
			await Dbs[1].CreateTableAsync("Table_DateTime", Columns[5]);
			await Dbs[1].CreateTableAsync("Table_Guid", Columns[6]);
			await Dbs[1].CreateTableAsync("Table_LongText", Columns[7]);
			await Dbs[1].CreateTableAsync("Table_NumberSingle", Columns[8]);
			await Dbs[1].CreateTableAsync("Table_NumberDouble", Columns[9]);
			await Dbs[1].CreateTableAsync("Table_NumberByte", Columns[10]);
			await Dbs[1].CreateTableAsync("Table_NumberInteger", Columns[11]);
			await Dbs[1].CreateTableAsync("Table_NumberLongInteger", Columns[12]);
			await Dbs[1].CreateTableAsync("Table_Numeric", Columns[13]);
			await Dbs[1].CreateTableAsync("Table_Ole", Columns[14]);
			await Dbs[1].CreateTableAsync("Table_Text", Columns[15]);
		}

		[TearDown]
		public void Cleanup()
		{
			TestUtils.CleanupAccessTesting(DbPaths, Dbs);
		}
	}
}