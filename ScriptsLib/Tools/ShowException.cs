#region Usings
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion Usings

// # = #
// https://stackoverflow.com/questions/3328990/c-sharp-get-line-number-which-threw-exception
// # = #

namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Formats exceptions into a pretty message.</summary>
		/// <param name="_Exception">The exception itself.</param>
		public static async Task ShowException(Exception _Exception)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					MessageBox.Show($"{_Exception.Message}\n\n\n\nLine: {new System.Diagnostics.StackTrace(_Exception, true).GetFrame(0).GetFileLineNumber()}", $"Error - {_Exception.Source}", MessageBoxButtons.OK, MessageBoxIcon.Error);
				});
			}
			catch { }
		}
	}
}
