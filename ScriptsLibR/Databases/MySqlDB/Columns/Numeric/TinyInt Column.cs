
using System;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		public class TinyIntColumn : MySqlColumn
		{
			public TinyIntColumn(string name, int length = 1, bool isUnsigned = false, bool isNullable = true, bool doZerofill = false, int defaultValue = 0, string comment = null) : base(name, MySqlDataType.Bit, length, isUnsigned, isNullable, doZerofill, "b'" + defaultValue + "'", comment, null, null, null)
			{
				if (length < 1 || length > 255)
				{
					throw new ArgumentOutOfRangeException(nameof(length), "Length must be between 1 and 255");
				}
			}

			public string Name => base.Name;
			public int MaximumSize => base.Length;
			public bool IsUnsigned => base.IsUnsigned;
			public bool IsNullable => base.IsNullable;
			public bool DoZerofill => base.DoZerofill;
			public int DefaultValue => (int)base.DefaultValue;
			public string Comment => base.Comment;
		}
	}
}