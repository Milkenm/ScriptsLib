﻿using System;

using ScriptsLibR.Databases.MySql.Types;

namespace ScriptsLibR.Databases.MySql.Fields.Numeric
{
	public class UnsignedLongField : IMySqlFieldInfo<ulong>
	{
		public UnsignedLongField(string name, ulong length = 1, bool isPrimaryKey = false, bool isNullable = true, bool isUnique = false, bool isZeroFill = false, bool isAutoIncrement = false, bool isGenerated = false, ulong defaultValue = 0, string comment = null, string characterSet = null, string collation = null, string after = null)
			: base(name, length, isPrimaryKey, isNullable, isUnique, false, true, isZeroFill, isAutoIncrement, isGenerated, defaultValue, comment, characterSet, collation, after)
		{
			if (length < ulong.MinValue || length > ulong.MaxValue)
			{
				throw new ArgumentOutOfRangeException(nameof(length), $"Length must be between {ulong.MinValue} and {ulong.MaxValue}.");
			}
		}
	}
}
