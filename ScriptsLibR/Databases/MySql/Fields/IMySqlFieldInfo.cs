using System.Text;

using ScriptsLibR.Interfaces;
using ScriptsLibR.Util;

namespace ScriptsLibR.Databases.MySql.Types
{
	public abstract class IMySqlFieldInfo<T> : IDatabaseFieldInfo
	{
		public IMySqlFieldInfo(string name, int length, bool isPrimaryKey, bool isNullable, bool isUnique, bool isBinary, bool isUnsigned, bool isZerofill, bool isAutoIncrement, bool isGenerated, T defaultValue, string comment, string characterSet, string collation, string after) : base(name)
		{
			Utils.NullChecker((name, "Name"));

			this.Length = length;
			this.IsPrimaryKey = isPrimaryKey;
			this.IsNullable = isNullable;
			this.IsUnique = isUnique;
			this.IsBinary = isBinary;
			this.IsUnsigned = isUnsigned;
			this.IsZerofill = isZerofill;
			this.IsAutoIncrement = isAutoIncrement;
			this.IsGenerated = isGenerated;
			this.DefaultValue = defaultValue;
			this.Comment = comment;
			this.CharacterSet = characterSet;
			this.Collation = collation;
			this.After = after;
		}

		public int Length { get; }
		public bool IsPrimaryKey { get; }
		public bool IsNullable { get; }
		public bool IsUnique { get; }
		public bool IsBinary { get; }
		public bool IsUnsigned { get; }
		public bool IsZerofill { get; }
		public bool IsAutoIncrement { get; }
		public bool IsGenerated { get; }
		public T DefaultValue { get; }
		public string Comment { get; }
		public string CharacterSet { get; }
		public string Collation { get; }
		public string After { get; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder($"`{this.Name}`");
			return "`a` TINYINT(888) AS ('b') virtual";

			//		`name` INT(99) unsigned zerofill NOT NULL AUTO_INCREMENT COMMENT 'dsad',
			//	PRIMARY KEY(`name`)
		}
	}
}
