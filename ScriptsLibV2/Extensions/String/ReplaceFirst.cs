namespace ScriptsLibV2.Extensions
{
	public static partial class StringExtensions
	{
		/// <summary>Replaces the first ocurrence of "find" in "text" with "replace".</summary>
		/// <param name="text">The original text to replace from.</param>
		/// <param name="find">The text to replace.</param>
		/// <param name="replace">The text replacement.</param>
		/// https://stackoverflow.com/a/8809437
		public static string ReplaceFirst(this string text, string find, string replace)
		{
			int pos = text.IndexOf(find);
			if (pos < 0)
			{
				return text;
			}
			return text.Substring(0, pos) + replace + text.Substring(pos + find.Length);
		}
	}
}
