#region Usings
using System;
using System.Security.Cryptography;
using System.Text;
using static ScriptsLib.Dev;
#endregion Usings

// # = #
// https://stackoverflow.com/questions/3984138/hash-string-in-c-sharp
// # = #

namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Converts the given string to SHA-256.</summary>
		/// <param name="_String">The string to be converted.</param>
		public static string Hash(string _String)
		{
			try
			{
				HashAlgorithm _Hash = SHA256.Create();
				StringBuilder _Builder = new StringBuilder();

				foreach (byte _Byte in _Hash.ComputeHash(Encoding.UTF8.GetBytes(_String)))
				{
					_Builder.Append(_Byte.ToString("X2"));
				}

				return _Builder.ToString();
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
	}
}
