﻿#region Usings
using System;

using ScriptsLib;

using static TestingGrounds.Functions;
using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_GeneratePassword()
		{
			try
			{
				_MainForm.textBox_generators_generatePassword_password.Text = Generators.GeneratePassword((int)_MainForm.numeric_generators_generatePassword_length.Value);
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}