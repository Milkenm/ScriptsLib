#region Usings
using System;

using ScriptsLib;
using ScriptsLib.nControls;
using ScriptsLib.nDatabases;
using static ScriptsLib.Device;
using static ScriptsLib.nNetwork.Security;
using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Functions
	{
		internal static void MainLoad()
		{
			SlForm.SetIntroForm(_MainForm, 0.035, false);

			
			_MainForm.fileDialog_tg_searchGif.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);


			SqlServerDatabase._DatabasePath = @"C:\Milkenm\Data\Tests.mdf";

			AccessDatabase._DatabasePath = @"C:\Milkenm\Data\TestsAccess.mdb";

			MySqlDatabase._Server = "127.0.0.1";
			MySqlDatabase._Port = 3306;
			MySqlDatabase._Database = "test";
			MySqlDatabase._User = "root";
			MySqlDatabase._Password = "";
			MySqlDatabase._SslMode = "none";

			DynVars._DynvarsFilePath = @"C:\Milkenm\Data\DynVars.txt";

            
			foreach (PortType _Type in Enum.GetValues(typeof(PortType)))
			{
				_MainForm.comboBox_network_security_openFirewallPort_portType.Items.Add(_Type.ToString());
			}
            foreach (RAMType _Type in Enum.GetValues(typeof(RAMType)))
            {
                _MainForm.comboBox_device_getRam_ramType.Items.Add(_Type.ToString());
            }

			_MainForm.comboBox_network_security_openFirewallPort_portType.SelectedIndex = 0;
			_MainForm.numeric_network_security_openFirewallPort_portNumber.Value = 70;

			
			_MainForm.textBox_tools_databaseTools_checkLogin_user.Text = "User1";
			_MainForm.textBox_tools_databaseTools_checkLogin_pass.Text = "Pass1";

			_MainForm.textBox_generators_generatePassword_password.Text = Generators.GeneratePassword((int)_MainForm.numeric_generators_generatePassword_length.Value);

			_MainForm.textBox_tools_databaseTools_filterSql_text.Text = "ABC;DEF;GHI'JKL'MNO";

			_MainForm.comboBox_tg_databaseType.SelectedIndex = 2;

            _MainForm.comboBox_device_getRam_ramType.SelectedIndex = 0;

			_MainForm.comboBox_tools_log_logType.SelectedIndex = 0;
			SlComboBox.ResizeComboBox(_MainForm.comboBox_tools_log_logType, 20);

			_MainForm.button_controls_comboBox_resizeComboBox_resize.Text = $"Resize {_MainForm.button_controls_comboBox_resizeComboBox_resize.Height} | {_MainForm.comboBox_controls_comboBox_resizeComboBox_resize.Height}";

			_MainForm.textBox_tools_databaseTools_selectUnique_table.Text = "Unique";
			_MainForm.textBox_tools_databaseTools_selectUnique_column.Text = "Value";

			_MainForm.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Checked = true;

			_MainForm.textBox_tg_version.Text = Info._Version;
		}
	}
}
