using System;

using ScriptsLibR.Interfaces;

namespace ScriptsLibR.Databases
{
	public partial class MySqlDB
	{
		public class TextColumn : MySqlColumn
		{
			public TextColumn(string name, int length = 1, bool isUnsigned = false, bool isNullable = true, bool doZerofill = false, int defaultValue = 0, string comment = null) : base(name, MySqlDataType.Bit, length, false, isNullable, false, "b'" + defaultValue + "'", comment, null)
			{
				if (length < 1 || length > 255)
				{
					throw new ArgumentOutOfRangeException(nameof(length), "Length must be between 1 and 255");
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