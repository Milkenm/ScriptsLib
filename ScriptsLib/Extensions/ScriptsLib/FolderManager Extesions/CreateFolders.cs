using ScriptsLib.FolderManager;

using System.Collections.Generic;

namespace ScriptsLib.Extensions.ScriptsLib
{
	public static class FolderManagerExtesions
	{
		/// <summary>Creates all the folders in the array unless they already exist.</summary>
		/// <param name="folders">The array of folders to create.</param>
		public static void CreateFolders(this Folder[] folders)
		{
			foreach (Folder folder in folders)
			{
				folder.CreateFolder();
			}
		}

		/// <summary>Creates all the folders in the list unless they already exist.</summary>
		/// <param name="folders">The list of folders to create.</param>
		public static void CreateFolders(this List<Folder> folders)
		{
			CreateFolders(folders.ToArray());
		}
	}
}
