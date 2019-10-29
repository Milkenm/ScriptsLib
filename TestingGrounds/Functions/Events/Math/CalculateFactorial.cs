#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_CalculateFactorial()
		{
			try
			{
				MessageBox.Show(QuickMath.CalculateFactorial((ulong)MainForm.numeric_math_calculateFactorial_factorial.Value).ToString(), "Result", MessageBoxButtons.OK);
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}