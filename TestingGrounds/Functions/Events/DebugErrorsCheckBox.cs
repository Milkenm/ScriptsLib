#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptsLib;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_DebugErrorsCheckBox()
		{
			if (MainForm.checkBox_tg_debugErrors.Checked == true)
			{
				MainForm.checkBox_tg_debug.Enabled = false;
			}
			else
			{
				MainForm.checkBox_tg_debugErrors.Enabled = true;
			}

			Dev._ErrorsOnly = MainForm.checkBox_tg_debugErrors.Checked;
		}
	}
}