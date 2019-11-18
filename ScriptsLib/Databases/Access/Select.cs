#region Usings
using System;
using System.Collections.Generic;
using System.Data.OleDb;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nDatabases
{
	public static partial class AccessDatabase
	{
		public static List<string> Select(string _Table, string _Selection = "*", string _Condition = null, string _Splitter = "|,|")
		{
			try
			{
				OleDbConnection _OleDbConnection = new OleDbConnection(_BaseConnection + _DatabasePath);

				OleDbCommand _OleDbCommand;
				if (!string.IsNullOrEmpty(_Condition))
				{
					if (_Selection == "*" || _Selection.Contains("MAX"))
					{
						_OleDbCommand = new OleDbCommand($"SELECT {_Selection} FROM [{_Table}] WHERE {_Condition}", _OleDbConnection);
					}
					else
					{
						_OleDbCommand = new OleDbCommand($"SELECT [{_Selection}] FROM [{_Table}] WHERE {_Condition}", _OleDbConnection);
					}
				}
				else
				{
					if (_Selection == "*" || _Selection.Contains("MAX"))
					{
						_OleDbCommand = new OleDbCommand($"SELECT {_Selection} FROM [{_Table}]", _OleDbConnection);
					}
					else
					{
						_OleDbCommand = new OleDbCommand($"SELECT [{_Selection}] FROM [{_Table}]", _OleDbConnection);
					}
				}
				Msg(_OleDbCommand.CommandText, MsgType.Info, "Access Select");


				List<string> _Results = new List<string>();

				_OleDbConnection.Open();
				using (OleDbDataReader _Reader = _OleDbCommand.ExecuteReader())
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
								Msg("Add: " + _Add, MsgType.Info, "OleDbDataReader.Read()");
								if (!string.IsNullOrEmpty(_Add))
								{
									_Results.Add(_Add);
								}
							}
						}
						else
						{
							_While = false;
							Msg("Stop.", MsgType.Info, "OleDbDataReader.Read()");
						}
					}
				}
				_OleDbConnection.Close();

				List<string> _FilterResults = new List<string>();

				foreach (string _Result in _Results)
				{
					if (!string.IsNullOrEmpty(_Result))
					{
						_FilterResults.Add(_Result);
					}
				}

				return _FilterResults;
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
	}
}
