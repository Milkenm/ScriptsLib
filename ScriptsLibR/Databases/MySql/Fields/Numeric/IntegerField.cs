
using System;

using ScriptsLibR.Databases.MySql.Types;

namespace ScriptsLibR.Databases.MySql.Fields.Numeric
{
	public class IntegerField : IMySqlFieldInfo<int>
	{
		/// <summary>
		/// A normal-size integer. The signed range is -2147483648 to 2147483647. The unsigned range is 0 to 4294967295.
		/// </summary>
		public IntegerField(string name, int length = 1, bool isPrimaryKey = false, bool isNullable = true, bool isUnique = false, bool isUnsigned = false, bool isZeroFill = false, bool isAutoIncrement = false, bool isGenerated = false, int defaultValue = 0, string comment = null, string characterSet = null, string collation = null, string after = null)
			: base(name, length, isPrimaryKey, isNullable, isUnique, false, (isZeroFill || isUnsigned), isZeroFill, isAutoIncrement, isGenerated, defaultValue, comment, characterSet, collation, after)
		{
			if (!(isZeroFill || isUnsigned) && (length < -2147483648 || length > 2147483647))
			{
				throw new ArgumentOutOfRangeException(nameof(length), "Length must be between -2147483648 and 2147483647.");
			}
			else if ((isZeroFill || isUnsigned) && (length < 0 || length > 4294967295))
			{
				throw new ArgumentOutOfRangeException(nameof(length), "Length must be between 0 and 4294967295.");
			}
		}
	}
}
