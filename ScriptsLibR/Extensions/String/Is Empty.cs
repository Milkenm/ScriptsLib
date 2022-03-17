namespace ScriptsLibR.Extensions
{
	public static class StringExtensions
	{
		public static bool IsEmpty(this string str, bool ignoreSpaces)
		{
			bool isEmpty = string.IsNullOrEmpty(str);
			if (ignoreSpaces)
			{
				isEmpty = string.IsNullOrWhiteSpace(str);
			}
			return isEmpty;
		}

		public static bool IsEmpty(this string str)
		{
			return IsEmpty(str, true);
		}

		public static bool IsEmpty(this string[] strs, bool ignoreSpaces)
		{
			bool isEmpty = true;
			foreach (string str in strs)
			{
				isEmpty = isEmpty && str.IsEmpty(ignoreSpaces);
			}
			return isEmpty;
		}

		public static bool IsEmpty(this string[] strs)
		{
			return IsEmpty(strs, true);
		}
	}
}
