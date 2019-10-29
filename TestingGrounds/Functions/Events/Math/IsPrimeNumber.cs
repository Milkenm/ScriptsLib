#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib;

using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_IsPrimeNumber()
		{
			MessageBox.Show(QuickMath.IsPrimeNumber(Convert.ToInt32(_MainForm.textBox_math_isPrimeNumber_number.Text)).ToString());
		}
	}
}