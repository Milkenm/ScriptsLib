using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlForm
	{
		/// <summary>Brings the form with the provided name to the front.</summary>
		/// <param name="formName">The name of the form to bring to the front.</param>
		public static void BringFormToFront(string formName)
		{
			foreach (Form form in Application.OpenForms)
			{
				if (form.Name == formName)
				{
					form.BringToFront();
				}
			}
		}
	}
}
