using System;

using ScriptsLibR.Databases.MySql.Types;

namespace ScriptsLibR.Databases.MySql.Fields.Numeric
{
	public class ByteField : IMySqlFieldInfo<sbyte>
	{
		public ByteField(string name, sbyte length = 1, bool isPrimaryKey = false, bool isNullable = true, bool isUnique = false, bool isZeroFill = false, bool isAutoIncrement = false, bool isGenerated = false, sbyte defaultValue = 0, string comment = null, string characterSet = null, string collation = null, string after = null)
			: base(name, length, isPrimaryKey, isNullable, isUnique, false, false, isZeroFill, isAutoIncrement, isGenerated, defaultValue, comment, characterSet, collation, after)
		{
			if (length < sbyte.MinValue || length > sbyte.MaxValue)
			{
				throw new ArgumentOutOfRangeException(nameof(length), $"Length must be between {sbyte.MinValue} and {sbyte.MaxValue}.");
			}
		}
	}
}
