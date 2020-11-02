using System.Security.Cryptography;
using System.Text;

namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Converts the given string to SHA-256.</summary>
		/// <param name="str">The string to be hashed.</param>
		/// https://stackoverflow.com/questions/3984138/hash-string-in-c-sharp
		public static string Hash(string str)
		{
			HashAlgorithm ha = SHA256.Create();
			StringBuilder sb = new StringBuilder();

			foreach (byte b in ha.ComputeHash(Encoding.UTF8.GetBytes(str)))
			{
				sb.Append(b.ToString("X2"));
			}

			return sb.ToString();
		}
	}
}
