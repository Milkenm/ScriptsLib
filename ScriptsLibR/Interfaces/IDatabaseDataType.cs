﻿namespace ScriptsLibR.Interfaces
{
	public abstract class IDatabaseDataType
	{
		public string Name { get; private set; }

		public IDatabaseDataType(string name)
		{
			this.Name = name;
		}

		public abstract override string ToString();
	}
}
