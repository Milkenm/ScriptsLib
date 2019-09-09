#region Usings
using System;
using System.Diagnostics;

using static ScriptsLib.Dev;
#endregion Usings

// # = #
// https://stackoverflow.com/questions/1469764/run-command-prompt-commands
// # = #

namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Executes a command line command.</summary>
		/// <param name="_Command">The command to run.</param>
		public static void ExecuteCmdCommand(string _Command)
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
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
	}
}