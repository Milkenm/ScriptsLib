#region Usings
using System;
using System.Windows.Forms;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlForm
	{
		/// <summary>Brings the selected form to the front.</summary>
		/// <param name="_FormName">The name of the form to bring to the front.</param>
		public static void BringFormToFront(string _FormName)
		{
			try
			{
				foreach (Form _Form in Application.OpenForms)
				{
					if (_Form.Name == _FormName)
					{
						_Form.BringToFront();
					}
				}
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
	}
}
