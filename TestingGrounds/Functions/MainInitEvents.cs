#region Usings
using System;
using System.ComponentModel;

using static TestingGrounds.Events;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Functions
	{
		internal static void MainInitEvents()
		{
			// Main Form
			MainForm.Load += new EventHandler((_Sender, _Event) => MainLoad());
			MainForm.checkBox_tg_debug.CheckedChanged += new EventHandler((_Sender, _Event) => Event_DebugCheckBox());

			// Database
			MainForm.button_database_createTable.Click += new EventHandler((_Sender, _Event) => Event_DatabaseCreateTable());
			MainForm.button_database_deleteTable.Click += new EventHandler((_Sender, _Event) => Event_DatabaseDeleteTable());
			MainForm.button_database_insert.Click += new EventHandler((_Sender, _Event) => Event_DatabaseInsertInto());
			MainForm.button_database_createDatabase.Click += new EventHandler((_Sender, _Event) => Event_DatabaseCreateDatabase());
			MainForm.button_database_delete.Click += new EventHandler((_Sender, _Event) => Event_DatabaseDelete());
			MainForm.button_database_select.Click += new EventHandler((_Sender, _Event) => Event_DatabaseSelect());

			// Tools
			MainForm.button_tools_crash_crash.Click += new EventHandler((_Sender, _Event) => Event_ToolsCrash());
			MainForm.button_tools_log_log.Click += new EventHandler((_Sender, _Event) => Event_ToolsLog());
			MainForm.textBox_tools_hash_text.TextChanged += new EventHandler((_Sender, _Event) => Event_ToolsHash());
			MainForm.timer_tg_date.Tick += new EventHandler((_Sender, _Event) => Event_ToolsGetDate());
			MainForm.button_tools_setWallpaper6getGifFrames_searchGif.Click += new EventHandler((_Sender, _Event) => Event_SearchGif());
			MainForm.button_tools_setWallpaper6getGifFrames_setWallpaper.Click += new EventHandler((_Sender, _Event) => Event_ToolsSetWallpaper());
			MainForm.fileDialog_tg_searchGif.FileOk += new CancelEventHandler((_Sender, _Event) => Event_FileDialogSearchGifOk());
			MainForm.button_tools_replaceString_replace.Click += new EventHandler((_Sender, _Event) => Event_ToolsReplaceString());

			// Database Tools
			MainForm.button_tools_databaseTools_selectUnique_select.Click += new EventHandler((_Sender, _Event) => Event_DatabaseToolsSelectUnique());

			// Generators
			MainForm.button_generators_generatePassword_generate.Click += new EventHandler((_Sender, _Event) => Event_GeneratePassword());

			// Controls (ComboBox)
			MainForm.button_controls_comboBox_resizeComboBox_resize.Click += new EventHandler((_Sender, _Event) => Event_ResizeComboBox());

			// Controls (TextBox)
			MainForm.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.CheckedChanged += new EventHandler((_Sender, _Event) => Event_OnlyNumbersTextBox());

			// Controls (Form)
			MainForm.button_controls_form_getOpenForms_getOpenForms.Click += new EventHandler((_Sender, _Event) => Event_GetOpenForms());

			// Controls (MessageBox)
			MainForm.button_controls_messageBox_showConfirmationDialog_show.Click += new EventHandler((_Sender, _Event) => Event_ShowConfirmationDialog());

			// Network (Wi-Fi)
			MainForm.button_network_wifi_connect_connect.Click += new EventHandler((_Sender, _Event) => Event_ConnectToWifi());

			// Network (Packets)
			MainForm.button_network_packets_sendTcpPacket_send.Click += new EventHandler((_Sender, _Event) => Event_SendTcpPacket());
			MainForm.button_network_packets_waitTcpPacket_wait.Click += new EventHandler((_Sender, _Event) => Event_WaitTcpPacket());
			MainForm.button_network_packets_sendUdpPacket_send.Click += new EventHandler((_Sender, _Event) => Event_SendUdpPacket());
			MainForm.button_network_packets_waitUdpPacket_wait.Click += new EventHandler((_Sender, _Event) => Event_WaitUdpPacket());

			// Network (Mobile)
			MainForm.button_network_mobile_sendSms_sendSms.Click += new EventHandler((_Sender, _Event) => Event_SendSms());

			// Network (Security)
			MainForm.button_network_security_openFirewallPort_open.Click += new EventHandler((_Sender, _Event) => Event_OpenFirewallPort());

			// Math
			MainForm.button_math_calculateCombinations_calculate.Click += new EventHandler((_Sender, _Event) => Event_CalculateCombinations());
			MainForm.button_math_calculateFactorial_calculate.Click += new EventHandler((_Sender, _Event) => Event_CalculateFactorial());
			MainForm.button_math_isPrimeNumber_check.Click += new EventHandler((_Sender, _Event) => Event_IsPrimeNumber());

			// DynVars
			MainForm.button_dynvars_run.Click += new EventHandler((_Sender, _Event) => Event_DynVars());
		}
	}
}
