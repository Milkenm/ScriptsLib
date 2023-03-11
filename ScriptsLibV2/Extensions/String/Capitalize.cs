using System.Collections.Generic;

namespace ScriptsLibV2.Extensions
{
	public static partial class StringExtensions
	{
		public static string Capitalize(this string text)
		{
			string[] split = text.Split(' ');
			List<string> result = new List<string>();
			foreach (string s in split)
			{
				string firstLetter = s[0].ToString().ToUpper();
				string rest = s.Substring(1, s.Length - 1).ToLower();
				result.Add(string.Concat(firstLetter, rest));
			}
			return string.Join(" ", result);
		}
	}
}
