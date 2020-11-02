using System.Collections.Generic;
using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlForm
	{
		/// <summary>Returns a list with the open forms on the application.</summary>
		public static List<Form> GetOpenForms()
		{
			List<Form> forms = new List<Form>();
			foreach (Form form in Application.OpenForms)
			{
				forms.Add(form);
			}
			return forms;
		}
	}
}