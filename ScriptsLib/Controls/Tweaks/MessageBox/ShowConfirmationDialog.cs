using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlMessageBox
	{
		/// <summary>Shows a MessageBox with yes and no options.</summary>
		/// <param name="title">The title of the confirmation dialog.</param>
		/// <param name="message">The message to be displayed in the confirmation dialog.</param>
		/// <param name="icon">Icon of the confirmation dialog.</param>
		public static bool ShowConfirmationDialog(string title, string message, MessageBoxIcon? icon = null)
		{
			DialogResult _Dialog;

			if (icon != null)
			{
				_Dialog = MessageBox.Show(message, title, MessageBoxButtons.YesNo, (MessageBoxIcon)icon);
			}
			else
			{
				_Dialog = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
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
