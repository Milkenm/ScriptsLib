#region Usings
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nDatabases
{
	public static partial class SqlServerDatabase
	{
		public static List<string> Select(string _Table, string _Selection = "*", string _Condition = null, string _Splitter = "|,|")
		{
			try
			{
				SqlConnection _Connection = new SqlConnection(_BaseConnection + _DatabasePath);

				SqlCommand _Command;
				if (!string.IsNullOrEmpty(_Condition))
				{
					_Command = new SqlCommand($"SELECT {_Selection} FROM {_Table} WHERE {_Condition}", _Connection);
				}
				else
				{
					_Command = new SqlCommand($"SELECT {_Selection} FROM {_Table}", _Connection);
				}


				List<string> _Results = new List<string>();

				_Connection.Open();
				using (SqlDataReader _Reader = _Command.ExecuteReader())
				{
					bool _While = true;
					while (_While == true)
					{
						if (_Reader.Read() == true)
						{
							Msg("Read.", MsgType.Info, "SqlDataReader.Read()");
							List<string> _Values = new List<string>();
							int _Index = 0;

							try
							{
								while (true)
								{
									_Values.Add(_Reader[_Index].ToString());
									_Index++;
								}
							}
							catch
							{
								string _Add = null;
								foreach (string _Loop in _Values)
								{
									if (string.IsNullOrEmpty(_Add))
									{
										_Add = _Loop;
									}
									else
									{
										_Add = _Add + _Splitter + _Loop;
									}
								}
								Msg("Add: " + _Add, MsgType.Info, "SqlDataReader.Read()");
								_Results.Add(_Add);
							}
						}
						else
						{
							_While = false;
							Msg("Stop.", MsgType.Info, "SqlDataReader.Read()");
						}
					}
				}
				_Connection.Close();

				return _Results;
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
	}
}
