#region Usings
using System;

using ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.Generators
{
	public class Generators
	{
		#region Refs
		// # ================================================================================================ #
		Debug _Debug = new Debug();
		// # ================================================================================================ #
		#endregion Refs












		#region Generate Password
		// # ================================================================================================ #
		public string GeneratePassword(int _Size, string _Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890")
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
				_Debug.Msg(_Exception.Message, Debug.MsgType.Error, _Exception.Source);
				return null;
			}
		}
		// # ================================================================================================ #
		#endregion Generate Password
	}
}
