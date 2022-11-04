﻿using System;

using ScriptsLibR.Databases.MySql.Types;

namespace ScriptsLibR.Databases.MySql.Fields.Numeric
{
	public class ShortField : IMySqlFieldInfo<short>
	{
		public ShortField(string name, short length = 1, bool isPrimaryKey = false, bool isNullable = true, bool isUnique = false, bool isZeroFill = false, bool isAutoIncrement = false, bool isGenerated = false, short defaultValue = 0, string comment = null, string characterSet = null, string collation = null, string after = null)
			: base(name, length, isPrimaryKey, isNullable, isUnique, false, false, isZeroFill, isAutoIncrement, isGenerated, defaultValue, comment, characterSet, collation, after)
		{
			if (length < short.MinValue || length > short.MaxValue)
			{
				throw new ArgumentOutOfRangeException(nameof(length), $"Length must be between {short.MinValue} and {short.MaxValue}.");
			}
		}
	}
}
