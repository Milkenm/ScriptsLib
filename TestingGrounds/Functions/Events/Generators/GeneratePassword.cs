#region Usings
using System;

using ScriptsLib;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
    internal static partial class Events
    {
        internal static void Event_GeneratePassword()
        {
            try
            {
                MainForm.textBox_generators_generatePassword_password.Text = Generators.GeneratePassword((int)MainForm.numeric_generators_generatePassword_length.Value, MainForm.textBox_generators_generatePassword_allowedChars.Text);
            }
            catch (Exception _Exception)
            {
                Ex(_Exception);
            }
        }
    }
}