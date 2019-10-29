#region Usings
using ScriptsLib;

using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ToolsHash()
		{
			MainForm.textBox_tools_hash_hashed.Text = Tools.Hash(MainForm.textBox_tools_hash_text.Text);
		}
	}
}
