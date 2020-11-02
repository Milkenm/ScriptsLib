using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlForm
	{
		/// <summary>Gets a boolean corresponding to if the form with the given name is open or not.</summary>
		/// <param name="formName">The form to check if is open.</param>
		public static Form IsFormOpen(string formName)
		{
			IEnumerable<Form> selection = from f in GetOpenForms() where f.Name == formName select f;

			if (selection.Any())
			{
				return selection.First();
			}
			return null;
		}
	}
}