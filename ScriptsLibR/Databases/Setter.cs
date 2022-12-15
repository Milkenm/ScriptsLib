using System;

namespace ScriptsLibR.Databases
{
	public class Setter : Attribute
	{
		public Setter(string columnName, Type requiredType)
		{
			ColumnName = columnName;
			RequiredType = requiredType;
		}

		public string ColumnName { get; private set; }
		public Type RequiredType { get; private set; }
	}
}
