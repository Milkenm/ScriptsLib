using System.ComponentModel;
using System.Text;

namespace ScriptsLibR.Databases.AccessDB
{
	public class AccessTableColumn
	{
		public AccessTableColumn(string name, AccessDataType dataType, bool isPrimaryKey)
		{
			this.Name = name;
			this.DataType = dataType;
			this.IsPrimaryKey = isPrimaryKey;
		}

		public AccessTableColumn(string name, AccessDataType dataType)
		{
			this.Name = name;
			this.DataType = dataType;
			this.IsPrimaryKey = false;
		}

		public AccessTableColumn(string name, bool isPrimaryKey)
		{
			this.Name = name;
			this.DataType = AccessDataType.Counter;
			this.IsPrimaryKey = this.IsPrimaryKey;
		}

		public AccessTableColumn(string name)
		{
			this.Name = name;
			this.DataType = AccessDataType.Counter;
			this.IsPrimaryKey = false;
		}

		public string Name { get; }
		public AccessDataType DataType { get; }
		public bool IsPrimaryKey { get; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder($"[{this.Name}]");

			string dataType = this.DataType switch
			{
				AccessDataType.BigBinary => "BIGBINARY",
				AccessDataType.Binary => "BINARY",
				AccessDataType.Bit => "BIT",
				AccessDataType.Counter => "COUNTER",
				AccessDataType.Currency => "CURRENCY",
				AccessDataType.DateTime => "DATE",
				AccessDataType.Guid => "GUID",
				AccessDataType.LongText => "LONGTEXT",
				AccessDataType.NumberSingle => "SINGLE",
				AccessDataType.NumberDouble => "DOUBLE",
				AccessDataType.NumberByte => "BYTE",
				AccessDataType.NumberInteger => "SHORT",
				AccessDataType.NumberLongInteger => "LONG",
				AccessDataType.Numeric => "NUMERIC",
				AccessDataType.Ole => "LONGBINARY",
				AccessDataType.Text => "TEXT",
				_ => throw new InvalidEnumArgumentException($"Invalid \"DataType\": '{this.DataType}'."),
			};
			sb.Append($" {dataType}");

			if (this.IsPrimaryKey)
			{
				sb.Append(" PRIMARY KEY");
			}
			return sb.ToString();
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
