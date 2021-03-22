using System;

namespace ScriptsLib
{
	/// <summary>Info about ScriptsLib.</summary>
	public static class Info
	{
		// # ================================================================================================ #
		/// <summary>Author of ScriptsLib.</summary>
		public static readonly string Author = "Milkenm";

		/// <summary>ScriptsLib contibutors.</summary>
		public static readonly string Contributors;

		/// <summary>Current ScriptsLib version.</summary>
		public static readonly string Version = "7.1.1";

		/// <summary>First release date.</summary>
		public static readonly string ReleaseDate = "30/04/2019 - 21:12";

		/// <summary>Lattest release date.</summary>
		public static readonly string LatestUpdateDate = "22/03/2021 - 02:29";

		// # ================================================================================================ #
		/// <summary>AppData Path.</summary>
		internal static readonly string AppdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Milkenm\ScriptsLib\";

		/// <summary>AppData Temp Path.</summary>
		internal static readonly string TempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Milkenm\ScriptsLib\Temp\";

		/// <summary>AppData User Data Path.</summary>
		internal static readonly string UserdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Milkenm\ScriptsLib\UserData\";

		// # ================================================================================================ #
	}
}