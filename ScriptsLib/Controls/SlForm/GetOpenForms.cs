#region Usings
using System.Collections.Generic;
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.nControls
{
	public static partial class SlForm
	{
		/// <summary>Returns a list with the open forms.</summary>
		public static List<Form> GetOpenForms()
		{
			List<Form> _Forms = new List<Form>();
			foreach (Form _Form in Application.OpenForms)
			{
				_Forms.Add(_Form);
			}
			return _Forms;
		}
	}
}
