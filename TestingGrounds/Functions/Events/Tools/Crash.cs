using ScriptsLib;

namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ToolsCrash()
		{
			Tools.Crash().GetAwaiter();
		}
	}
}