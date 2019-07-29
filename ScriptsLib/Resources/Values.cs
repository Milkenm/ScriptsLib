#region Usings
using System;
#endregion Usings



namespace ScriptsLib.Resources
{
	internal class Values
	{
		// Gets and stores the AppData folder path.
		internal readonly string _AppdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Milkenm\ScriptsLib\";
	}
}
