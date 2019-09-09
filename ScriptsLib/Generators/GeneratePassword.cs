#region Usings
using System;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib
{
	public static partial class Generators
	{
		/// <summary>Generates a password (or call it string with random chars).</summary>
		/// <param name="_Size">The amount of characters.</param>
		/// <param name="_Chars">The characters to be used to make the password.</param>
		public static string GeneratePassword(int _Size, string _Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890")
		{
			try
			{
				string _Password = null;
				Random _Random = new Random();
				while (_Size > 0)
				{
					_Size--;
					_Password = $"{_Password}{_Chars[_Random.Next(_Chars.Length)]}";
				}
				return _Password;
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
	}
}
