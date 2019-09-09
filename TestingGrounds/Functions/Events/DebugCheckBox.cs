#region Usings
using ScriptsLib;

using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_DebugCheckBox()
		{
			if (_MainForm.checkBox_tg_debug.Checked == true)
			{
				_MainForm.checkBox_tg_debugErrors.Enabled = true;
			}
			else
			{
				_MainForm.checkBox_tg_debugErrors.Enabled = false;
			}

			Dev._Debug = _MainForm.checkBox_tg_debug.Checked;
		}
	}
}