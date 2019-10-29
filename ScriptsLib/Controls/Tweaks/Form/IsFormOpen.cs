#region Usings
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlForm
	{
		/// <summary>Gets if the given form name is open or not.</summary>
		/// <param name="_FormName">The form to check if is open.</param>
		public static bool IsFormOpen(string _FormName)
		{
			FormCollection _Forms = Application.OpenForms;
			foreach (Form _Form in _Forms)
			{
				if (_Form.Name == _FormName)
				{
					return true;
				}
			}
			return false;
		}
	}
}
