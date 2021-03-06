﻿#region Usings
using System;
using System.Numerics;
using System.Windows.Forms;

using ScriptsLib;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_CalculateCombinations()
		{
			try
			{
				MessageBox.Show(QuickMath.CalculateCombinations((BigInteger)MainForm.numeric_math_calculateCombinations_elements.Value, (BigInteger)MainForm.numeric_math_calculateCombinations_group.Value).ToString(), "Result", MessageBoxButtons.OK);
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}