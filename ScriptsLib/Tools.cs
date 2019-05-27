#region Usings
using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScriptsLib.Databases;
using ScriptsLib.Dev;

using static ScriptsLib.Dev.Debug;
#endregion Usings



namespace ScriptsLib.Tools
{
	public class Tools
	{
		Debug _Debug = new Debug();









		#region Crash
		// # ================================================================================================ #
		private int _Variable { get; set; }

		public async Task Crash()
		{
			await Task.Factory.StartNew(() =>
			{
				_Variable++;
				Crash().GetAwaiter();
			});
		}
		// # ================================================================================================ #
		#endregion Crash



		#region Check Login
		// # ================================================================================================ #
		public bool CheckLogin(string _Table, string _Username, string _Password, string _UsernameColumn, string _PasswordColumn, DatabaseType _DatabaseType)
		{
			try
			{
				if (_DatabaseType == DatabaseType.SqlServer)
				{
					SqlConnection _Connection = new SqlConnection(SqlServerDatabase._BaseConnection + SqlServerDatabase._DatabasePath);


					SqlCommand _Command = new SqlCommand($"SELECT COUNT(*) FROM {_Table} WHERE {_UsernameColumn} = '{_Username}' AND {_PasswordColumn} = '{_Password}'", _Connection);

					_Connection.OpenAsync().GetAwaiter().GetResult();
					int _Result = Convert.ToInt32(_Command.ExecuteScalarAsync().GetAwaiter().GetResult().ToString());

					_Debug.Msg($"Command: {_Command.CommandText}\n\nResult: {_Result}", MsgType.Info, "CheckLogin");

					_Connection.Close();

					if (_Result > 0)
					{
						return true;
					}
					return false;
				}
				else if (_DatabaseType == DatabaseType.Access)
				{
					OleDbConnection _Connection = new OleDbConnection(AccessDatabase._BaseConnection + AccessDatabase._DatabasePath);


					OleDbCommand _Command = new OleDbCommand($"SELECT COUNT(*) FROM {_Table} WHERE {_UsernameColumn} = '{_Username}' AND {_PasswordColumn} = '{_Password}'", _Connection);

					_Connection.OpenAsync().GetAwaiter().GetResult();
					int _Result = Convert.ToInt32(_Command.ExecuteScalarAsync().GetAwaiter().GetResult().ToString());

					_Debug.Msg($"Command: {_Command.CommandText}\n\nResult: {_Result}", MsgType.Info, "CheckLogin");

					_Connection.Close();

					if (_Result > 0)
					{
						return true;
					}
					return false;
				}
				else
				{
					throw new Exception();
				}
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return false;
			}
		}



		public enum DatabaseType
		{
			SqlServer,
			Access,
		}
		// # ================================================================================================ #
		#endregion Check Login

			

		#region SqlFilter
		// # ================================================================================================ #
		public string SqlFilter(string _String)
		{
			try
			{
				_String = _String.Replace("'", null);
				_String = _String.Replace(";", null);

				return _String;
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
		// # ================================================================================================ #
		#endregion SqlFilter



		#region Hash
		///
		// https://stackoverflow.com/questions/3984138/hash-string-in-c-sharp
		///



		// # ================================================================================================ #
		public string Hash(string _String)
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
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
		// # ================================================================================================ #
		#endregion Hash



		#region Log
		// # ================================================================================================ #
		public async Task Log(string _Message, string _FileLocation, string _Source = null, LogType _LogType = LogType.Info, bool _IncludeDate = true)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					bool _Exists = false;

					#region Create File
					StreamWriter _File;
					if (!File.Exists(_FileLocation))
					{
						_File = File.CreateText(_FileLocation);
					}
					else
					{
						_File = new StreamWriter(_FileLocation, true);
						_Exists = true;
					}
					#endregion Create File

					#region Source / Date
					if (!String.IsNullOrEmpty(_Source))
					{
						_Message = $"[{_Source}] {_Message}";

						if (_IncludeDate == true)
						{
							_Message = $"[{DateTime.Now}]{_Message}";
						}
					}
					else if (_IncludeDate == true)
					{
						_Message = $"[{DateTime.Now}] {_Message}";
					}
					#endregion Source / Date

					#region Log Type
					if (_LogType == LogType.Info)
					{
						_Message = $"[INFO]{_Message}";
					}
					else if (_LogType == LogType.Error)
					{
						_Message = $"[ERROR]{_Message}";
					}
					else if (_LogType == LogType.Warning)
					{
						_Message = $"[WARNING]{_Message}";
					}
					#endregion Log Type



					_Debug.Msg(_Message, MsgType.Info);
					if (_Exists == true)
					{
						_Message = $"\n{_Message}";
					}
					_File.WriteAsync(_Message);
					_File.Close();
				});
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}

		public enum LogType
		{
			Info,
			Error,
			Warning,
		}
		// # ================================================================================================ #
		#endregion Log



		#region Exception
		///
		// https://stackoverflow.com/questions/3328990/c-sharp-get-line-number-which-threw-exception
		///



		// # ================================================================================================ #
		public async Task Exception(Exception _Exception)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					MessageBox.Show($"{_Exception.Message}\n\n\n\nLine: {new System.Diagnostics.StackTrace(_Exception, true).GetFrame(0).GetFileLineNumber()}", $"Error: {_Exception.Source}", MessageBoxButtons.OK, MessageBoxIcon.Error);
				});
			}
			catch { }
		}
		// # ================================================================================================ #
		#endregion Exception
	}
}