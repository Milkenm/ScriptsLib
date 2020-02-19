using static TestingGrounds.Events;
using static TestingGrounds.Static;
using static ScriptsLib.Controls.Tweaks.SlForm;

namespace TestingGrounds
{
	internal static partial class Functions
	{
		internal static void MainInitEvents()
		{
			// Main Form
			MainForm.Load += (s, e) => MainLoad();
			MainForm.checkBox_tg_debug.CheckedChanged += (s, e) => Event_DebugCheckBox();

			// Database
			MainForm.button_database_createTable.Click += (s, e) => Event_DatabaseCreateTable();
			MainForm.button_database_deleteTable.Click += (s, e) => Event_DatabaseDeleteTable();
			MainForm.button_database_insert.Click += (s, e) => Event_DatabaseInsertInto();
			MainForm.button_database_createDatabase.Click += (s, e) => Event_DatabaseCreateDatabase();
			MainForm.button_database_delete.Click += (s, e) => Event_DatabaseDelete();
			MainForm.button_database_select.Click += (s, e) => Event_DatabaseSelect();

			// Tools
			MainForm.button_tools_crash_crash.Click += (s, e) => Event_ToolsCrash();
			MainForm.button_tools_log_log.Click += (s, e) => Event_ToolsLog();
			MainForm.textBox_tools_hash_text.TextChanged += (s, e) => Event_ToolsHash();
			MainForm.timer_tg_date.Tick += (s, e) => Event_ToolsGetDate();
			MainForm.button_tools_setWallpaper6getGifFrames_searchGif.Click += (s, e) => Event_SearchGif();
			MainForm.button_tools_setWallpaper6getGifFrames_setWallpaper.Click += (s, e) => Event_ToolsSetWallpaper();
			MainForm.fileDialog_tg_searchGif.FileOk += (s, e) => Event_FileDialogSearchGifOk();

			// Database Tools
			MainForm.button_tools_databaseTools_selectUnique_select.Click += (s, e) => Event_DatabaseToolsSelectUnique();

			// Generators
			MainForm.button_generators_generatePassword_generate.Click += (s, e) => Event_GeneratePassword();

			// Controls (ComboBox)
			MainForm.button_controls_comboBox_resizeComboBox_resize.Click += (s, e) => Event_ResizeComboBox();

			// Controls (TextBox)
			MainForm.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.CheckedChanged += (s, e) => Event_OnlyNumbersTextBox();

			// Controls (Form)
			MainForm.button_controls_form_getOpenForms_getOpenForms.Click += (s, e) => Event_GetOpenForms();

			// Controls (MessageBox)
			MainForm.button_controls_messageBox_showConfirmationDialog_show.Click += (s, e) => Event_ShowConfirmationDialog();

			// Network (Wi-Fi)
			MainForm.button_network_wifi_connect_connect.Click += (s, e) => Event_ConnectToWifi();

			// Network (Packets)
			MainForm.button_network_packets_sendTcpPacket_send.Click += (s, e) => Event_SendTcpPacket();
			MainForm.button_network_packets_waitTcpPacket_wait.Click += (s, e) => Event_WaitTcpPacket();
			MainForm.button_network_packets_sendUdpPacket_send.Click += (s, e) => Event_SendUdpPacket();
			MainForm.button_network_packets_waitUdpPacket_wait.Click += (s, e) => Event_WaitUdpPacket();

			// Network (Mobile)
			MainForm.button_network_mobile_sendSms_sendSms.Click += (s, e) => Event_SendSms();

			// Network (Security)
			MainForm.button_network_security_openFirewallPort_open.Click += (s, e) => Event_OpenFirewallPort();

			// Math
			MainForm.button_math_calculateCombinations_calculate.Click += (s, e) => Event_CalculateCombinations();
			MainForm.button_math_calculateFactorial_calculate.Click += (s, e) => Event_CalculateFactorial();
			MainForm.button_math_isPrimeNumber_check.Click += (s, e) => Event_IsPrimeNumber();

			// DynVars
			MainForm.button_dynvars_run.Click += (s, e) => Event_DynVars();
		}
	}
}
