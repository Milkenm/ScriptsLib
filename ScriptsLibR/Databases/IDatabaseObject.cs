using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptsLibR.Databases
{
	public abstract class IDatabaseObject
	{
		private DatabaseType databaseType;
		private IDatabaseConnectionInfo connectionInfo;

		public IDatabaseObject(DatabaseType databaseType, IDatabaseConnectionInfo connectionInfo)
		{
			this.databaseType = databaseType;
			this.connectionInfo = connectionInfo;

		}
	}
}
