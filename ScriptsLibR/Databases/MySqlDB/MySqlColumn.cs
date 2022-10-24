using System.Text;
using System.Xml.Linq;

using ScriptsLibR.Util;

namespace ScriptsLibR.Databases
{
	public abstract class MySqlColumn
	{
		public MySqlColumn(string name, MySqlDataType dataType, int length, bool isUnsigned, bool isNullable, bool doZerofill, object defaultValue, string comment, string collation)
		{
			Utils.NullChecker((name, nameof(name)), (dataType, nameof(dataType)));

			this.Name = name;
			this.DataType = dataType;
			this.Length = length;
			this.IsUnsigned = isUnsigned;
			this.IsNullable = isNullable;
			this.DoZerofill = doZerofill;
			this.DefaultValue = defaultValue;
			this.Comment = comment;
			this.Collation = collation;
		}

		public string Name { get; }
		public MySqlDataType DataType { get; }
		public int Length { get; }
		public bool IsUnsigned { get; }
		public bool IsNullable { get; }
		public bool DoZerofill { get; }
		public object DefaultValue { get; }
		public string Comment { get; }
		public string Collation { get; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder($"`{Name}`");
			return "`a` TINYINT(888) AS ('b') virtual"
				
		//		`name` INT(99) unsigned zerofill NOT NULL AUTO_INCREMENT COMMENT 'dsad',
			//	PRIMARY KEY(`name`)
		}
	}
}
