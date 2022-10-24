namespace ScriptsLibR.Interfaces
{
	public interface IDatabaseTableColumn<T>
	{
		string Name { get; }
		T DataType { get; }
		bool IsPrimaryKey { get; }

		string ToString();
	}
}