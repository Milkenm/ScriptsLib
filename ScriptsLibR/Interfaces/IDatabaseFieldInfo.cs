namespace ScriptsLibR.Interfaces
{
	public abstract class IDatabaseFieldInfo
	{
		public string Name { get; private set; }

		public IDatabaseFieldInfo(string name)
		{
			this.Name = name;
		}

		public abstract override string ToString();
	}
}