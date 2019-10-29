#region Usings
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlMessageBox
	{
		/// <summary>Shows a MessageBox with yes and no options.</summary>
		/// <param name="_Title">The title of the confirmation dialog.</param>
		/// <param name="_Message">The message to be displayed in the confirmation dialog.</param>
		/// <param name="_Icon">Icon of the confirmation dialog.</param>
		public static bool ShowConfirmationDialog(string _Title, string _Message, MessageBoxIcon? _Icon = null)
		{
			DialogResult _Dialog;

			if (_Icon != null)
			{
				_Dialog = MessageBox.Show(_Message, _Title, MessageBoxButtons.YesNo, (MessageBoxIcon)_Icon);
			}
			else
			{
				_Dialog = MessageBox.Show(_Message, _Title, MessageBoxButtons.YesNo);
			}

			if (_Dialog == DialogResult.Yes)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
