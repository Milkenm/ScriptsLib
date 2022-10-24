
using System;

using ScriptsLibR.Util;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		public class BitColumn : MySqlColumn
		{
			public BitColumn(string name, int length = 1, bool isNullable = true, int defaultValue = 0, string comment = null) : base(name, MySqlDataType.Bit, length, false, isNullable, false, "b'" + defaultValue + "'", comment, null)
			{
				Utils.NullChecker((name, nameof(name)));

				if (length < 1 || length > 64)
				{
					throw new ArgumentOutOfRangeException(nameof(length), "Length must be between 1 and 64.");
				}
			}

			public string Name => base.Name;
			public int BitsPerValue => base.Length;
			public bool IsNullable => base.IsNullable;
			public int DefaultValue => (int)base.DefaultValue;
			public string Comment => base.Comment;
		}
	}
}