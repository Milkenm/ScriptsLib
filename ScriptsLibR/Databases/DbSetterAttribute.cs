using System;

namespace ScriptsLibR.Databases
{
	public class DbSetter : Attribute
	{
		public string ColumnName { get; set; }
		public Type RequiredType { get; set; }
	}
}
