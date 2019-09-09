#region Usings
using System;
using System.Text.RegularExpressions;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>[WIP] Replaces values from a string with new ones.</summary>
		/// <param name="_OriginalString">The string to replace values from.</param>
		/// <param name="_Search">The values to be replaced.</param>
		/// <param name="_Replacement">The value to replace with.</param>
		public static string ReplaceString(string _OriginalString, string _Search, string _Replacement)
		{
			try
			{
				if (!String.IsNullOrEmpty(_OriginalString))
				{
					return new Regex($@"{_Search}").Replace(_OriginalString, _Replacement);
				}
				else
				{
					throw new Exception("The provided string is empty.");
				}
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
	}
}