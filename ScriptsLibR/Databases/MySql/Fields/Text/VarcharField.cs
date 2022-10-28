using System;

namespace ScriptsLibR.Databases.MySql.Types
{
	public class VarcharField : IMySqlFieldInfo<string>
	{
		public VarcharField(string name, int length = 1, bool isPrimaryKey = false, bool isNullable = true, bool isUnique = false, bool isBinary = false, bool isUnsigned = false, bool isZerofill = false, bool isAutoIncrement = false, bool isGenerated = false, string defaultValue = "", string comment = null, string characterSet = null, string collation = null, string after = null)
			: base(name, length, isPrimaryKey, isNullable, isUnique, isBinary, isUnsigned, isZerofill, isAutoIncrement, isGenerated, defaultValue, comment, characterSet, collation, after)
		{
			if (length < 0 || length > 16383)
			{
				throw new ArgumentOutOfRangeException(nameof(length), "Length must be between 0 and 16383");
			}
		}
	}
}