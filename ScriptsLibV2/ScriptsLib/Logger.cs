﻿using System.IO;

namespace ScriptsLibV2
{
	/// <summary>Type of log.</summary>
	public enum LogType
	{
		/// <summary>Info tag.</summary>
		Info,

		/// <summary>Error tag.</summary>
		Error,

		/// <summary>Warning tag.</summary>
		Warning,

		/// <summary>Debug tag.</summary>
		Debug,
	}

	public class Logger
	{
		/// <summary>Easly log to files.</summary>
		/// <param name="logFile">The location of the log file.</param>
		public Logger(string logFile)
		{
			LogFile = logFile;
		}

		public string LogFile { get; }

		/// <summary>Logs something to a log file.</summary>
		/// <param name="tag">Tag string.</param>
		/// <param name="message">The message to log.</param>
		/// <param name="printDateTime">Include date and time?</param>
		public void Log(string tag, string message, bool printDateTime = true)
		{
			if (!File.Exists(LogFile))
			{
				File.Create(LogFile);
			}

			string dateTime = printDateTime
				? Util.Utils.GetDate("[DD/MM/YYYY - hh:mm:ss]") + " "
				: null;

			File.WriteAllText(LogFile, $"{dateTime}[{tag.ToUpper()}] {message}");
		}

		/// <summary>Logs something to a log file.</summary>
		/// <param name="tag">Info, Error, Warning or Debug (only changes the tag displayed on the log file).</param>
		/// <param name="message">The message to log.</param>
		/// <param name="printDateTime">Include date and time?</param>
		public void Log(LogType tag, string message, bool printDateTime = true)
		{
			Log(tag.ToString(), message, printDateTime);
		}
	}
}