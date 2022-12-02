using System;

namespace ScriptsLibR.Databases
{
	public class DbGetter : Attribute
	{
		public string ColumnName { get; set; }
	}
}
