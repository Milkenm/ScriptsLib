using System;
using System.Windows.Forms;

namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Formats exceptions into a pretty message.</summary>
		/// <param name="ex">The exception itself.</param>
		/// https://stackoverflow.com/questions/3328990/c-sharp-get-line-number-which-threw-exception
		public static void ShowException(Exception ex, string messageTitle = null)
		{
			string title = !string.IsNullOrEmpty(messageTitle)
				? messageTitle
				: $"Error - {ex.Source}";

			MessageBox.Show($"{ex.Message}\n\n\n\nLine: {new System.Diagnostics.StackTrace(ex, true).GetFrame(0).GetFileLineNumber()}", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
