#region Usings
using System;
using System.ComponentModel;

using static TestingGrounds.Events;
using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Functions
	{
		internal static void MainInitEvents()
		{
			// Main Form
			_MainForm.Load += new EventHandler((_Sender, _Event) => MainLoad());
			_MainForm.checkBox_tg_debug.CheckedChanged += new EventHandler((_Sender, _Event) => Event_DebugCheckBox());

			// Database
			_MainForm.button_database_createTable.Click += new EventHandler((_Sender, _Event) => Event_DatabaseCreateTable());
			_MainForm.button_database_deleteTable.Click += new EventHandler((_Sender, _Event) => Event_DatabaseDeleteTable());
			_MainForm.button_database_insert.Click += new EventHandler((_Sender, _Event) => Event_DatabaseInsertInto());
			_MainForm.button_database_createDatabase.Click += new EventHandler((_Sender, _Event) => Event_DatabaseCreateDatabase());
			_MainForm.button_database_delete.Click += new EventHandler((_Sender, _Event) => Event_DatabaseDelete());
			_MainForm.button_database_select.Click += new EventHandler((_Sender, _Event) => Event_DatabaseSelect());

			// Tools
			_MainForm.button_tools_crash_crash.Click += new EventHandler((_Sender, _Event) => Event_ToolsCrash());
			_MainForm.button_tools_log_log.Click += new EventHandler((_Sender, _Event) => Event_ToolsLog());
			_MainForm.textBox_tools_hash_text.TextChanged += new EventHandler((_Sender, _Event) => Event_ToolsHash());
			_MainForm.timer_tg_date.Tick += new EventHandler((_Sender, _Event) => Event_ToolsGetDate());
			_MainForm.button_tools_setWallpaper6getGifFrames_searchGif.Click += new EventHandler((_Sender, _Event) => Event_SearchGif());
			_MainForm.button_tools_setWallpaper6getGifFrames_setWallpaper.Click += new EventHandler((_Sender, _Event) => Event_ToolsSetWallpaper());
			_MainForm.fileDialog_tg_searchGif.FileOk += new CancelEventHandler((_Sender, _Event) => Event_FileDialogSearchGifOk());
			_MainForm.button_tools_replaceString_replace.Click += new EventHandler((_Sender, _Event) => Event_ToolsReplaceString());

			// Database Tools
			_MainForm.button_tools_databaseTools_selectUnique_select.Click += new EventHandler((_Sender, _Event) => Event_DatabaseToolsSelectUnique());

			// Generators
			_MainForm.button_generators_generatePassword_generate.Click += new EventHandler((_Sender, _Event) => Event_GeneratePassword());

			// Controls (ComboBox)
			_MainForm.button_controls_comboBox_resizeComboBox_resize.Click += new EventHandler((_Sender, _Event) => Event_ResizeComboBox());

			// Controls (TextBox)
			_MainForm.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.CheckedChanged += new EventHandler((_Sender, _Event) => Event_OnlyNumbersTextBox());

			// Controls (Form)
			_MainForm.button_controls_form_getOpenForms_getOpenForms.Click += new EventHandler((_Sender, _Event) => Event_GetOpenForms());

			// Controls (MessageBox)
			_MainForm.button_controls_messageBox_showConfirmationDialog_show.Click += new EventHandler((_Sender, _Event) => Event_ShowConfirmationDialog());

			// Network (Wi-Fi)
			_MainForm.button_network_wifi_connect_connect.Click += new EventHandler((_Sender, _Event) => Event_ConnectToWifi());

			// Network (Packets)
			_MainForm.button_network_packets_sendTcpPacket_send.Click += new EventHandler((_Sender, _Event) => Event_SendTcpPacket());
			_MainForm.button_network_packets_waitTcpPacket_wait.Click += new EventHandler((_Sender, _Event) => Event_WaitTcpPacket());
			_MainForm.button_network_packets_sendUdpPacket_send.Click += new EventHandler((_Sender, _Event) => Event_SendUdpPacket());
			_MainForm.button_network_packets_waitUdpPacket_wait.Click += new EventHandler((_Sender, _Event) => Event_WaitUdpPacket());

			// Network (Security)
			_MainForm.button_network_security_openFirewallPort_open.Click += new EventHandler((_Sender, _Event) => Event_OpenFirewallPort());

			// Math
			_MainForm.button_math_calculateCombinations_calculate.Click += new EventHandler((_Sender, _Event) => Event_CalculateCombinations());
			_MainForm.button_math_calculateFactorial_calculate.Click += new EventHandler((_Sender, _Event) => Event_CalculateFactorial());
			_MainForm.button_math_isPrimeNumber_check.Click += new EventHandler((_Sender, _Event) => Event_IsPrimeNumber());

			// DynVars
			_MainForm.button_dynvars_run.Click += new EventHandler((_Sender, _Event) => Event_DynVars());
		}
	}
}
