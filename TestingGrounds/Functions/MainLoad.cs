#region Usings
using System;

using ScriptsLib;
using ScriptsLib.Controls.Tweaks;
using ScriptsLib.nDatabases;
using static ScriptsLib.Device;
using static ScriptsLib.Network.Security;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Functions
	{
		internal static void MainLoad()
		{
			SlForm.SetIntroForm(MainForm, 0.035, false);

			
			MainForm.fileDialog_tg_searchGif.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);


			SqlServerDatabase._DatabasePath = @"C:\Milkenm\Data\Tests.mdf";

			AccessDatabase._DatabasePath = @"C:\Milkenm\Data\TestsAccess.mdb";

			MySqlDatabase._Server = "127.0.0.1";
			MySqlDatabase._Port = 3306;
			MySqlDatabase._Database = "test";
			MySqlDatabase._User = "root";
			MySqlDatabase._Password = "";
			MySqlDatabase._SslMode = "none";

			DynVars.DynvarsFilePath = @"C:\Milkenm\Data\DynVars.txt";

            
			foreach (PortType _Type in Enum.GetValues(typeof(PortType)))
			{
				MainForm.comboBox_network_security_openFirewallPort_portType.Items.Add(_Type.ToString());
			}
            foreach (RAMType _Type in Enum.GetValues(typeof(RAMType)))
            {
                MainForm.comboBox_device_getRam_ramType.Items.Add(_Type.ToString());
            }

			MainForm.comboBox_network_security_openFirewallPort_portType.SelectedIndex = 0;
			MainForm.numeric_network_security_openFirewallPort_portNumber.Value = 70;

			
			MainForm.textBox_tools_databaseTools_checkLogin_user.Text = "User1";
			MainForm.textBox_tools_databaseTools_checkLogin_pass.Text = "Pass1";

			MainForm.textBox_generators_generatePassword_password.Text = Generators.GeneratePassword((int)MainForm.numeric_generators_generatePassword_length.Value);

			MainForm.textBox_tools_databaseTools_filterSql_text.Text = "ABC;DEF;GHI'JKL'MNO";

			MainForm.comboBox_tg_databaseType.SelectedIndex = 2;

            MainForm.comboBox_device_getRam_ramType.SelectedIndex = 0;

			MainForm.comboBox_tools_log_logType.SelectedIndex = 0;
			SlComboBox.ResizeComboBox(MainForm.comboBox_tools_log_logType, 20);

			MainForm.button_controls_comboBox_resizeComboBox_resize.Text = $"Resize {MainForm.button_controls_comboBox_resizeComboBox_resize.Height} | {MainForm.comboBox_controls_comboBox_resizeComboBox_resize.Height}";

			MainForm.textBox_tools_databaseTools_selectUnique_table.Text = "Unique";
			MainForm.textBox_tools_databaseTools_selectUnique_column.Text = "Value";

			MainForm.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Checked = true;

			MainForm.textBox_tg_version.Text = Info.Version;
		}
	}
}
