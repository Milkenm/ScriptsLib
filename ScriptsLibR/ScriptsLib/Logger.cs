using System.IO;

namespace ScriptsLibR
{
	public class Logger
	{
		/// <summary>Easly log to files.</summary>
		/// <param name="logFile">The location of the log file.</param>
		public Logger(string logFile)
		{
			LogFile = logFile;
		}

		public string LogFile { get; }

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
				? Utils.Utils.GetDate("[DD/MM/YYYY - hh:mm:ss]") + " "
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