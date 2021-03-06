﻿#region Usings
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
		internal static void Event_DynVars()
		{
			try
			{
				if (String.IsNullOrEmpty(MainForm.textBox_dynvars_variable.Text))
				{
					MessageBox.Show("The variable field cannot be empty.", "DynVars", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					string _Return = DynVars.DynVar(MainForm.textBox_dynvars_variable.Text, MainForm.textBox_dynvars_value.Text);
					if (!String.IsNullOrEmpty(_Return))
					{
						MessageBox.Show(_Return, "DynVars", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (String.IsNullOrEmpty(_Return) && String.IsNullOrEmpty(MainForm.textBox_dynvars_value.Text))
					{
						MessageBox.Show($"The variable '{MainForm.textBox_dynvars_variable.Text}' doesn't exist.", "DynVars", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						MessageBox.Show($"Variable '{MainForm.textBox_dynvars_variable.Text}' set to '{MainForm.textBox_dynvars_value.Text}'.", "DynVars", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}