namespace ScriptsLibR.Interfaces
{
	public interface IDatabaseTableColumn
	{
		dynamic DataType { get; }
		bool IsPrimaryKey { get; }
		string Name { get; }

		string ToString();
	}
}