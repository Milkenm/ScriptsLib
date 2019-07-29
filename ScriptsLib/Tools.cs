#region Usings
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
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















		#region Database Tools
		/// <summary>Tools to use with databases.</summary>
		public class DatabaseTools : Tools
		{
			/// <summary>Type of database to be used.</summary>
			public enum DatabaseType
			{
				/// <summary>SQL Server.</summary>
				SqlServer,
				/// <summary>Access Database (.mdb).</summary>
				Access,
				/// <summary>MySql.</summary>
				MySql,
			}

			

			#region Check Login
			// # ================================================================================================ #
			/// <summary>Checks if the given user and password exist in the database.</summary>
			/// <param name="_Table">The database table containing the user accounts.</param>
			/// <param name="_Username">The given username to be checked.</param>
			/// <param name="_Password">The given password to be checked.</param>
			/// <param name="_UsernameColumn">The table column containing the usernames.</param>
			/// <param name="_PasswordColumn">The table column containing the passwords.</param>
			/// <param name="_DatabaseType">The type of database to use.</param>
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
			/// <summary>Removes every unwanted char from the given string so it doesn't break the SQL query.</summary>
			/// <param name="_String">The string to be filtered.</param>
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
			/// <summary>From varius values, selectes one of each.</summary>
			/// <param name="_Table">The table to search.</param>
			/// <param name="_Column">The table column to search.</param>
			/// <param name="_DatabaseType">The type of database to use.</param>
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
		#endregion Database Tools



		#region Crash
		// # ================================================================================================ #
		/// <summary>Crashes your application (this is useless no?).</summary>
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
		/// <summary>Converts the given string to SHA-256.</summary>
		/// <param name="_String">The string to be converted.</param>
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
		/// <summary>Logs something to a text file.</summary>
		/// <param name="_Message">The message to log.</param>
		/// <param name="_FileLocation">The location of the text file.</param>
		/// <param name="_Source">The source of the message ([Source] » Message >>> [Main Form] » Something broke).</param>
		/// <param name="_LogType">Info, Error or Warning (only changes the tag displayed on the log file).</param>
		/// <param name="_IncludeDate">Include date and time?</param>
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

		/// <summary>Type of log.</summary>
		public enum LogType
		{
			/// <summary>Info tag.</summary>
			Info,
			/// <summary>Error tag.</summary>
			Error,
			/// <summary>Warning tag.</summary>
			Warning,
		}
		// # ================================================================================================ #
		#endregion Log



		#region Exception
		///
		// https://stackoverflow.com/questions/3328990/c-sharp-get-line-number-which-threw-exception
		///



		// # ================================================================================================ #
		/// <summary>Formats exceptions.</summary>
		/// <param name="_Exception">The exception itself.</param>
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
		/// <summary>Get current time and date. Format: [day]/[month]/[year] - [hour]:[minute]:[second] (.[millisecond])</summary>
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
		/// <summary>Returns true is "this" application is running, else false.</summary>
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



		#region Set Wallpaper
		// # ================================================================================================ #
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
		// # ================================================================================================ #
		/// <summary>Sets the desktop wallpaper.</summary>
		/// <param name="_Image">The image to be set as wallpaper.</param>
		/// <param name="_WallpaperStyle">How the imagem is going to be resized to fit the screen.</param>
		public async Task SetWallpaper(Image _Image, WallpaperStyle _WallpaperStyle)
		{
			await Task.Factory.StartNew(() =>
			{
				string _TempPath = Path.GetTempPath() + @"MWallpaper";
				_Image.Save(_TempPath);

				RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
				if (_WallpaperStyle == WallpaperStyle.Stretched)
				{
					key.SetValue(@"WallpaperStyle", 2.ToString());
					key.SetValue(@"TileWallpaper", 0.ToString());
				}
				if (_WallpaperStyle == WallpaperStyle.Centered)
				{
					key.SetValue(@"WallpaperStyle", 1.ToString());
					key.SetValue(@"TileWallpaper", 0.ToString());
				}
				if (_WallpaperStyle == WallpaperStyle.Tiled)
				{
					key.SetValue(@"WallpaperStyle", 1.ToString());
					key.SetValue(@"TileWallpaper", 1.ToString());
				}

				SystemParametersInfo(20, 0, _TempPath, 0x01 | 0x02);

				File.Delete(_TempPath);
			});
		}
		// # ================================================================================================ #
		/// <summary>Types of wallpaper.</summary>
		public enum WallpaperStyle
		{
			/// <summary>The image is tiled across the screen.</summary>
			Tiled,
			/// <summary>The image is centered on the screen.</summary>
			Centered,
			/// <summary>The image is steched to fit the screen.</summary>
			Stretched,
		}
		// # ================================================================================================ #
		#endregion Set Wallpaper



		#region Get GIF Frames
		// # ================================================================================================ #
		/// <summary>Get frames from a GIF image.</summary>
		/// <param name="_Gif">The GIF image to get the frames from.</param>
		public Image[] GetGifFrames(Image _Gif)
		{
			try
			{
				int _FramesNumber = _Gif.GetFrameCount(FrameDimension.Time);
				Image[] _Frames = new Image[_FramesNumber];

				Task.Factory.StartNew(() =>
				{
					for (int i = 0; i < _FramesNumber; i++)
					{
						_Gif.SelectActiveFrame(FrameDimension.Time, i);
						_Frames[i] = (Image)_Gif.Clone();
					}
				}).GetAwaiter().GetResult();

				return _Frames;
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
		// # ================================================================================================ #
		#endregion Get GIF Frames



		#region Get Text File Content
		// # ================================================================================================ #
		/// <summary>Reads a text file and returns its content in a single string.</summary>
		/// <param name="_Path">The path of the text file.</param>
		public string GetTextFileContent(string _Path)
		{
			try
			{
				if (File.Exists(_Path))
				{
					return String.Join("\n", File.ReadAllLines($@"{_Path}"));
				}
				else
				{
					_Debug.Msg("The file does not exist", MsgType.Error, "GetTextFileContent()");
					return null;
				}
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
		// # ================================================================================================ #
		#endregion Get Text File Content



		#region Replace String
		// # ================================================================================================ #
		/// <summary>Replaces values from a string with new ones.</summary>
		/// <param name="_OriginalString">The string to replace values from.</param>
		/// <param name="_Search">The values to be replaced.</param>
		/// <param name="_Replacement">The value to replace with.</param>
		public string ReplaceString(string _OriginalString, string _Search, string _Replacement)
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
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
		// # ================================================================================================ #
		#endregion Replace String



		#region Execute CMD Command
		// # ================================================================================================ #
		///
		// https://stackoverflow.com/questions/1469764/run-command-prompt-commands
		///

		/// <summary>Executes a command line command.</summary>
		/// <param name="_Command">The command to run.</param>
		public void ExecuteCmdCommand(string _Command)
		{
			try
			{
				Process _Process = new Process();
				ProcessStartInfo _StartInfo = new ProcessStartInfo();
				_StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				_StartInfo.FileName = "cmd.exe";
				_StartInfo.Arguments = $"/C {_Command}";
				_Process.StartInfo = _StartInfo;
				_Process.Start();
			}
			catch (Exception _Exception)
			{
				_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
		// # ================================================================================================ #
		#endregion Execute CMD Command
	}
}