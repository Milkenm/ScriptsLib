#region Usings
using System;
using System.Collections.Generic;

using ScriptsLib.Databases;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nTools
{
	public static partial class DatabaseTools
	{
		/// <summary>From varius values, selectes one of each.</summary>
		/// <param name="_Table">The table to search.</param>
		/// <param name="_Column">The table column to search.</param>
		/// <param name="_DatabaseType">The type of database to use.</param>
		public static List<string> SelectUnique(string _Table, string _Column, DatabaseType _DatabaseType)
		{
			try
			{
				List<string> _UniqueValues = new List<string>();

				if (_DatabaseType == DatabaseType.Access)
				{
					foreach (string _Value in AccessDatabase.Select(_Table, _Column))
					{
						if (!_UniqueValues.Contains(_Value))
						{
							_UniqueValues.Add(_Value);
						}
					}
				}
				else
				{
					throw new Exception("Selected database type not supported.");
				}

				return _UniqueValues;
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, "Hehe");
				return null;
			}
		}
	}
}
