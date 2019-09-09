#region Usings
using System;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nTools
{
	public static partial class DatabaseTools
	{
		/// <summary>Removes every unwanted char from the given string so it doesn't break the SQL query.</summary>
		/// <param name="_String">The string to be filtered.</param>
		public static string FilterSql(string _String)
		{
			try
			{
				_String = _String.Replace("'", null);
				_String = _String.Replace(";", null);

				return _String;
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
	}
}
