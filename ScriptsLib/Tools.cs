#region Usings
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using ScriptsLib.Databases;

using static ScriptsLib.Dev.Debug;
#endregion Usings



namespace ScriptsLib.Tools
{
	public class Tools
	{
		#region Refs
		Dev.Debug _Debug = new Dev.Debug();
		AccessDatabase _AccessDatabase = new AccessDatabase();
		#endregion Refs





		public class DatabaseTools : Tools
		{
			public enum DatabaseType
			{
				SqlServer,
				Access,
				MySql,
			}


			





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
						throw new Exception("Selected database type not supported.");
					}
				}
				catch (Exception _Exception)
				{
					_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
					return false;
				}
			}




			// # ================================================================================================ #
			#endregion Check Login



			#region Filter SQL
			// # ================================================================================================ #
			public string FilterSql(string _String)
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
			#endregion Filter SQL



			#region Select Unique
			// # ================================================================================================ #
			public List<string> SelectUnique(string _Table, string _Column, DatabaseType _DatabaseType)
			{
				try
				{
					List<string> _UniqueValues = new List<string>();

					if (_DatabaseType == DatabaseType.Access)
					{
						foreach (string _Value in _AccessDatabase.Select(_Table, _Column))
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
					_Debug.Msg(_Exception.Message, MsgType.Error, "Hehe");
					return null;
				}
			}
			// # ================================================================================================ #
			#endregion Select Unique
		}



		#region Crash
		// # ================================================================================================ #
		public async Task Crash()
		{
			await Crash();
		}
		// # ================================================================================================ #
		#endregion Crash

			

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
					MessageBox.Show($"{_Exception.Message}\n\n\n\nLine: {new System.Diagnostics.StackTrace(_Exception, true).GetFrame(0).GetFileLineNumber()}", $"Error - {_Exception.Source}", MessageBoxButtons.OK, MessageBoxIcon.Error);
				});
			}
			catch { }
		}
		// # ================================================================================================ #
		#endregion Exception



		#region Get Date
		// # ================================================================================================ #
		public string GetDate()
		{
			string _Day = DateTime.Now.Day.ToString(), _Month = DateTime.Now.Month.ToString(), _Year = DateTime.Now.Year.ToString(), _Hour = DateTime.Now.Hour.ToString(), _Minute = DateTime.Now.Minute.ToString(), _Second = DateTime.Now.Second.ToString(), _Millisecond = DateTime.Now.Millisecond.ToString();

			if (_Day.Length < 2)
			{
				_Day = 0 + _Day;
			}
			if (_Month.Length < 2)
			{
				_Month = 0 + _Month;
			}
			if (_Hour.Length < 2)
			{
				_Hour = 0 + _Hour;
			}
			if (_Minute.Length < 2)
			{
				_Minute = 0 + _Minute;
			}
			if (_Second.Length < 2)
			{
				_Second = 0 + _Second;
			}

			if (_Millisecond.Length < 2)
			{
				_Millisecond = 00 + _Millisecond;
			}
			else if (_Millisecond.Length < 3)
			{
				_Millisecond = 0 + _Millisecond;
			}



			return $"{_Day}/{_Month}/{_Year} - {_Hour}:{_Minute}:{_Second} (.{_Millisecond})";
		}
		// # ================================================================================================ #
		#endregion Get Date



		#region Is Application Running
		// # ================================================================================================ #
		public bool? IsApplicationRunning()
		{
			try
			{
				Regex _Regex = new Regex(".exe");
				int _Instances = 0;
				foreach (Process _Process in Process.GetProcessesByName(_Regex.Replace(AppDomain.CurrentDomain.FriendlyName, "")))
				{
					_Instances++;
				}

				if (_Instances <= 1)
				{
					return false;
				}
				return true;
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
		// # ================================================================================================ #
		#endregion Is Application Running



		#region SetWallpaper
		// # ================================================================================================ #
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
		// # ================================================================================================ #
		public async Task SetWallpaper(Image _Image, Style _Style)
		{
			await Task.Factory.StartNew(() =>
			{
				string _TempPath = Path.GetTempPath() + @"MWallpaper";
				_Image.Save(_TempPath);

				RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
				if (_Style == Style.Stretched)
				{
					key.SetValue(@"WallpaperStyle", 2.ToString());
					key.SetValue(@"TileWallpaper", 0.ToString());
				}
				if (_Style == Style.Centered)
				{
					key.SetValue(@"WallpaperStyle", 1.ToString());
					key.SetValue(@"TileWallpaper", 0.ToString());
				}
				if (_Style == Style.Tiled)
				{
					key.SetValue(@"WallpaperStyle", 1.ToString());
					key.SetValue(@"TileWallpaper", 1.ToString());
				}

				SystemParametersInfo(20, 0, _TempPath, 0x01 | 0x02);

				File.Delete(_TempPath);
			});
		}
		// # ================================================================================================ #
		public enum Style
		{
			Tiled,
			Centered,
			Stretched,
		}
		// # ================================================================================================ #
		#endregion SetWallpaper
	}
}