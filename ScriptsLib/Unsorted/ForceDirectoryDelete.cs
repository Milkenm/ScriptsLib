using System.IO;

namespace ScriptsLib.Unsorted
{
	public static partial class Unsorted
	{
		/// <summary>Completly deletes a directory. including all files and folders inside of it.</summary>
		/// <param name="directoryPath"></param>
		public static void ForceDirectoryDelete(string directoryPath) // https://stackoverflow.com/a/329502
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
				ForceDirectoryDelete(dir);
			}

			Directory.Delete(directoryPath, false);
		}
	}
}
