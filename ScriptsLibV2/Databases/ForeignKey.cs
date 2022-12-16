using System;

namespace ScriptsLibV2.Databases
{
	public class ForeignKey : Attribute
	{
		public string Table { get; private set; }
		public string ColumnName { get; private set; }

		public ForeignKey(string table, string columnName)
		{
			Table = table;
			ColumnName = columnName;
		}
	}
}
