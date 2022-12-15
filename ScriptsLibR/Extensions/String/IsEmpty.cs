namespace ScriptsLibR.Extensions
{
	public static partial class StringExtensions
	{
		public static bool IsEmpty(this string @string, bool ignoreSpaces)
		{
			bool isEmpty = string.IsNullOrEmpty(@string);
			if (ignoreSpaces)
			{
				isEmpty = string.IsNullOrWhiteSpace(@string);
			}
			return isEmpty;
		}

		public static bool IsEmpty(this string @string)
		{
			return IsEmpty(@string, true);
		}

		public static bool IsEmpty(this string[] strings, bool ignoreSpaces)
		{
			bool isEmpty = true;
			foreach (string str in strings)
			{
				isEmpty = isEmpty && str.IsEmpty(ignoreSpaces);
			}
			return isEmpty;
		}

		public static bool IsEmpty(this string[] strings)
		{
			return IsEmpty(strings, true);
		}
	}
}
