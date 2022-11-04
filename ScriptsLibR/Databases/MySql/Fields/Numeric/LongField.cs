using System;

using ScriptsLibR.Databases.MySql.Types;

namespace ScriptsLibR.Databases.MySql.Fields.Numeric
{
	public class LongField : IMySqlFieldInfo<long>
	{
		public LongField(string name, long length = 1, bool isPrimaryKey = false, bool isNullable = true, bool isUnique = false, bool isZeroFill = false, bool isAutoIncrement = false, bool isGenerated = false, long defaultValue = 0, string comment = null, string characterSet = null, string collation = null, string after = null)
			: base(name, length, isPrimaryKey, isNullable, isUnique, false, false, isZeroFill, isAutoIncrement, isGenerated, defaultValue, comment, characterSet, collation, after)
		{
			if (length < long.MinValue || length > long.MaxValue)
			{
				throw new ArgumentOutOfRangeException(nameof(length), $"Length must be between {long.MinValue} and {long.MaxValue}.");
			}
		}
	}
}
