using System.IO;

using ScriptsLibV2.Util;

namespace ScriptsLibV2
{
	public class Folder
	{
		/// <summary>
		/// Easily create and delete directories.
		/// </summary>
		public Folder() { }

		/// <inheritdoc cref="Folder()"/>
		/// <param name="path">The path to the folder.</param>
		public Folder(string path)
		{
			Path = path;
		}

		/// <inheritdoc cref="Folder(string)"/>
		/// <param name="path"/>
		/// <param name="create"><see langword="true"/> to create the folder if it doesn't already exist.</param>
		public Folder(string path, bool create)
		{
			Path = path;
			if (create)
			{
				CreateFolder();
			}
		}

		/// <summary>
		/// Stores the <see cref="string"/> path to the folder.
		/// </summary>
		/// <returns>Returns the <see cref="string"/> path to the folder.</returns>
		public string Path { get; set; }

		/// <summary>
		/// Override to return the folder name stored in the "Path" variable.
		/// </summary>
		/// <returns>Returns a <see cref="string"/> the path to the folder.</returns>
		public override string ToString()
		{
			return Path;
		}

		/// <summary>
		/// Returns a <see cref="bool"/> based on if the folder exists or not.
		/// </summary>
		/// <returns>Returns <see langword="true"/> if the folder exists, else returns <see langword="false"/>.</returns>
		public bool Exists => Directory.Exists(Path);

		/// <summary>
		/// Creates the folder unless it already exists.
		/// </summary>
		public void CreateFolder()
		{
			if (!Exists)
			{
				Directory.CreateDirectory(Path);
			}
		}

		/// <summary>
		/// Deletes the folder and all the files and other folders inside.
		/// </summary>
		public void DeleteFolder()
		{
			Utils.DeleteDirectory(Path);
		}

		/// <summary>
		/// Gets the <see cref="DirectoryInfo"/> from the current path.
		/// </summary>
		/// <returns>A <see langword="new"/> <see cref="Directory"/> instance based on the current path.</returns>
		public DirectoryInfo GetDirectory()
		{
			return new DirectoryInfo(Path);
		}
	}
}
