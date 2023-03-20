using System;

namespace ScriptsLibV2.Properties
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
        public static readonly string Version = "8.0.0-pre3";

        /// <summary>First release date.</summary>
        public static readonly string ReleaseDate = "30/04/2019 - 21:12";

        /// <summary>Lattest release date.</summary>
        public static readonly string LatestUpdateDate = "20/03/2023 - 12:05";

        // # ================================================================================================ #

        /// <summary>AppData Path.</summary>
        public static readonly string AppdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Milkenm\ScriptsLib\";

        /// <summary>AppData Temp Path.</summary>
        public static readonly string TempPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Milkenm\ScriptsLib\Temp\";

        /// <summary>AppData User Data Path.</summary>
        public static readonly string UserdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Milkenm\ScriptsLib\UserData\";

        // # ================================================================================================ #
    }
}