#region Usings
using ScriptsLib;

using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ToolsGetDate()
		{
			MainForm.label_tools_getDate_date.Text = Tools.GetDate();
		}
	}
}
