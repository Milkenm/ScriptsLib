using System.IO;

namespace ScriptsLibR.Utils
{
	public static partial class Utils
	{
		/// <summary>Completly deletes a directory. including all files and folders inside of it.</summary>
		/// <param name="directoryPath"></param>
		public static void DeleteDirectory(string directoryPath) // https://stackoverflow.com/a/329502
		{
			string[] files = Directory.GetFiles(directoryPath);
			string[] dirs = Directory.GetDirectories(directoryPath);

			foreach (string file in files)
			{
				File.SetAttributes(file, FileAttributes.Normal);
				File.Delete(file);
			}

			foreach (string dir in dirs)
			{
				DeleteDirectory(dir);
			}

			Directory.Delete(directoryPath, false);
		}
	}
}
