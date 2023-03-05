using ScriptsLibV2.Databases;

namespace SlTestingV2.Databases
{
	public class TestDatabaseObject : DatabaseObject
	{
		public TestDatabaseObject(IDatabase dbEgine, string tableName) : base(dbEgine, tableName)
		{
		}

		public string Name { get; private set; }

		[Getter("Name")]
		public string GetName()
		{
			return Name;
		}

		[Setter("Name", typeof(string))]
		public void SetName(string name)
		{
			Name = name;
		}
	}
}
