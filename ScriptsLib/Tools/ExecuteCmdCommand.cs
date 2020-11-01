using System.Diagnostics;

namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Executes a command line command.</summary>
		/// <param name="command">The command to run.</param>
		/// https://stackoverflow.com/a/1469790
		public static void ExecuteCmdCommand(string command)
		{
			Process p = new Process();
			p.StartInfo = new ProcessStartInfo()
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "cmd.exe",
				Arguments = $"/C {command}",
			};
			p.Start();
		}
	}
}