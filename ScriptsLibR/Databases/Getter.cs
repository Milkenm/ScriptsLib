using System;

namespace ScriptsLibR.Databases
{
	public class Getter : Attribute
	{
		public string ColumnName { get; private set; }

		public Getter(string columnName)
		{
			ColumnName = columnName;
		}
	}
}
