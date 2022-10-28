using System;

using ScriptsLibR.Databases.Access.Types;
using ScriptsLibR.Interfaces;

namespace ScriptsLibR.Databases
{
	public class AccessTableColumn : IDatabaseFieldInfo
	{
		public AccessTableColumn(string name, AccessDataType dataType, bool isPrimaryKey) : base(name)
		{
			// base()
		}

		public AccessTableColumn(string name, AccessDataType dataType) : base(name)
		{
			// base()
		}

		public AccessTableColumn(string name, bool isPrimaryKey) : base(name)
		{
			// base()
		}

		public AccessTableColumn(string name) : base(name)
		{
			// base()
		}

		public override string ToString()
		{
			throw new NotImplementedException();
		}
	}
}