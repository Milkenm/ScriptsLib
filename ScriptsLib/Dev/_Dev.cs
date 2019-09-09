#region Usings
using System;
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib
{
	/// <summary>Debug tools.</summary>
	public static partial class Dev
	{
		/// <summary>Enables or disabled debug mode.</summary>
		public static bool _Debug { get; set; }

		/// <summary>Hide info messages if debug mode is on?</summary>
		public static bool _ErrorsOnly { get; set; }
	}
}
