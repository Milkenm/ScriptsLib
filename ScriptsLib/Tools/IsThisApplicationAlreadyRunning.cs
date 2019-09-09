#region Usings
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Returns true is "this" application is running, else false.</summary>
		public static bool IsThisApplicationAlreadyRunning()
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
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return false;
			}
		}
	}
}
