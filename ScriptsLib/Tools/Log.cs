#region Usings
using System;
using System.IO;
using System.Threading.Tasks;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Logs something to a text file.</summary>
		/// <param name="_Message">The message to log.</param>
		/// <param name="_FileLocation">The location of the text file.</param>
		/// <param name="_Source">The source of the message ([Source] » Message >>> [Main Form] » Something broke).</param>
		/// <param name="_LogType">Info, Error or Warning (only changes the tag displayed on the log file).</param>
		/// <param name="_IncludeDate">Include date and time?</param>
		public static async Task Log(string _Message, string _FileLocation, string _Source = null, LogType _LogType = LogType.Info, bool _IncludeDate = true)
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



					Msg(_Message, MsgType.Info);
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
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}


		#region Enums
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
		#endregion Enums
	}
}
