#region Usings
using ScriptsLib;

using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ToolsHash()
		{
			_MainForm.textBox_tools_hash_hashed.Text = Tools.Hash(_MainForm.textBox_tools_hash_text.Text);
		}
	}
}
