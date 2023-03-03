using System.Text;

namespace ScriptsLibV2.Extensions
{
	public static partial class StringBuilderExtensions
	{
		public static void AddJoiner(this StringBuilder sb, string joiner)
		{
			for (int i = sb.Length - 2; i > 0; i--)
			{
				sb.Append(joiner, i, joiner.Length);
			}
		}
	}
}
