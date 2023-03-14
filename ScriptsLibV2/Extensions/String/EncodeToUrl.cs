using System.Text;

namespace ScriptsLibV2.Extensions
{
	public static partial class StringExtensions
	{
		// https://stackoverflow.com/questions/6421950/is-there-a-tutorial-on-how-to-implement-google-authenticator-in-net-apps
		public static string EncodeToUrl(this string value)
		{
			const string urlEncodeAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";

			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < value.Length; i++)
			{
				char c = value[i];

				if (urlEncodeAlphabet.IndexOf(c) != -1)
				{
					sb.Append(c);
				}
				else
				{
					sb.Append('%');
					sb.Append(((int)c).ToString("X2"));
				}
			}

			return sb.ToString();
		}
	}
}
