#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib.Controls;

using static TestingGrounds.Functions;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ShowConfirmationDialog()
		{
			try
			{
				bool _Confirm = SlMessageBox.ShowConfirmationDialog("Title", "Message", MessageBoxIcon.Information);

				if (_Confirm == true)
				{
					MessageBox.Show("Accepted!");
				}
				else
				{
					MessageBox.Show("Declined.");
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}
