#region Usings
using System;

using ScriptsLib.nControls;

using static TestingGrounds.Functions;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_GetOpenForms()
		{
			try
			{
				SlForm.GetOpenForms();
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}