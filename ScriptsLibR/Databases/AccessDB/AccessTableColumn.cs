using ScriptsLibR.Interfaces.Abstract;

namespace ScriptsLibR.Databases
{
	public class AccessTableColumn : DatabaseTableColumn<AccessDataType>
	{
		public AccessTableColumn(string name, AccessDataType dataType, bool isPrimaryKey) : base(name, dataType, isPrimaryKey)
		{
			// base()
		}

		public AccessTableColumn(string name, AccessDataType dataType) : base(name, dataType, false)
		{
			// base()
		}

		public AccessTableColumn(string name, bool isPrimaryKey) : base(name, AccessDataType.Counter, isPrimaryKey)
		{
			// base()
		}

		public AccessTableColumn(string name) : base(name, AccessDataType.Counter, false)
		{
			// base()
		}
	}

	public enum AccessDataType
	{
		BigBinary,
		Binary,
		Bit,
		Counter,
		Currency,
		DateTime,
		Guid,
		LongText,
		NumberSingle,
		NumberDouble,
		NumberByte,
		NumberInteger,
		NumberLongInteger,
		Numeric,
		Ole,
		Text
	}
}