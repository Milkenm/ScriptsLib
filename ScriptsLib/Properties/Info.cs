﻿#region Usings
using System;
#endregion Usings



namespace ScriptsLib
{
	/// <summary>Info about ScriptsLib.</summary>
	public class Info
	{
		// # ================================================================================================ #
		/// <summary>Author of ScriptsLib.</summary>
		public static readonly string Author = "Milkenm";
		/// <summary>ScriptsLib contibutors.</summary>
		public static readonly string Contributors = null;
		/// <summary>Current ScriptsLib version.</summary>
		public static readonly string Version = "6.0.0";
		/// <summary>First release date.</summary>
		public static readonly string ReleaseDate = "30/04/2019 - 21:12";
		/// <summary>Lattest release date.</summary>
		public static readonly string UpdateDate = "30/10/2019 - 12:25";
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