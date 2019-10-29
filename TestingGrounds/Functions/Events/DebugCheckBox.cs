#region Usings
using ScriptsLib;

using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_DebugCheckBox()
		{
			if (MainForm.checkBox_tg_debug.Checked == true)
			{
				MainForm.checkBox_tg_debugErrors.Enabled = true;
			}
			else
			{
				MainForm.checkBox_tg_debugErrors.Enabled = false;
			}

			Dev._Debug = MainForm.checkBox_tg_debug.Checked;
		}
	}
}