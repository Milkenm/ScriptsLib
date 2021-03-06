﻿namespace TestingGrounds
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.button_database_createTable = new System.Windows.Forms.Button();
			this.button_database_deleteTable = new System.Windows.Forms.Button();
			this.button_database_insert = new System.Windows.Forms.Button();
			this.button_database_createDatabase = new System.Windows.Forms.Button();
			this.button_database_delete = new System.Windows.Forms.Button();
			this.button_database_select = new System.Windows.Forms.Button();
			this.comboBox_tg_databaseType = new System.Windows.Forms.ComboBox();
			this.numeric_generators_generatePassword_length = new System.Windows.Forms.NumericUpDown();
			this.textBox_generators_generatePassword_password = new System.Windows.Forms.TextBox();
			this.button_generators_generatePassword_generate = new System.Windows.Forms.Button();
			this.timer_tg_date = new System.Windows.Forms.Timer(this.components);
			this.fileDialog_tg_searchGif = new System.Windows.Forms.OpenFileDialog();
			this.button_network_wifi_connect_connect = new System.Windows.Forms.Button();
			this.label_network_wifi_connect_password = new System.Windows.Forms.Label();
			this.label_network_wifi_connect_ssid = new System.Windows.Forms.Label();
			this.textBox_network_wifi_connect_wifiPassword = new System.Windows.Forms.TextBox();
			this.textBox_network_wifi_connect_wifiSsid = new System.Windows.Forms.TextBox();
			this.fileDialog_tg_readFile = new System.Windows.Forms.OpenFileDialog();
			this.button_math_calculateCombinations_calculate = new System.Windows.Forms.Button();
			this.numeric_math_calculateCombinations_group = new System.Windows.Forms.NumericUpDown();
			this.label_math_calculateCombinations_group = new System.Windows.Forms.Label();
			this.label_math_calculateCombinations_elements = new System.Windows.Forms.Label();
			this.numeric_math_calculateCombinations_elements = new System.Windows.Forms.NumericUpDown();
			this.button_math_calculateFactorial_calculate = new System.Windows.Forms.Button();
			this.label_math_calculateFactorial_factorial = new System.Windows.Forms.Label();
			this.numeric_math_calculateFactorial_factorial = new System.Windows.Forms.NumericUpDown();
			this.tabs_tg = new System.Windows.Forms.TabControl();
			this.tab_database = new System.Windows.Forms.TabPage();
			this.tabs_database = new System.Windows.Forms.TabControl();
			this.tab_database_createDatabase = new System.Windows.Forms.TabPage();
			this.tab_database_createTable = new System.Windows.Forms.TabPage();
			this.tab_database_insertInto = new System.Windows.Forms.TabPage();
			this.tab_database_deleteTable = new System.Windows.Forms.TabPage();
			this.tab_database_select = new System.Windows.Forms.TabPage();
			this.tab_database_delete = new System.Windows.Forms.TabPage();
			this.tab_tools = new System.Windows.Forms.TabPage();
			this.tabs_tools = new System.Windows.Forms.TabControl();
			this.tab_tools_hash = new System.Windows.Forms.TabPage();
			this.label_tools_hash_hashed = new System.Windows.Forms.Label();
			this.label_tools_hash_text = new System.Windows.Forms.Label();
			this.textBox_tools_hash_hashed = new System.Windows.Forms.TextBox();
			this.textBox_tools_hash_text = new System.Windows.Forms.TextBox();
			this.tab_tools_databaseTools = new System.Windows.Forms.TabPage();
			this.tabs_tools_databaseTools = new System.Windows.Forms.TabControl();
			this.tab_tools_databaseTools_checkLogin = new System.Windows.Forms.TabPage();
			this.textBox_tools_databaseTools_checkLogin_user = new System.Windows.Forms.TextBox();
			this.button_tools_databaseTools_checkLogin_login = new System.Windows.Forms.Button();
			this.label_tools_databaseTools_checkLogin_pass = new System.Windows.Forms.Label();
			this.label_tools_databaseTools_checkLogin_user = new System.Windows.Forms.Label();
			this.textBox_tools_databaseTools_checkLogin_pass = new System.Windows.Forms.TextBox();
			this.tab_tools_databaseTools_filterSql = new System.Windows.Forms.TabPage();
			this.button_tools_databaseTools_filterSql_filter = new System.Windows.Forms.Button();
			this.textBox_tools_databaseTools_filterSql_text = new System.Windows.Forms.TextBox();
			this.tab_tools_databaseTools_selectUnique = new System.Windows.Forms.TabPage();
			this.button_tools_databaseTools_selectUnique_select = new System.Windows.Forms.Button();
			this.textBox_tools_databaseTools_selectUnique_table = new System.Windows.Forms.TextBox();
			this.textBox_tools_databaseTools_selectUnique_column = new System.Windows.Forms.TextBox();
			this.tab_tools_crash = new System.Windows.Forms.TabPage();
			this.button_tools_crash_crash = new System.Windows.Forms.Button();
			this.tab_tools_log = new System.Windows.Forms.TabPage();
			this.label_tools_log_message = new System.Windows.Forms.Label();
			this.label_tools_log_type = new System.Windows.Forms.Label();
			this.textBox_tools_log_logSource = new System.Windows.Forms.TextBox();
			this.textBox_tools_log_logMessage = new System.Windows.Forms.TextBox();
			this.comboBox_tools_log_logType = new System.Windows.Forms.ComboBox();
			this.label_tools_log_source = new System.Windows.Forms.Label();
			this.button_tools_log_log = new System.Windows.Forms.Button();
			this.tab_tools_getDate = new System.Windows.Forms.TabPage();
			this.label_tools_getDate_date = new System.Windows.Forms.Label();
			this.tab_tools_setWallpaper6getGifFrames = new System.Windows.Forms.TabPage();
			this.button_tools_setWallpaper6getGifFrames_searchGif = new System.Windows.Forms.Button();
			this.pictureBox_tools_setWallpaper6getGifFrames_gif = new System.Windows.Forms.PictureBox();
			this.button_tools_setWallpaper6getGifFrames_setWallpaper = new System.Windows.Forms.Button();
			this.tab_generators = new System.Windows.Forms.TabPage();
			this.tabs_generators = new System.Windows.Forms.TabControl();
			this.tab_generators_generatePassword = new System.Windows.Forms.TabPage();
			this.label_generators_generatePassword_allowedChars = new System.Windows.Forms.Label();
			this.textBox_generators_generatePassword_allowedChars = new System.Windows.Forms.TextBox();
			this._generators_generatePassword_length = new System.Windows.Forms.Label();
			this.tab_controls = new System.Windows.Forms.TabPage();
			this.tabs_controls = new System.Windows.Forms.TabControl();
			this.tab_controls_controls = new System.Windows.Forms.TabPage();
			this.tabs_controls_controls = new System.Windows.Forms.TabControl();
			this.tab_lineGraph = new System.Windows.Forms.TabPage();
			this.button_lineGraph_drawTest = new System.Windows.Forms.Button();
			this.tab_controls_tweaks = new System.Windows.Forms.TabPage();
			this.tabs_controls_tweaks = new System.Windows.Forms.TabControl();
			this.tab_controls_tweaks_comboBox = new System.Windows.Forms.TabPage();
			this.tabs_controls_comboBox = new System.Windows.Forms.TabControl();
			this.tab_controls_comboBox_resizeComboBox = new System.Windows.Forms.TabPage();
			this.comboBox_controls_comboBox_resizeComboBox_resize = new System.Windows.Forms.ComboBox();
			this.button_controls_comboBox_resizeComboBox_resize = new System.Windows.Forms.Button();
			this.tab_controls_textBox = new System.Windows.Forms.TabPage();
			this.tabs_controls_textBox = new System.Windows.Forms.TabControl();
			this.tab_controls_textBox_onlyNumbersTextBox = new System.Windows.Forms.TabPage();
			this.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers = new System.Windows.Forms.CheckBox();
			this.textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers = new System.Windows.Forms.TextBox();
			this.tab_controls_form = new System.Windows.Forms.TabPage();
			this.tabs_controls_form = new System.Windows.Forms.TabControl();
			this.tab_controls_form_getOpenForms = new System.Windows.Forms.TabPage();
			this.button_controls_form_getOpenForms_getOpenForms = new System.Windows.Forms.Button();
			this.tab_controls_messageBox = new System.Windows.Forms.TabPage();
			this.tabs_controls_messageBox = new System.Windows.Forms.TabControl();
			this.tab_controls_messageBox_showConfirmationDialog = new System.Windows.Forms.TabPage();
			this.button_controls_messageBox_showConfirmationDialog_show = new System.Windows.Forms.Button();
			this.tab_network = new System.Windows.Forms.TabPage();
			this.tabs_network = new System.Windows.Forms.TabControl();
			this.tab_network_wifi = new System.Windows.Forms.TabPage();
			this.tabs_network_wifi = new System.Windows.Forms.TabControl();
			this.tab_network_wifi_connect = new System.Windows.Forms.TabPage();
			this.tab_network_packets = new System.Windows.Forms.TabPage();
			this.tabs_network_packets = new System.Windows.Forms.TabControl();
			this.tab_network_packets_sendTcpPacket = new System.Windows.Forms.TabPage();
			this.label_network_packets_sendTcpPacket_message = new System.Windows.Forms.Label();
			this.label_network_packets_sendTcpPacket_remotePort = new System.Windows.Forms.Label();
			this.label_network_packets_sendTcpPacket_remoteIp = new System.Windows.Forms.Label();
			this.textBox_network_packets_sendTcpPacket_message = new System.Windows.Forms.TextBox();
			this.textBox_network_packets_sendTcpPacket_remoteIp = new System.Windows.Forms.TextBox();
			this.numeric_network_packets_sendTcpPacket_remotePort = new System.Windows.Forms.NumericUpDown();
			this.button_network_packets_sendTcpPacket_send = new System.Windows.Forms.Button();
			this.tab_network_packets_waitTcpPacket = new System.Windows.Forms.TabPage();
			this.label_network_packets_waitTcpPacket_localPort = new System.Windows.Forms.Label();
			this.numeric_network_packets_waitTcpPacket_localPort = new System.Windows.Forms.NumericUpDown();
			this.button_network_packets_waitTcpPacket_wait = new System.Windows.Forms.Button();
			this.tab_network_packets_sendUdpPacket = new System.Windows.Forms.TabPage();
			this.label_network_packets_sendUdpPacket_message = new System.Windows.Forms.Label();
			this.label_network_packets_sendUdpPacket_remotePort = new System.Windows.Forms.Label();
			this.label_network_packets_sendUdpPacket_remoteIp = new System.Windows.Forms.Label();
			this.textBox_network_packets_sendUdpPacket_message = new System.Windows.Forms.TextBox();
			this.textBox_network_packets_sendUdpPacket_remoteIp = new System.Windows.Forms.TextBox();
			this.numeric_network_packets_sendUdpPacket_remotePort = new System.Windows.Forms.NumericUpDown();
			this.button_network_packets_sendUdpPacket_send = new System.Windows.Forms.Button();
			this.tab_network_packets_waitUdpPacket = new System.Windows.Forms.TabPage();
			this.label_network_packets_waitUdpPacket_localPort = new System.Windows.Forms.Label();
			this.numeric_network_packets_waitUdpPacket_localPort = new System.Windows.Forms.NumericUpDown();
			this.button_network_packets_waitUdpPacket_wait = new System.Windows.Forms.Button();
			this.tab_network_mobile = new System.Windows.Forms.TabPage();
			this.tabs_network_mobile = new System.Windows.Forms.TabControl();
			this.tab_network_mobile_sendSms = new System.Windows.Forms.TabPage();
			this.numeric_network_mobile_sendSms_smtpPort = new System.Windows.Forms.NumericUpDown();
			this.label_network_mobile_sendSms_smtpPort = new System.Windows.Forms.Label();
			this.label_network_mobile_sendSms_smtpHost = new System.Windows.Forms.Label();
			this.textBox_network_mobile_sendSms_smtpHost = new System.Windows.Forms.TextBox();
			this.label_network_mobile_sendSms_smsCarrier = new System.Windows.Forms.Label();
			this.textBox_network_mobile_sendSms_smsCarrier = new System.Windows.Forms.TextBox();
			this.button_network_mobile_sendSms_sendSms = new System.Windows.Forms.Button();
			this.label_network_mobile_sendSms_message = new System.Windows.Forms.Label();
			this.textBox_network_mobile_sendSms_message = new System.Windows.Forms.TextBox();
			this.label_network_mobile_sendSms_subject = new System.Windows.Forms.Label();
			this.textBox_network_mobile_sendSms_subject = new System.Windows.Forms.TextBox();
			this.label_network_mobile_sendSms_receiverPhone = new System.Windows.Forms.Label();
			this.textBox_network_mobile_sendSms_receiverPhone = new System.Windows.Forms.TextBox();
			this.label_network_mobile_sendSms_senderEmailPassword = new System.Windows.Forms.Label();
			this.label_network_mobile_sendSms_senderEmail = new System.Windows.Forms.Label();
			this.textBox_network_mobile_sendSms_senderEmailPassword = new System.Windows.Forms.TextBox();
			this.textBox_network_mobile_sendSms_senderEmail = new System.Windows.Forms.TextBox();
			this.tab_network_security = new System.Windows.Forms.TabPage();
			this.tabs_network_security = new System.Windows.Forms.TabControl();
			this.tab_network_security_openFirewallPort = new System.Windows.Forms.TabPage();
			this.label_network_security_openFirewallPort_warningAdmin = new System.Windows.Forms.Label();
			this.button_network_security_openFirewallPort_open = new System.Windows.Forms.Button();
			this.label_network_security_openFirewallPort_portType = new System.Windows.Forms.Label();
			this.comboBox_network_security_openFirewallPort_portType = new System.Windows.Forms.ComboBox();
			this.label_network_security_openFirewallPort_description = new System.Windows.Forms.Label();
			this.label_network_security_openFirewallPort_portNumber = new System.Windows.Forms.Label();
			this.numeric_network_security_openFirewallPort_portNumber = new System.Windows.Forms.NumericUpDown();
			this.textBox_network_security_openFirewallPort_description = new System.Windows.Forms.TextBox();
			this.tab_network_requests = new System.Windows.Forms.TabPage();
			this.tabs_network_requests = new System.Windows.Forms.TabControl();
			this.tab_network_requests_get = new System.Windows.Forms.TabPage();
			this.label_network_requests_get_endpoint = new System.Windows.Forms.Label();
			this.textBox_network_requests_get_endpoint = new System.Windows.Forms.TextBox();
			this.button_network_requests_get_execute = new System.Windows.Forms.Button();
			this.tab_network_requests_post = new System.Windows.Forms.TabPage();
			this.label_network_requests_post_data = new System.Windows.Forms.Label();
			this.label_network_requests_post_endpoint = new System.Windows.Forms.Label();
			this.textBox_network_requests_post_endpoint = new System.Windows.Forms.TextBox();
			this.textBox_network_requests_post_data = new System.Windows.Forms.TextBox();
			this.button_network_requests_post_execute = new System.Windows.Forms.Button();
			this.tab_network_apis = new System.Windows.Forms.TabPage();
			this.tabs_network_apis = new System.Windows.Forms.TabControl();
			this.tab_network_apis_riotapi = new System.Windows.Forms.TabPage();
			this.tabs_network_apis_riotapi = new System.Windows.Forms.TabControl();
			this.tab_network_apis_riotapi_championMastery = new System.Windows.Forms.TabPage();
			this.tabs_network_apis_riotapi_championMastery = new System.Windows.Forms.TabControl();
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList = new System.Windows.Forms.TabPage();
			this.label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId = new System.Windows.Forms.Label();
			this.textBox_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId = new System.Windows.Forms.TextBox();
			this.button_network_apis_riotapi_championMastery_getChampionMasteryList_get = new System.Windows.Forms.Button();
			this.tab_network_apis_riotapi_championMastery_getMasteryByChampion = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_championMastery_getTotalMasteryScore = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_champion = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_leagueExp = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_league = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_lolStatus = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_match = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_spectator = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_summoner = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_tftLeague = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_tftMatch = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_tftSummoner = new System.Windows.Forms.TabPage();
			this.tab_network_apis_riotapi_thirdPartyCode = new System.Windows.Forms.TabPage();
			this.tab_math = new System.Windows.Forms.TabPage();
			this.tabs_math = new System.Windows.Forms.TabControl();
			this.tab_math_calculateCombinations = new System.Windows.Forms.TabPage();
			this.tab_math_calculateFactorial = new System.Windows.Forms.TabPage();
			this.tab_math_isPrimeNumber = new System.Windows.Forms.TabPage();
			this.label_math_isPrimeNumber_number = new System.Windows.Forms.Label();
			this.textBox_math_isPrimeNumber_number = new System.Windows.Forms.TextBox();
			this.button_math_isPrimeNumber_check = new System.Windows.Forms.Button();
			this.tab_dynvars = new System.Windows.Forms.TabPage();
			this.label_dynvars_value = new System.Windows.Forms.Label();
			this.label_dynvars_variable = new System.Windows.Forms.Label();
			this.button_dynvars_run = new System.Windows.Forms.Button();
			this.textBox_dynvars_value = new System.Windows.Forms.TextBox();
			this.textBox_dynvars_variable = new System.Windows.Forms.TextBox();
			this.tab_device = new System.Windows.Forms.TabPage();
			this.tabs_device = new System.Windows.Forms.TabControl();
			this.tab_device_getRam = new System.Windows.Forms.TabPage();
			this.label_device_getRam_gb = new System.Windows.Forms.Label();
			this.button_device_getRam_update = new System.Windows.Forms.Button();
			this.comboBox_device_getRam_ramType = new System.Windows.Forms.ComboBox();
			this.textBox_device_getRam_value = new System.Windows.Forms.TextBox();
			this.label_tg_databaseType = new System.Windows.Forms.Label();
			this.label_tg_version = new System.Windows.Forms.Label();
			this.textBox_tg_version = new System.Windows.Forms.TextBox();
			this.button_tg_test = new System.Windows.Forms.Button();
			this.checkBox_tg_debug = new System.Windows.Forms.CheckBox();
			this.checkBox_tg_debugErrors = new System.Windows.Forms.CheckBox();
			this.numeric_tg_testingIndex = new System.Windows.Forms.NumericUpDown();
			this.button_tg_keys = new System.Windows.Forms.Button();
			this.button_tg_refresh = new System.Windows.Forms.Button();
			this.tab_controls_form_allowDrag = new System.Windows.Forms.TabPage();
			this.checkBox_controls_form_allowDrag = new System.Windows.Forms.CheckBox();
			this.lineGraph = new ScriptsLib.Controls.LineGraph();
			((System.ComponentModel.ISupportInitialize)(this.numeric_generators_generatePassword_length)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_math_calculateCombinations_group)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_math_calculateCombinations_elements)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_math_calculateFactorial_factorial)).BeginInit();
			this.tabs_tg.SuspendLayout();
			this.tab_database.SuspendLayout();
			this.tabs_database.SuspendLayout();
			this.tab_database_createDatabase.SuspendLayout();
			this.tab_database_createTable.SuspendLayout();
			this.tab_database_insertInto.SuspendLayout();
			this.tab_database_deleteTable.SuspendLayout();
			this.tab_database_select.SuspendLayout();
			this.tab_database_delete.SuspendLayout();
			this.tab_tools.SuspendLayout();
			this.tabs_tools.SuspendLayout();
			this.tab_tools_hash.SuspendLayout();
			this.tab_tools_databaseTools.SuspendLayout();
			this.tabs_tools_databaseTools.SuspendLayout();
			this.tab_tools_databaseTools_checkLogin.SuspendLayout();
			this.tab_tools_databaseTools_filterSql.SuspendLayout();
			this.tab_tools_databaseTools_selectUnique.SuspendLayout();
			this.tab_tools_crash.SuspendLayout();
			this.tab_tools_log.SuspendLayout();
			this.tab_tools_getDate.SuspendLayout();
			this.tab_tools_setWallpaper6getGifFrames.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_tools_setWallpaper6getGifFrames_gif)).BeginInit();
			this.tab_generators.SuspendLayout();
			this.tabs_generators.SuspendLayout();
			this.tab_generators_generatePassword.SuspendLayout();
			this.tab_controls.SuspendLayout();
			this.tabs_controls.SuspendLayout();
			this.tab_controls_controls.SuspendLayout();
			this.tabs_controls_controls.SuspendLayout();
			this.tab_lineGraph.SuspendLayout();
			this.tab_controls_tweaks.SuspendLayout();
			this.tabs_controls_tweaks.SuspendLayout();
			this.tab_controls_tweaks_comboBox.SuspendLayout();
			this.tabs_controls_comboBox.SuspendLayout();
			this.tab_controls_comboBox_resizeComboBox.SuspendLayout();
			this.tab_controls_textBox.SuspendLayout();
			this.tabs_controls_textBox.SuspendLayout();
			this.tab_controls_textBox_onlyNumbersTextBox.SuspendLayout();
			this.tab_controls_form.SuspendLayout();
			this.tabs_controls_form.SuspendLayout();
			this.tab_controls_form_getOpenForms.SuspendLayout();
			this.tab_controls_messageBox.SuspendLayout();
			this.tabs_controls_messageBox.SuspendLayout();
			this.tab_controls_messageBox_showConfirmationDialog.SuspendLayout();
			this.tab_network.SuspendLayout();
			this.tabs_network.SuspendLayout();
			this.tab_network_wifi.SuspendLayout();
			this.tabs_network_wifi.SuspendLayout();
			this.tab_network_wifi_connect.SuspendLayout();
			this.tab_network_packets.SuspendLayout();
			this.tabs_network_packets.SuspendLayout();
			this.tab_network_packets_sendTcpPacket.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_packets_sendTcpPacket_remotePort)).BeginInit();
			this.tab_network_packets_waitTcpPacket.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_packets_waitTcpPacket_localPort)).BeginInit();
			this.tab_network_packets_sendUdpPacket.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_packets_sendUdpPacket_remotePort)).BeginInit();
			this.tab_network_packets_waitUdpPacket.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_packets_waitUdpPacket_localPort)).BeginInit();
			this.tab_network_mobile.SuspendLayout();
			this.tabs_network_mobile.SuspendLayout();
			this.tab_network_mobile_sendSms.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_mobile_sendSms_smtpPort)).BeginInit();
			this.tab_network_security.SuspendLayout();
			this.tabs_network_security.SuspendLayout();
			this.tab_network_security_openFirewallPort.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_security_openFirewallPort_portNumber)).BeginInit();
			this.tab_network_requests.SuspendLayout();
			this.tabs_network_requests.SuspendLayout();
			this.tab_network_requests_get.SuspendLayout();
			this.tab_network_requests_post.SuspendLayout();
			this.tab_network_apis.SuspendLayout();
			this.tabs_network_apis.SuspendLayout();
			this.tab_network_apis_riotapi.SuspendLayout();
			this.tabs_network_apis_riotapi.SuspendLayout();
			this.tab_network_apis_riotapi_championMastery.SuspendLayout();
			this.tabs_network_apis_riotapi_championMastery.SuspendLayout();
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.SuspendLayout();
			this.tab_math.SuspendLayout();
			this.tabs_math.SuspendLayout();
			this.tab_math_calculateCombinations.SuspendLayout();
			this.tab_math_calculateFactorial.SuspendLayout();
			this.tab_math_isPrimeNumber.SuspendLayout();
			this.tab_dynvars.SuspendLayout();
			this.tab_device.SuspendLayout();
			this.tabs_device.SuspendLayout();
			this.tab_device_getRam.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_tg_testingIndex)).BeginInit();
			this.tab_controls_form_allowDrag.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_database_createTable
			// 
			this.button_database_createTable.Location = new System.Drawing.Point(364, 134);
			this.button_database_createTable.Name = "button_database_createTable";
			this.button_database_createTable.Size = new System.Drawing.Size(103, 23);
			this.button_database_createTable.TabIndex = 0;
			this.button_database_createTable.Text = "Create Table";
			this.button_database_createTable.UseVisualStyleBackColor = true;
			// 
			// button_database_deleteTable
			// 
			this.button_database_deleteTable.Location = new System.Drawing.Point(343, 134);
			this.button_database_deleteTable.Name = "button_database_deleteTable";
			this.button_database_deleteTable.Size = new System.Drawing.Size(145, 23);
			this.button_database_deleteTable.TabIndex = 1;
			this.button_database_deleteTable.Text = "Delete Table";
			this.button_database_deleteTable.UseVisualStyleBackColor = true;
			// 
			// button_database_insert
			// 
			this.button_database_insert.Location = new System.Drawing.Point(356, 134);
			this.button_database_insert.Name = "button_database_insert";
			this.button_database_insert.Size = new System.Drawing.Size(119, 23);
			this.button_database_insert.TabIndex = 2;
			this.button_database_insert.Text = "Insert Into";
			this.button_database_insert.UseVisualStyleBackColor = true;
			// 
			// button_database_createDatabase
			// 
			this.button_database_createDatabase.Location = new System.Drawing.Point(355, 134);
			this.button_database_createDatabase.Name = "button_database_createDatabase";
			this.button_database_createDatabase.Size = new System.Drawing.Size(120, 23);
			this.button_database_createDatabase.TabIndex = 3;
			this.button_database_createDatabase.Text = "Create Database";
			this.button_database_createDatabase.UseVisualStyleBackColor = true;
			// 
			// button_database_delete
			// 
			this.button_database_delete.Location = new System.Drawing.Point(347, 134);
			this.button_database_delete.Name = "button_database_delete";
			this.button_database_delete.Size = new System.Drawing.Size(136, 23);
			this.button_database_delete.TabIndex = 6;
			this.button_database_delete.Text = "Delete";
			this.button_database_delete.UseVisualStyleBackColor = true;
			// 
			// button_database_select
			// 
			this.button_database_select.Location = new System.Drawing.Point(343, 134);
			this.button_database_select.Name = "button_database_select";
			this.button_database_select.Size = new System.Drawing.Size(145, 23);
			this.button_database_select.TabIndex = 4;
			this.button_database_select.Text = "Select";
			this.button_database_select.UseVisualStyleBackColor = true;
			// 
			// comboBox_tg_databaseType
			// 
			this.comboBox_tg_databaseType.FormattingEnabled = true;
			this.comboBox_tg_databaseType.Items.AddRange(new object[] {
            "Sql Server",
            "Access",
            "MySql"});
			this.comboBox_tg_databaseType.Location = new System.Drawing.Point(91, 350);
			this.comboBox_tg_databaseType.Name = "comboBox_tg_databaseType";
			this.comboBox_tg_databaseType.Size = new System.Drawing.Size(188, 21);
			this.comboBox_tg_databaseType.TabIndex = 5;
			// 
			// numeric_generators_generatePassword_length
			// 
			this.numeric_generators_generatePassword_length.Location = new System.Drawing.Point(331, 173);
			this.numeric_generators_generatePassword_length.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.numeric_generators_generatePassword_length.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numeric_generators_generatePassword_length.Name = "numeric_generators_generatePassword_length";
			this.numeric_generators_generatePassword_length.Size = new System.Drawing.Size(33, 20);
			this.numeric_generators_generatePassword_length.TabIndex = 12;
			this.numeric_generators_generatePassword_length.Tag = "";
			this.numeric_generators_generatePassword_length.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// textBox_generators_generatePassword_password
			// 
			this.textBox_generators_generatePassword_password.Location = new System.Drawing.Point(287, 95);
			this.textBox_generators_generatePassword_password.Name = "textBox_generators_generatePassword_password";
			this.textBox_generators_generatePassword_password.ReadOnly = true;
			this.textBox_generators_generatePassword_password.Size = new System.Drawing.Size(256, 20);
			this.textBox_generators_generatePassword_password.TabIndex = 11;
			// 
			// button_generators_generatePassword_generate
			// 
			this.button_generators_generatePassword_generate.Location = new System.Drawing.Point(430, 173);
			this.button_generators_generatePassword_generate.Name = "button_generators_generatePassword_generate";
			this.button_generators_generatePassword_generate.Size = new System.Drawing.Size(113, 22);
			this.button_generators_generatePassword_generate.TabIndex = 10;
			this.button_generators_generatePassword_generate.Text = "Generate Password";
			this.button_generators_generatePassword_generate.UseVisualStyleBackColor = true;
			// 
			// timer_tg_date
			// 
			this.timer_tg_date.Enabled = true;
			this.timer_tg_date.Interval = 1;
			// 
			// fileDialog_tg_searchGif
			// 
			this.fileDialog_tg_searchGif.Filter = "GIF Image|*.gif";
			// 
			// button_network_wifi_connect_connect
			// 
			this.button_network_wifi_connect_connect.Location = new System.Drawing.Point(427, 161);
			this.button_network_wifi_connect_connect.Name = "button_network_wifi_connect_connect";
			this.button_network_wifi_connect_connect.Size = new System.Drawing.Size(75, 23);
			this.button_network_wifi_connect_connect.TabIndex = 4;
			this.button_network_wifi_connect_connect.Text = "Connect";
			this.button_network_wifi_connect_connect.UseVisualStyleBackColor = true;
			// 
			// label_network_wifi_connect_password
			// 
			this.label_network_wifi_connect_password.AutoSize = true;
			this.label_network_wifi_connect_password.Location = new System.Drawing.Point(314, 118);
			this.label_network_wifi_connect_password.Name = "label_network_wifi_connect_password";
			this.label_network_wifi_connect_password.Size = new System.Drawing.Size(53, 13);
			this.label_network_wifi_connect_password.TabIndex = 3;
			this.label_network_wifi_connect_password.Text = "Password";
			// 
			// label_network_wifi_connect_ssid
			// 
			this.label_network_wifi_connect_ssid.AutoSize = true;
			this.label_network_wifi_connect_ssid.Location = new System.Drawing.Point(314, 75);
			this.label_network_wifi_connect_ssid.Name = "label_network_wifi_connect_ssid";
			this.label_network_wifi_connect_ssid.Size = new System.Drawing.Size(32, 13);
			this.label_network_wifi_connect_ssid.TabIndex = 2;
			this.label_network_wifi_connect_ssid.Text = "SSID";
			// 
			// textBox_network_wifi_connect_wifiPassword
			// 
			this.textBox_network_wifi_connect_wifiPassword.Location = new System.Drawing.Point(317, 134);
			this.textBox_network_wifi_connect_wifiPassword.Name = "textBox_network_wifi_connect_wifiPassword";
			this.textBox_network_wifi_connect_wifiPassword.Size = new System.Drawing.Size(185, 20);
			this.textBox_network_wifi_connect_wifiPassword.TabIndex = 1;
			// 
			// textBox_network_wifi_connect_wifiSsid
			// 
			this.textBox_network_wifi_connect_wifiSsid.Location = new System.Drawing.Point(317, 91);
			this.textBox_network_wifi_connect_wifiSsid.Name = "textBox_network_wifi_connect_wifiSsid";
			this.textBox_network_wifi_connect_wifiSsid.Size = new System.Drawing.Size(185, 20);
			this.textBox_network_wifi_connect_wifiSsid.TabIndex = 0;
			// 
			// button_math_calculateCombinations_calculate
			// 
			this.button_math_calculateCombinations_calculate.Location = new System.Drawing.Point(464, 160);
			this.button_math_calculateCombinations_calculate.Name = "button_math_calculateCombinations_calculate";
			this.button_math_calculateCombinations_calculate.Size = new System.Drawing.Size(75, 23);
			this.button_math_calculateCombinations_calculate.TabIndex = 24;
			this.button_math_calculateCombinations_calculate.Text = "Calculate";
			this.button_math_calculateCombinations_calculate.UseVisualStyleBackColor = true;
			// 
			// numeric_math_calculateCombinations_group
			// 
			this.numeric_math_calculateCombinations_group.Location = new System.Drawing.Point(351, 134);
			this.numeric_math_calculateCombinations_group.Name = "numeric_math_calculateCombinations_group";
			this.numeric_math_calculateCombinations_group.Size = new System.Drawing.Size(188, 20);
			this.numeric_math_calculateCombinations_group.TabIndex = 3;
			// 
			// label_math_calculateCombinations_group
			// 
			this.label_math_calculateCombinations_group.AutoSize = true;
			this.label_math_calculateCombinations_group.Location = new System.Drawing.Point(306, 136);
			this.label_math_calculateCombinations_group.Name = "label_math_calculateCombinations_group";
			this.label_math_calculateCombinations_group.Size = new System.Drawing.Size(39, 13);
			this.label_math_calculateCombinations_group.TabIndex = 2;
			this.label_math_calculateCombinations_group.Text = "Group:";
			// 
			// label_math_calculateCombinations_elements
			// 
			this.label_math_calculateCombinations_elements.AutoSize = true;
			this.label_math_calculateCombinations_elements.Location = new System.Drawing.Point(292, 110);
			this.label_math_calculateCombinations_elements.Name = "label_math_calculateCombinations_elements";
			this.label_math_calculateCombinations_elements.Size = new System.Drawing.Size(53, 13);
			this.label_math_calculateCombinations_elements.TabIndex = 1;
			this.label_math_calculateCombinations_elements.Text = "Elements:";
			// 
			// numeric_math_calculateCombinations_elements
			// 
			this.numeric_math_calculateCombinations_elements.Location = new System.Drawing.Point(351, 108);
			this.numeric_math_calculateCombinations_elements.Name = "numeric_math_calculateCombinations_elements";
			this.numeric_math_calculateCombinations_elements.Size = new System.Drawing.Size(188, 20);
			this.numeric_math_calculateCombinations_elements.TabIndex = 0;
			// 
			// button_math_calculateFactorial_calculate
			// 
			this.button_math_calculateFactorial_calculate.Location = new System.Drawing.Point(461, 146);
			this.button_math_calculateFactorial_calculate.Name = "button_math_calculateFactorial_calculate";
			this.button_math_calculateFactorial_calculate.Size = new System.Drawing.Size(75, 23);
			this.button_math_calculateFactorial_calculate.TabIndex = 24;
			this.button_math_calculateFactorial_calculate.Text = "Calculate";
			this.button_math_calculateFactorial_calculate.UseVisualStyleBackColor = true;
			// 
			// label_math_calculateFactorial_factorial
			// 
			this.label_math_calculateFactorial_factorial.AutoSize = true;
			this.label_math_calculateFactorial_factorial.Location = new System.Drawing.Point(295, 123);
			this.label_math_calculateFactorial_factorial.Name = "label_math_calculateFactorial_factorial";
			this.label_math_calculateFactorial_factorial.Size = new System.Drawing.Size(47, 13);
			this.label_math_calculateFactorial_factorial.TabIndex = 1;
			this.label_math_calculateFactorial_factorial.Text = "Number:";
			// 
			// numeric_math_calculateFactorial_factorial
			// 
			this.numeric_math_calculateFactorial_factorial.Location = new System.Drawing.Point(348, 121);
			this.numeric_math_calculateFactorial_factorial.Name = "numeric_math_calculateFactorial_factorial";
			this.numeric_math_calculateFactorial_factorial.Size = new System.Drawing.Size(188, 20);
			this.numeric_math_calculateFactorial_factorial.TabIndex = 0;
			// 
			// tabs_tg
			// 
			this.tabs_tg.Controls.Add(this.tab_database);
			this.tabs_tg.Controls.Add(this.tab_tools);
			this.tabs_tg.Controls.Add(this.tab_generators);
			this.tabs_tg.Controls.Add(this.tab_controls);
			this.tabs_tg.Controls.Add(this.tab_network);
			this.tabs_tg.Controls.Add(this.tab_math);
			this.tabs_tg.Controls.Add(this.tab_dynvars);
			this.tabs_tg.Controls.Add(this.tab_device);
			this.tabs_tg.Location = new System.Drawing.Point(0, 0);
			this.tabs_tg.Name = "tabs_tg";
			this.tabs_tg.SelectedIndex = 0;
			this.tabs_tg.Size = new System.Drawing.Size(852, 348);
			this.tabs_tg.TabIndex = 28;
			// 
			// tab_database
			// 
			this.tab_database.Controls.Add(this.tabs_database);
			this.tab_database.Location = new System.Drawing.Point(4, 22);
			this.tab_database.Name = "tab_database";
			this.tab_database.Padding = new System.Windows.Forms.Padding(3);
			this.tab_database.Size = new System.Drawing.Size(844, 322);
			this.tab_database.TabIndex = 1;
			this.tab_database.Text = "Database";
			this.tab_database.UseVisualStyleBackColor = true;
			// 
			// tabs_database
			// 
			this.tabs_database.Controls.Add(this.tab_database_createDatabase);
			this.tabs_database.Controls.Add(this.tab_database_createTable);
			this.tabs_database.Controls.Add(this.tab_database_insertInto);
			this.tabs_database.Controls.Add(this.tab_database_deleteTable);
			this.tabs_database.Controls.Add(this.tab_database_select);
			this.tabs_database.Controls.Add(this.tab_database_delete);
			this.tabs_database.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_database.Location = new System.Drawing.Point(3, 3);
			this.tabs_database.Name = "tabs_database";
			this.tabs_database.SelectedIndex = 0;
			this.tabs_database.Size = new System.Drawing.Size(838, 316);
			this.tabs_database.TabIndex = 7;
			// 
			// tab_database_createDatabase
			// 
			this.tab_database_createDatabase.Controls.Add(this.button_database_createDatabase);
			this.tab_database_createDatabase.Location = new System.Drawing.Point(4, 22);
			this.tab_database_createDatabase.Name = "tab_database_createDatabase";
			this.tab_database_createDatabase.Padding = new System.Windows.Forms.Padding(3);
			this.tab_database_createDatabase.Size = new System.Drawing.Size(830, 290);
			this.tab_database_createDatabase.TabIndex = 0;
			this.tab_database_createDatabase.Text = "Create Database";
			this.tab_database_createDatabase.UseVisualStyleBackColor = true;
			// 
			// tab_database_createTable
			// 
			this.tab_database_createTable.Controls.Add(this.button_database_createTable);
			this.tab_database_createTable.Location = new System.Drawing.Point(4, 22);
			this.tab_database_createTable.Name = "tab_database_createTable";
			this.tab_database_createTable.Padding = new System.Windows.Forms.Padding(3);
			this.tab_database_createTable.Size = new System.Drawing.Size(830, 290);
			this.tab_database_createTable.TabIndex = 1;
			this.tab_database_createTable.Text = "Create Table";
			this.tab_database_createTable.UseVisualStyleBackColor = true;
			// 
			// tab_database_insertInto
			// 
			this.tab_database_insertInto.Controls.Add(this.button_database_insert);
			this.tab_database_insertInto.Location = new System.Drawing.Point(4, 22);
			this.tab_database_insertInto.Name = "tab_database_insertInto";
			this.tab_database_insertInto.Padding = new System.Windows.Forms.Padding(3);
			this.tab_database_insertInto.Size = new System.Drawing.Size(830, 290);
			this.tab_database_insertInto.TabIndex = 2;
			this.tab_database_insertInto.Text = "Insert Into";
			this.tab_database_insertInto.UseVisualStyleBackColor = true;
			// 
			// tab_database_deleteTable
			// 
			this.tab_database_deleteTable.Controls.Add(this.button_database_deleteTable);
			this.tab_database_deleteTable.Location = new System.Drawing.Point(4, 22);
			this.tab_database_deleteTable.Name = "tab_database_deleteTable";
			this.tab_database_deleteTable.Padding = new System.Windows.Forms.Padding(3);
			this.tab_database_deleteTable.Size = new System.Drawing.Size(830, 290);
			this.tab_database_deleteTable.TabIndex = 3;
			this.tab_database_deleteTable.Text = "Delete Table";
			this.tab_database_deleteTable.UseVisualStyleBackColor = true;
			// 
			// tab_database_select
			// 
			this.tab_database_select.Controls.Add(this.button_database_select);
			this.tab_database_select.Location = new System.Drawing.Point(4, 22);
			this.tab_database_select.Name = "tab_database_select";
			this.tab_database_select.Padding = new System.Windows.Forms.Padding(3);
			this.tab_database_select.Size = new System.Drawing.Size(830, 290);
			this.tab_database_select.TabIndex = 4;
			this.tab_database_select.Text = "Select";
			this.tab_database_select.UseVisualStyleBackColor = true;
			// 
			// tab_database_delete
			// 
			this.tab_database_delete.Controls.Add(this.button_database_delete);
			this.tab_database_delete.Location = new System.Drawing.Point(4, 22);
			this.tab_database_delete.Name = "tab_database_delete";
			this.tab_database_delete.Padding = new System.Windows.Forms.Padding(3);
			this.tab_database_delete.Size = new System.Drawing.Size(830, 290);
			this.tab_database_delete.TabIndex = 5;
			this.tab_database_delete.Text = "Delete";
			this.tab_database_delete.UseVisualStyleBackColor = true;
			// 
			// tab_tools
			// 
			this.tab_tools.Controls.Add(this.tabs_tools);
			this.tab_tools.Location = new System.Drawing.Point(4, 22);
			this.tab_tools.Name = "tab_tools";
			this.tab_tools.Padding = new System.Windows.Forms.Padding(3);
			this.tab_tools.Size = new System.Drawing.Size(844, 322);
			this.tab_tools.TabIndex = 2;
			this.tab_tools.Text = "Tools";
			this.tab_tools.UseVisualStyleBackColor = true;
			// 
			// tabs_tools
			// 
			this.tabs_tools.Controls.Add(this.tab_tools_hash);
			this.tabs_tools.Controls.Add(this.tab_tools_databaseTools);
			this.tabs_tools.Controls.Add(this.tab_tools_crash);
			this.tabs_tools.Controls.Add(this.tab_tools_log);
			this.tabs_tools.Controls.Add(this.tab_tools_getDate);
			this.tabs_tools.Controls.Add(this.tab_tools_setWallpaper6getGifFrames);
			this.tabs_tools.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_tools.Location = new System.Drawing.Point(3, 3);
			this.tabs_tools.Name = "tabs_tools";
			this.tabs_tools.SelectedIndex = 0;
			this.tabs_tools.Size = new System.Drawing.Size(838, 316);
			this.tabs_tools.TabIndex = 1;
			// 
			// tab_tools_hash
			// 
			this.tab_tools_hash.Controls.Add(this.label_tools_hash_hashed);
			this.tab_tools_hash.Controls.Add(this.label_tools_hash_text);
			this.tab_tools_hash.Controls.Add(this.textBox_tools_hash_hashed);
			this.tab_tools_hash.Controls.Add(this.textBox_tools_hash_text);
			this.tab_tools_hash.Location = new System.Drawing.Point(4, 22);
			this.tab_tools_hash.Name = "tab_tools_hash";
			this.tab_tools_hash.Padding = new System.Windows.Forms.Padding(3);
			this.tab_tools_hash.Size = new System.Drawing.Size(830, 290);
			this.tab_tools_hash.TabIndex = 0;
			this.tab_tools_hash.Text = "Hash";
			this.tab_tools_hash.UseVisualStyleBackColor = true;
			// 
			// label_tools_hash_hashed
			// 
			this.label_tools_hash_hashed.AutoSize = true;
			this.label_tools_hash_hashed.Location = new System.Drawing.Point(154, 153);
			this.label_tools_hash_hashed.Name = "label_tools_hash_hashed";
			this.label_tools_hash_hashed.Size = new System.Drawing.Size(44, 13);
			this.label_tools_hash_hashed.TabIndex = 3;
			this.label_tools_hash_hashed.Text = "Hashed";
			// 
			// label_tools_hash_text
			// 
			this.label_tools_hash_text.AutoSize = true;
			this.label_tools_hash_text.Location = new System.Drawing.Point(154, 102);
			this.label_tools_hash_text.Name = "label_tools_hash_text";
			this.label_tools_hash_text.Size = new System.Drawing.Size(28, 13);
			this.label_tools_hash_text.TabIndex = 2;
			this.label_tools_hash_text.Text = "Text";
			// 
			// textBox_tools_hash_hashed
			// 
			this.textBox_tools_hash_hashed.Location = new System.Drawing.Point(157, 169);
			this.textBox_tools_hash_hashed.Name = "textBox_tools_hash_hashed";
			this.textBox_tools_hash_hashed.Size = new System.Drawing.Size(519, 20);
			this.textBox_tools_hash_hashed.TabIndex = 1;
			// 
			// textBox_tools_hash_text
			// 
			this.textBox_tools_hash_text.Location = new System.Drawing.Point(157, 118);
			this.textBox_tools_hash_text.Name = "textBox_tools_hash_text";
			this.textBox_tools_hash_text.Size = new System.Drawing.Size(519, 20);
			this.textBox_tools_hash_text.TabIndex = 0;
			// 
			// tab_tools_databaseTools
			// 
			this.tab_tools_databaseTools.Controls.Add(this.tabs_tools_databaseTools);
			this.tab_tools_databaseTools.Location = new System.Drawing.Point(4, 22);
			this.tab_tools_databaseTools.Name = "tab_tools_databaseTools";
			this.tab_tools_databaseTools.Padding = new System.Windows.Forms.Padding(3);
			this.tab_tools_databaseTools.Size = new System.Drawing.Size(830, 290);
			this.tab_tools_databaseTools.TabIndex = 2;
			this.tab_tools_databaseTools.Text = "Database Tools";
			this.tab_tools_databaseTools.UseVisualStyleBackColor = true;
			// 
			// tabs_tools_databaseTools
			// 
			this.tabs_tools_databaseTools.Controls.Add(this.tab_tools_databaseTools_checkLogin);
			this.tabs_tools_databaseTools.Controls.Add(this.tab_tools_databaseTools_filterSql);
			this.tabs_tools_databaseTools.Controls.Add(this.tab_tools_databaseTools_selectUnique);
			this.tabs_tools_databaseTools.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_tools_databaseTools.Location = new System.Drawing.Point(3, 3);
			this.tabs_tools_databaseTools.Name = "tabs_tools_databaseTools";
			this.tabs_tools_databaseTools.SelectedIndex = 0;
			this.tabs_tools_databaseTools.Size = new System.Drawing.Size(824, 284);
			this.tabs_tools_databaseTools.TabIndex = 0;
			// 
			// tab_tools_databaseTools_checkLogin
			// 
			this.tab_tools_databaseTools_checkLogin.Controls.Add(this.textBox_tools_databaseTools_checkLogin_user);
			this.tab_tools_databaseTools_checkLogin.Controls.Add(this.button_tools_databaseTools_checkLogin_login);
			this.tab_tools_databaseTools_checkLogin.Controls.Add(this.label_tools_databaseTools_checkLogin_pass);
			this.tab_tools_databaseTools_checkLogin.Controls.Add(this.label_tools_databaseTools_checkLogin_user);
			this.tab_tools_databaseTools_checkLogin.Controls.Add(this.textBox_tools_databaseTools_checkLogin_pass);
			this.tab_tools_databaseTools_checkLogin.Location = new System.Drawing.Point(4, 22);
			this.tab_tools_databaseTools_checkLogin.Name = "tab_tools_databaseTools_checkLogin";
			this.tab_tools_databaseTools_checkLogin.Padding = new System.Windows.Forms.Padding(3);
			this.tab_tools_databaseTools_checkLogin.Size = new System.Drawing.Size(816, 258);
			this.tab_tools_databaseTools_checkLogin.TabIndex = 0;
			this.tab_tools_databaseTools_checkLogin.Text = "Check Login";
			this.tab_tools_databaseTools_checkLogin.UseVisualStyleBackColor = true;
			// 
			// textBox_tools_databaseTools_checkLogin_user
			// 
			this.textBox_tools_databaseTools_checkLogin_user.Location = new System.Drawing.Point(238, 92);
			this.textBox_tools_databaseTools_checkLogin_user.Name = "textBox_tools_databaseTools_checkLogin_user";
			this.textBox_tools_databaseTools_checkLogin_user.Size = new System.Drawing.Size(380, 20);
			this.textBox_tools_databaseTools_checkLogin_user.TabIndex = 16;
			// 
			// button_tools_databaseTools_checkLogin_login
			// 
			this.button_tools_databaseTools_checkLogin_login.Location = new System.Drawing.Point(500, 144);
			this.button_tools_databaseTools_checkLogin_login.Name = "button_tools_databaseTools_checkLogin_login";
			this.button_tools_databaseTools_checkLogin_login.Size = new System.Drawing.Size(118, 23);
			this.button_tools_databaseTools_checkLogin_login.TabIndex = 15;
			this.button_tools_databaseTools_checkLogin_login.Text = "Login";
			this.button_tools_databaseTools_checkLogin_login.UseVisualStyleBackColor = true;
			// 
			// label_tools_databaseTools_checkLogin_pass
			// 
			this.label_tools_databaseTools_checkLogin_pass.AutoSize = true;
			this.label_tools_databaseTools_checkLogin_pass.Location = new System.Drawing.Point(199, 121);
			this.label_tools_databaseTools_checkLogin_pass.Name = "label_tools_databaseTools_checkLogin_pass";
			this.label_tools_databaseTools_checkLogin_pass.Size = new System.Drawing.Size(33, 13);
			this.label_tools_databaseTools_checkLogin_pass.TabIndex = 19;
			this.label_tools_databaseTools_checkLogin_pass.Text = "Pass:";
			// 
			// label_tools_databaseTools_checkLogin_user
			// 
			this.label_tools_databaseTools_checkLogin_user.AutoSize = true;
			this.label_tools_databaseTools_checkLogin_user.Location = new System.Drawing.Point(200, 95);
			this.label_tools_databaseTools_checkLogin_user.Name = "label_tools_databaseTools_checkLogin_user";
			this.label_tools_databaseTools_checkLogin_user.Size = new System.Drawing.Size(32, 13);
			this.label_tools_databaseTools_checkLogin_user.TabIndex = 18;
			this.label_tools_databaseTools_checkLogin_user.Text = "User:";
			// 
			// textBox_tools_databaseTools_checkLogin_pass
			// 
			this.textBox_tools_databaseTools_checkLogin_pass.Location = new System.Drawing.Point(238, 118);
			this.textBox_tools_databaseTools_checkLogin_pass.Name = "textBox_tools_databaseTools_checkLogin_pass";
			this.textBox_tools_databaseTools_checkLogin_pass.Size = new System.Drawing.Size(380, 20);
			this.textBox_tools_databaseTools_checkLogin_pass.TabIndex = 17;
			// 
			// tab_tools_databaseTools_filterSql
			// 
			this.tab_tools_databaseTools_filterSql.Controls.Add(this.button_tools_databaseTools_filterSql_filter);
			this.tab_tools_databaseTools_filterSql.Controls.Add(this.textBox_tools_databaseTools_filterSql_text);
			this.tab_tools_databaseTools_filterSql.Location = new System.Drawing.Point(4, 22);
			this.tab_tools_databaseTools_filterSql.Name = "tab_tools_databaseTools_filterSql";
			this.tab_tools_databaseTools_filterSql.Padding = new System.Windows.Forms.Padding(3);
			this.tab_tools_databaseTools_filterSql.Size = new System.Drawing.Size(816, 258);
			this.tab_tools_databaseTools_filterSql.TabIndex = 1;
			this.tab_tools_databaseTools_filterSql.Text = "Filter SQL";
			this.tab_tools_databaseTools_filterSql.UseVisualStyleBackColor = true;
			// 
			// button_tools_databaseTools_filterSql_filter
			// 
			this.button_tools_databaseTools_filterSql_filter.Location = new System.Drawing.Point(584, 131);
			this.button_tools_databaseTools_filterSql_filter.Name = "button_tools_databaseTools_filterSql_filter";
			this.button_tools_databaseTools_filterSql_filter.Size = new System.Drawing.Size(97, 22);
			this.button_tools_databaseTools_filterSql_filter.TabIndex = 18;
			this.button_tools_databaseTools_filterSql_filter.Text = "Filter";
			this.button_tools_databaseTools_filterSql_filter.UseVisualStyleBackColor = true;
			// 
			// textBox_tools_databaseTools_filterSql_text
			// 
			this.textBox_tools_databaseTools_filterSql_text.Location = new System.Drawing.Point(136, 105);
			this.textBox_tools_databaseTools_filterSql_text.Name = "textBox_tools_databaseTools_filterSql_text";
			this.textBox_tools_databaseTools_filterSql_text.Size = new System.Drawing.Size(545, 20);
			this.textBox_tools_databaseTools_filterSql_text.TabIndex = 17;
			// 
			// tab_tools_databaseTools_selectUnique
			// 
			this.tab_tools_databaseTools_selectUnique.Controls.Add(this.button_tools_databaseTools_selectUnique_select);
			this.tab_tools_databaseTools_selectUnique.Controls.Add(this.textBox_tools_databaseTools_selectUnique_table);
			this.tab_tools_databaseTools_selectUnique.Controls.Add(this.textBox_tools_databaseTools_selectUnique_column);
			this.tab_tools_databaseTools_selectUnique.Location = new System.Drawing.Point(4, 22);
			this.tab_tools_databaseTools_selectUnique.Name = "tab_tools_databaseTools_selectUnique";
			this.tab_tools_databaseTools_selectUnique.Padding = new System.Windows.Forms.Padding(3);
			this.tab_tools_databaseTools_selectUnique.Size = new System.Drawing.Size(816, 258);
			this.tab_tools_databaseTools_selectUnique.TabIndex = 2;
			this.tab_tools_databaseTools_selectUnique.Text = "Select Unique";
			this.tab_tools_databaseTools_selectUnique.UseVisualStyleBackColor = true;
			// 
			// button_tools_databaseTools_selectUnique_select
			// 
			this.button_tools_databaseTools_selectUnique_select.Location = new System.Drawing.Point(501, 144);
			this.button_tools_databaseTools_selectUnique_select.Name = "button_tools_databaseTools_selectUnique_select";
			this.button_tools_databaseTools_selectUnique_select.Size = new System.Drawing.Size(75, 23);
			this.button_tools_databaseTools_selectUnique_select.TabIndex = 13;
			this.button_tools_databaseTools_selectUnique_select.Text = "Select";
			this.button_tools_databaseTools_selectUnique_select.UseVisualStyleBackColor = true;
			// 
			// textBox_tools_databaseTools_selectUnique_table
			// 
			this.textBox_tools_databaseTools_selectUnique_table.Location = new System.Drawing.Point(240, 92);
			this.textBox_tools_databaseTools_selectUnique_table.Name = "textBox_tools_databaseTools_selectUnique_table";
			this.textBox_tools_databaseTools_selectUnique_table.Size = new System.Drawing.Size(336, 20);
			this.textBox_tools_databaseTools_selectUnique_table.TabIndex = 11;
			// 
			// textBox_tools_databaseTools_selectUnique_column
			// 
			this.textBox_tools_databaseTools_selectUnique_column.Location = new System.Drawing.Point(240, 118);
			this.textBox_tools_databaseTools_selectUnique_column.Name = "textBox_tools_databaseTools_selectUnique_column";
			this.textBox_tools_databaseTools_selectUnique_column.Size = new System.Drawing.Size(336, 20);
			this.textBox_tools_databaseTools_selectUnique_column.TabIndex = 12;
			// 
			// tab_tools_crash
			// 
			this.tab_tools_crash.Controls.Add(this.button_tools_crash_crash);
			this.tab_tools_crash.Location = new System.Drawing.Point(4, 22);
			this.tab_tools_crash.Name = "tab_tools_crash";
			this.tab_tools_crash.Padding = new System.Windows.Forms.Padding(3);
			this.tab_tools_crash.Size = new System.Drawing.Size(830, 290);
			this.tab_tools_crash.TabIndex = 3;
			this.tab_tools_crash.Text = "Crash";
			this.tab_tools_crash.UseVisualStyleBackColor = true;
			// 
			// button_tools_crash_crash
			// 
			this.button_tools_crash_crash.Location = new System.Drawing.Point(311, 124);
			this.button_tools_crash_crash.Name = "button_tools_crash_crash";
			this.button_tools_crash_crash.Size = new System.Drawing.Size(209, 43);
			this.button_tools_crash_crash.TabIndex = 4;
			this.button_tools_crash_crash.Text = "Crash";
			this.button_tools_crash_crash.UseVisualStyleBackColor = true;
			// 
			// tab_tools_log
			// 
			this.tab_tools_log.Controls.Add(this.label_tools_log_message);
			this.tab_tools_log.Controls.Add(this.label_tools_log_type);
			this.tab_tools_log.Controls.Add(this.textBox_tools_log_logSource);
			this.tab_tools_log.Controls.Add(this.textBox_tools_log_logMessage);
			this.tab_tools_log.Controls.Add(this.comboBox_tools_log_logType);
			this.tab_tools_log.Controls.Add(this.label_tools_log_source);
			this.tab_tools_log.Controls.Add(this.button_tools_log_log);
			this.tab_tools_log.Location = new System.Drawing.Point(4, 22);
			this.tab_tools_log.Name = "tab_tools_log";
			this.tab_tools_log.Padding = new System.Windows.Forms.Padding(3);
			this.tab_tools_log.Size = new System.Drawing.Size(830, 290);
			this.tab_tools_log.TabIndex = 4;
			this.tab_tools_log.Text = "Log";
			this.tab_tools_log.UseVisualStyleBackColor = true;
			// 
			// label_tools_log_message
			// 
			this.label_tools_log_message.AutoSize = true;
			this.label_tools_log_message.Location = new System.Drawing.Point(289, 98);
			this.label_tools_log_message.Name = "label_tools_log_message";
			this.label_tools_log_message.Size = new System.Drawing.Size(53, 13);
			this.label_tools_log_message.TabIndex = 19;
			this.label_tools_log_message.Text = "Message:";
			// 
			// label_tools_log_type
			// 
			this.label_tools_log_type.AutoSize = true;
			this.label_tools_log_type.Location = new System.Drawing.Point(308, 150);
			this.label_tools_log_type.Name = "label_tools_log_type";
			this.label_tools_log_type.Size = new System.Drawing.Size(34, 13);
			this.label_tools_log_type.TabIndex = 21;
			this.label_tools_log_type.Text = "Type:";
			// 
			// textBox_tools_log_logSource
			// 
			this.textBox_tools_log_logSource.Location = new System.Drawing.Point(348, 121);
			this.textBox_tools_log_logSource.Name = "textBox_tools_log_logSource";
			this.textBox_tools_log_logSource.Size = new System.Drawing.Size(193, 20);
			this.textBox_tools_log_logSource.TabIndex = 17;
			// 
			// textBox_tools_log_logMessage
			// 
			this.textBox_tools_log_logMessage.Location = new System.Drawing.Point(348, 95);
			this.textBox_tools_log_logMessage.Name = "textBox_tools_log_logMessage";
			this.textBox_tools_log_logMessage.Size = new System.Drawing.Size(193, 20);
			this.textBox_tools_log_logMessage.TabIndex = 16;
			// 
			// comboBox_tools_log_logType
			// 
			this.comboBox_tools_log_logType.FormattingEnabled = true;
			this.comboBox_tools_log_logType.Items.AddRange(new object[] {
            "INFO",
            "ERROR",
            "WARNING"});
			this.comboBox_tools_log_logType.Location = new System.Drawing.Point(348, 147);
			this.comboBox_tools_log_logType.Name = "comboBox_tools_log_logType";
			this.comboBox_tools_log_logType.Size = new System.Drawing.Size(193, 21);
			this.comboBox_tools_log_logType.TabIndex = 18;
			// 
			// label_tools_log_source
			// 
			this.label_tools_log_source.AutoSize = true;
			this.label_tools_log_source.Location = new System.Drawing.Point(298, 124);
			this.label_tools_log_source.Name = "label_tools_log_source";
			this.label_tools_log_source.Size = new System.Drawing.Size(44, 13);
			this.label_tools_log_source.TabIndex = 20;
			this.label_tools_log_source.Text = "Source:";
			// 
			// button_tools_log_log
			// 
			this.button_tools_log_log.Location = new System.Drawing.Point(455, 174);
			this.button_tools_log_log.Name = "button_tools_log_log";
			this.button_tools_log_log.Size = new System.Drawing.Size(86, 22);
			this.button_tools_log_log.TabIndex = 15;
			this.button_tools_log_log.Text = "Log";
			this.button_tools_log_log.UseVisualStyleBackColor = true;
			// 
			// tab_tools_getDate
			// 
			this.tab_tools_getDate.Controls.Add(this.label_tools_getDate_date);
			this.tab_tools_getDate.Location = new System.Drawing.Point(4, 22);
			this.tab_tools_getDate.Name = "tab_tools_getDate";
			this.tab_tools_getDate.Padding = new System.Windows.Forms.Padding(3);
			this.tab_tools_getDate.Size = new System.Drawing.Size(830, 290);
			this.tab_tools_getDate.TabIndex = 5;
			this.tab_tools_getDate.Text = "Get Date";
			this.tab_tools_getDate.UseVisualStyleBackColor = true;
			// 
			// label_tools_getDate_date
			// 
			this.label_tools_getDate_date.AutoSize = true;
			this.label_tools_getDate_date.Location = new System.Drawing.Point(351, 139);
			this.label_tools_getDate_date.Name = "label_tools_getDate_date";
			this.label_tools_getDate_date.Size = new System.Drawing.Size(129, 13);
			this.label_tools_getDate_date.TabIndex = 16;
			this.label_tools_getDate_date.Text = "<date (updates on code)>";
			// 
			// tab_tools_setWallpaper6getGifFrames
			// 
			this.tab_tools_setWallpaper6getGifFrames.Controls.Add(this.button_tools_setWallpaper6getGifFrames_searchGif);
			this.tab_tools_setWallpaper6getGifFrames.Controls.Add(this.pictureBox_tools_setWallpaper6getGifFrames_gif);
			this.tab_tools_setWallpaper6getGifFrames.Controls.Add(this.button_tools_setWallpaper6getGifFrames_setWallpaper);
			this.tab_tools_setWallpaper6getGifFrames.Location = new System.Drawing.Point(4, 22);
			this.tab_tools_setWallpaper6getGifFrames.Name = "tab_tools_setWallpaper6getGifFrames";
			this.tab_tools_setWallpaper6getGifFrames.Padding = new System.Windows.Forms.Padding(3);
			this.tab_tools_setWallpaper6getGifFrames.Size = new System.Drawing.Size(830, 290);
			this.tab_tools_setWallpaper6getGifFrames.TabIndex = 6;
			this.tab_tools_setWallpaper6getGifFrames.Text = "Set Wallpaper && Get GIF Frames";
			this.tab_tools_setWallpaper6getGifFrames.UseVisualStyleBackColor = true;
			// 
			// button_tools_setWallpaper6getGifFrames_searchGif
			// 
			this.button_tools_setWallpaper6getGifFrames_searchGif.Location = new System.Drawing.Point(323, 209);
			this.button_tools_setWallpaper6getGifFrames_searchGif.Name = "button_tools_setWallpaper6getGifFrames_searchGif";
			this.button_tools_setWallpaper6getGifFrames_searchGif.Size = new System.Drawing.Size(92, 23);
			this.button_tools_setWallpaper6getGifFrames_searchGif.TabIndex = 2;
			this.button_tools_setWallpaper6getGifFrames_searchGif.Text = "Search GIF";
			this.button_tools_setWallpaper6getGifFrames_searchGif.UseVisualStyleBackColor = true;
			// 
			// pictureBox_tools_setWallpaper6getGifFrames_gif
			// 
			this.pictureBox_tools_setWallpaper6getGifFrames_gif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_tools_setWallpaper6getGifFrames_gif.Location = new System.Drawing.Point(323, 59);
			this.pictureBox_tools_setWallpaper6getGifFrames_gif.Name = "pictureBox_tools_setWallpaper6getGifFrames_gif";
			this.pictureBox_tools_setWallpaper6getGifFrames_gif.Size = new System.Drawing.Size(182, 144);
			this.pictureBox_tools_setWallpaper6getGifFrames_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_tools_setWallpaper6getGifFrames_gif.TabIndex = 1;
			this.pictureBox_tools_setWallpaper6getGifFrames_gif.TabStop = false;
			// 
			// button_tools_setWallpaper6getGifFrames_setWallpaper
			// 
			this.button_tools_setWallpaper6getGifFrames_setWallpaper.Location = new System.Drawing.Point(414, 209);
			this.button_tools_setWallpaper6getGifFrames_setWallpaper.Name = "button_tools_setWallpaper6getGifFrames_setWallpaper";
			this.button_tools_setWallpaper6getGifFrames_setWallpaper.Size = new System.Drawing.Size(93, 23);
			this.button_tools_setWallpaper6getGifFrames_setWallpaper.TabIndex = 0;
			this.button_tools_setWallpaper6getGifFrames_setWallpaper.Text = "Set Wallpaper";
			this.button_tools_setWallpaper6getGifFrames_setWallpaper.UseVisualStyleBackColor = true;
			// 
			// tab_generators
			// 
			this.tab_generators.Controls.Add(this.tabs_generators);
			this.tab_generators.Location = new System.Drawing.Point(4, 22);
			this.tab_generators.Name = "tab_generators";
			this.tab_generators.Padding = new System.Windows.Forms.Padding(3);
			this.tab_generators.Size = new System.Drawing.Size(844, 322);
			this.tab_generators.TabIndex = 3;
			this.tab_generators.Text = "Generators";
			this.tab_generators.UseVisualStyleBackColor = true;
			// 
			// tabs_generators
			// 
			this.tabs_generators.Controls.Add(this.tab_generators_generatePassword);
			this.tabs_generators.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_generators.Location = new System.Drawing.Point(3, 3);
			this.tabs_generators.Name = "tabs_generators";
			this.tabs_generators.SelectedIndex = 0;
			this.tabs_generators.Size = new System.Drawing.Size(838, 316);
			this.tabs_generators.TabIndex = 0;
			// 
			// tab_generators_generatePassword
			// 
			this.tab_generators_generatePassword.Controls.Add(this.label_generators_generatePassword_allowedChars);
			this.tab_generators_generatePassword.Controls.Add(this.textBox_generators_generatePassword_allowedChars);
			this.tab_generators_generatePassword.Controls.Add(this._generators_generatePassword_length);
			this.tab_generators_generatePassword.Controls.Add(this.numeric_generators_generatePassword_length);
			this.tab_generators_generatePassword.Controls.Add(this.textBox_generators_generatePassword_password);
			this.tab_generators_generatePassword.Controls.Add(this.button_generators_generatePassword_generate);
			this.tab_generators_generatePassword.Location = new System.Drawing.Point(4, 22);
			this.tab_generators_generatePassword.Name = "tab_generators_generatePassword";
			this.tab_generators_generatePassword.Padding = new System.Windows.Forms.Padding(3);
			this.tab_generators_generatePassword.Size = new System.Drawing.Size(830, 290);
			this.tab_generators_generatePassword.TabIndex = 0;
			this.tab_generators_generatePassword.Text = "Generate Password";
			this.tab_generators_generatePassword.UseVisualStyleBackColor = true;
			// 
			// label_generators_generatePassword_allowedChars
			// 
			this.label_generators_generatePassword_allowedChars.AutoSize = true;
			this.label_generators_generatePassword_allowedChars.Location = new System.Drawing.Point(288, 131);
			this.label_generators_generatePassword_allowedChars.Name = "label_generators_generatePassword_allowedChars";
			this.label_generators_generatePassword_allowedChars.Size = new System.Drawing.Size(77, 13);
			this.label_generators_generatePassword_allowedChars.TabIndex = 15;
			this.label_generators_generatePassword_allowedChars.Text = "Allowed Chars:";
			// 
			// textBox_generators_generatePassword_allowedChars
			// 
			this.textBox_generators_generatePassword_allowedChars.Location = new System.Drawing.Point(287, 147);
			this.textBox_generators_generatePassword_allowedChars.Name = "textBox_generators_generatePassword_allowedChars";
			this.textBox_generators_generatePassword_allowedChars.Size = new System.Drawing.Size(256, 20);
			this.textBox_generators_generatePassword_allowedChars.TabIndex = 14;
			this.textBox_generators_generatePassword_allowedChars.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			// 
			// _generators_generatePassword_length
			// 
			this._generators_generatePassword_length.AutoSize = true;
			this._generators_generatePassword_length.Location = new System.Drawing.Point(288, 176);
			this._generators_generatePassword_length.Name = "_generators_generatePassword_length";
			this._generators_generatePassword_length.Size = new System.Drawing.Size(43, 13);
			this._generators_generatePassword_length.TabIndex = 13;
			this._generators_generatePassword_length.Text = "Length:";
			// 
			// tab_controls
			// 
			this.tab_controls.Controls.Add(this.tabs_controls);
			this.tab_controls.Location = new System.Drawing.Point(4, 22);
			this.tab_controls.Name = "tab_controls";
			this.tab_controls.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls.Size = new System.Drawing.Size(844, 322);
			this.tab_controls.TabIndex = 4;
			this.tab_controls.Text = "Controls";
			this.tab_controls.UseVisualStyleBackColor = true;
			// 
			// tabs_controls
			// 
			this.tabs_controls.Controls.Add(this.tab_controls_controls);
			this.tabs_controls.Controls.Add(this.tab_controls_tweaks);
			this.tabs_controls.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_controls.Location = new System.Drawing.Point(3, 3);
			this.tabs_controls.Name = "tabs_controls";
			this.tabs_controls.SelectedIndex = 0;
			this.tabs_controls.Size = new System.Drawing.Size(838, 316);
			this.tabs_controls.TabIndex = 0;
			// 
			// tab_controls_controls
			// 
			this.tab_controls_controls.Controls.Add(this.tabs_controls_controls);
			this.tab_controls_controls.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_controls.Name = "tab_controls_controls";
			this.tab_controls_controls.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_controls.Size = new System.Drawing.Size(830, 290);
			this.tab_controls_controls.TabIndex = 0;
			this.tab_controls_controls.Text = "Controls";
			this.tab_controls_controls.UseVisualStyleBackColor = true;
			// 
			// tabs_controls_controls
			// 
			this.tabs_controls_controls.Controls.Add(this.tab_lineGraph);
			this.tabs_controls_controls.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_controls_controls.Location = new System.Drawing.Point(3, 3);
			this.tabs_controls_controls.Name = "tabs_controls_controls";
			this.tabs_controls_controls.SelectedIndex = 0;
			this.tabs_controls_controls.Size = new System.Drawing.Size(824, 284);
			this.tabs_controls_controls.TabIndex = 0;
			// 
			// tab_lineGraph
			// 
			this.tab_lineGraph.Controls.Add(this.button_lineGraph_drawTest);
			this.tab_lineGraph.Controls.Add(this.lineGraph);
			this.tab_lineGraph.Location = new System.Drawing.Point(4, 22);
			this.tab_lineGraph.Name = "tab_lineGraph";
			this.tab_lineGraph.Padding = new System.Windows.Forms.Padding(3);
			this.tab_lineGraph.Size = new System.Drawing.Size(816, 258);
			this.tab_lineGraph.TabIndex = 0;
			this.tab_lineGraph.Text = "Line Graph";
			this.tab_lineGraph.UseVisualStyleBackColor = true;
			// 
			// button_lineGraph_drawTest
			// 
			this.button_lineGraph_drawTest.Location = new System.Drawing.Point(308, 220);
			this.button_lineGraph_drawTest.Name = "button_lineGraph_drawTest";
			this.button_lineGraph_drawTest.Size = new System.Drawing.Size(200, 23);
			this.button_lineGraph_drawTest.TabIndex = 1;
			this.button_lineGraph_drawTest.Text = "Draw Test";
			this.button_lineGraph_drawTest.UseVisualStyleBackColor = true;
			this.button_lineGraph_drawTest.Click += new System.EventHandler(this.button_lineGraph_drawTest_Click);
			// 
			// tab_controls_tweaks
			// 
			this.tab_controls_tweaks.Controls.Add(this.tabs_controls_tweaks);
			this.tab_controls_tweaks.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_tweaks.Name = "tab_controls_tweaks";
			this.tab_controls_tweaks.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_tweaks.Size = new System.Drawing.Size(830, 290);
			this.tab_controls_tweaks.TabIndex = 1;
			this.tab_controls_tweaks.Text = "Tweaks";
			this.tab_controls_tweaks.UseVisualStyleBackColor = true;
			// 
			// tabs_controls_tweaks
			// 
			this.tabs_controls_tweaks.Controls.Add(this.tab_controls_tweaks_comboBox);
			this.tabs_controls_tweaks.Controls.Add(this.tab_controls_textBox);
			this.tabs_controls_tweaks.Controls.Add(this.tab_controls_form);
			this.tabs_controls_tweaks.Controls.Add(this.tab_controls_messageBox);
			this.tabs_controls_tweaks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_controls_tweaks.Location = new System.Drawing.Point(3, 3);
			this.tabs_controls_tweaks.Name = "tabs_controls_tweaks";
			this.tabs_controls_tweaks.SelectedIndex = 0;
			this.tabs_controls_tweaks.Size = new System.Drawing.Size(824, 284);
			this.tabs_controls_tweaks.TabIndex = 1;
			// 
			// tab_controls_tweaks_comboBox
			// 
			this.tab_controls_tweaks_comboBox.Controls.Add(this.tabs_controls_comboBox);
			this.tab_controls_tweaks_comboBox.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_tweaks_comboBox.Name = "tab_controls_tweaks_comboBox";
			this.tab_controls_tweaks_comboBox.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_tweaks_comboBox.Size = new System.Drawing.Size(816, 258);
			this.tab_controls_tweaks_comboBox.TabIndex = 0;
			this.tab_controls_tweaks_comboBox.Text = "ComboBox";
			this.tab_controls_tweaks_comboBox.UseVisualStyleBackColor = true;
			// 
			// tabs_controls_comboBox
			// 
			this.tabs_controls_comboBox.Controls.Add(this.tab_controls_comboBox_resizeComboBox);
			this.tabs_controls_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_controls_comboBox.Location = new System.Drawing.Point(3, 3);
			this.tabs_controls_comboBox.Name = "tabs_controls_comboBox";
			this.tabs_controls_comboBox.SelectedIndex = 0;
			this.tabs_controls_comboBox.Size = new System.Drawing.Size(810, 252);
			this.tabs_controls_comboBox.TabIndex = 0;
			// 
			// tab_controls_comboBox_resizeComboBox
			// 
			this.tab_controls_comboBox_resizeComboBox.Controls.Add(this.comboBox_controls_comboBox_resizeComboBox_resize);
			this.tab_controls_comboBox_resizeComboBox.Controls.Add(this.button_controls_comboBox_resizeComboBox_resize);
			this.tab_controls_comboBox_resizeComboBox.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_comboBox_resizeComboBox.Name = "tab_controls_comboBox_resizeComboBox";
			this.tab_controls_comboBox_resizeComboBox.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_comboBox_resizeComboBox.Size = new System.Drawing.Size(802, 226);
			this.tab_controls_comboBox_resizeComboBox.TabIndex = 0;
			this.tab_controls_comboBox_resizeComboBox.Text = "Resize ComboBox";
			this.tab_controls_comboBox_resizeComboBox.UseVisualStyleBackColor = true;
			// 
			// comboBox_controls_comboBox_resizeComboBox_resize
			// 
			this.comboBox_controls_comboBox_resizeComboBox_resize.FormattingEnabled = true;
			this.comboBox_controls_comboBox_resizeComboBox_resize.Location = new System.Drawing.Point(354, 95);
			this.comboBox_controls_comboBox_resizeComboBox_resize.Name = "comboBox_controls_comboBox_resizeComboBox_resize";
			this.comboBox_controls_comboBox_resizeComboBox_resize.Size = new System.Drawing.Size(141, 21);
			this.comboBox_controls_comboBox_resizeComboBox_resize.TabIndex = 16;
			// 
			// button_controls_comboBox_resizeComboBox_resize
			// 
			this.button_controls_comboBox_resizeComboBox_resize.Location = new System.Drawing.Point(307, 94);
			this.button_controls_comboBox_resizeComboBox_resize.Name = "button_controls_comboBox_resizeComboBox_resize";
			this.button_controls_comboBox_resizeComboBox_resize.Size = new System.Drawing.Size(47, 39);
			this.button_controls_comboBox_resizeComboBox_resize.TabIndex = 15;
			this.button_controls_comboBox_resizeComboBox_resize.Text = "Resize";
			this.button_controls_comboBox_resizeComboBox_resize.UseVisualStyleBackColor = true;
			// 
			// tab_controls_textBox
			// 
			this.tab_controls_textBox.Controls.Add(this.tabs_controls_textBox);
			this.tab_controls_textBox.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_textBox.Name = "tab_controls_textBox";
			this.tab_controls_textBox.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_textBox.Size = new System.Drawing.Size(816, 258);
			this.tab_controls_textBox.TabIndex = 1;
			this.tab_controls_textBox.Text = "TextBox";
			this.tab_controls_textBox.UseVisualStyleBackColor = true;
			// 
			// tabs_controls_textBox
			// 
			this.tabs_controls_textBox.Controls.Add(this.tab_controls_textBox_onlyNumbersTextBox);
			this.tabs_controls_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_controls_textBox.Location = new System.Drawing.Point(3, 3);
			this.tabs_controls_textBox.Name = "tabs_controls_textBox";
			this.tabs_controls_textBox.SelectedIndex = 0;
			this.tabs_controls_textBox.Size = new System.Drawing.Size(810, 252);
			this.tabs_controls_textBox.TabIndex = 0;
			// 
			// tab_controls_textBox_onlyNumbersTextBox
			// 
			this.tab_controls_textBox_onlyNumbersTextBox.Controls.Add(this.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers);
			this.tab_controls_textBox_onlyNumbersTextBox.Controls.Add(this.textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers);
			this.tab_controls_textBox_onlyNumbersTextBox.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_textBox_onlyNumbersTextBox.Name = "tab_controls_textBox_onlyNumbersTextBox";
			this.tab_controls_textBox_onlyNumbersTextBox.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_textBox_onlyNumbersTextBox.Size = new System.Drawing.Size(802, 226);
			this.tab_controls_textBox_onlyNumbersTextBox.TabIndex = 0;
			this.tab_controls_textBox_onlyNumbersTextBox.Text = "Only Numbers TextBox";
			this.tab_controls_textBox_onlyNumbersTextBox.UseVisualStyleBackColor = true;
			// 
			// checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers
			// 
			this.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.AutoSize = true;
			this.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Location = new System.Drawing.Point(308, 118);
			this.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Name = "checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers";
			this.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Size = new System.Drawing.Size(126, 17);
			this.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.TabIndex = 1;
			this.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Text = "Only accept numbers";
			this.checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.UseVisualStyleBackColor = true;
			// 
			// textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers
			// 
			this.textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Location = new System.Drawing.Point(308, 92);
			this.textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Name = "textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers";
			this.textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Size = new System.Drawing.Size(186, 20);
			this.textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.TabIndex = 0;
			// 
			// tab_controls_form
			// 
			this.tab_controls_form.Controls.Add(this.tabs_controls_form);
			this.tab_controls_form.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_form.Name = "tab_controls_form";
			this.tab_controls_form.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_form.Size = new System.Drawing.Size(816, 258);
			this.tab_controls_form.TabIndex = 3;
			this.tab_controls_form.Text = "Form";
			this.tab_controls_form.UseVisualStyleBackColor = true;
			// 
			// tabs_controls_form
			// 
			this.tabs_controls_form.Controls.Add(this.tab_controls_form_getOpenForms);
			this.tabs_controls_form.Controls.Add(this.tab_controls_form_allowDrag);
			this.tabs_controls_form.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_controls_form.Location = new System.Drawing.Point(3, 3);
			this.tabs_controls_form.Name = "tabs_controls_form";
			this.tabs_controls_form.SelectedIndex = 0;
			this.tabs_controls_form.Size = new System.Drawing.Size(810, 252);
			this.tabs_controls_form.TabIndex = 0;
			// 
			// tab_controls_form_getOpenForms
			// 
			this.tab_controls_form_getOpenForms.Controls.Add(this.button_controls_form_getOpenForms_getOpenForms);
			this.tab_controls_form_getOpenForms.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_form_getOpenForms.Name = "tab_controls_form_getOpenForms";
			this.tab_controls_form_getOpenForms.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_form_getOpenForms.Size = new System.Drawing.Size(802, 226);
			this.tab_controls_form_getOpenForms.TabIndex = 0;
			this.tab_controls_form_getOpenForms.Text = "Get Open Forms";
			this.tab_controls_form_getOpenForms.UseVisualStyleBackColor = true;
			// 
			// button_controls_form_getOpenForms_getOpenForms
			// 
			this.button_controls_form_getOpenForms_getOpenForms.Location = new System.Drawing.Point(307, 102);
			this.button_controls_form_getOpenForms_getOpenForms.Name = "button_controls_form_getOpenForms_getOpenForms";
			this.button_controls_form_getOpenForms_getOpenForms.Size = new System.Drawing.Size(188, 23);
			this.button_controls_form_getOpenForms_getOpenForms.TabIndex = 0;
			this.button_controls_form_getOpenForms_getOpenForms.Text = "Get Open Forms";
			this.button_controls_form_getOpenForms_getOpenForms.UseVisualStyleBackColor = true;
			// 
			// tab_controls_messageBox
			// 
			this.tab_controls_messageBox.Controls.Add(this.tabs_controls_messageBox);
			this.tab_controls_messageBox.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_messageBox.Name = "tab_controls_messageBox";
			this.tab_controls_messageBox.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_messageBox.Size = new System.Drawing.Size(816, 258);
			this.tab_controls_messageBox.TabIndex = 4;
			this.tab_controls_messageBox.Text = "MessageBox";
			this.tab_controls_messageBox.UseVisualStyleBackColor = true;
			// 
			// tabs_controls_messageBox
			// 
			this.tabs_controls_messageBox.Controls.Add(this.tab_controls_messageBox_showConfirmationDialog);
			this.tabs_controls_messageBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_controls_messageBox.Location = new System.Drawing.Point(3, 3);
			this.tabs_controls_messageBox.Name = "tabs_controls_messageBox";
			this.tabs_controls_messageBox.SelectedIndex = 0;
			this.tabs_controls_messageBox.Size = new System.Drawing.Size(810, 252);
			this.tabs_controls_messageBox.TabIndex = 0;
			// 
			// tab_controls_messageBox_showConfirmationDialog
			// 
			this.tab_controls_messageBox_showConfirmationDialog.Controls.Add(this.button_controls_messageBox_showConfirmationDialog_show);
			this.tab_controls_messageBox_showConfirmationDialog.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_messageBox_showConfirmationDialog.Name = "tab_controls_messageBox_showConfirmationDialog";
			this.tab_controls_messageBox_showConfirmationDialog.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_messageBox_showConfirmationDialog.Size = new System.Drawing.Size(802, 226);
			this.tab_controls_messageBox_showConfirmationDialog.TabIndex = 0;
			this.tab_controls_messageBox_showConfirmationDialog.Text = "Show Confirmation Dialog";
			this.tab_controls_messageBox_showConfirmationDialog.UseVisualStyleBackColor = true;
			// 
			// button_controls_messageBox_showConfirmationDialog_show
			// 
			this.button_controls_messageBox_showConfirmationDialog_show.Location = new System.Drawing.Point(307, 102);
			this.button_controls_messageBox_showConfirmationDialog_show.Name = "button_controls_messageBox_showConfirmationDialog_show";
			this.button_controls_messageBox_showConfirmationDialog_show.Size = new System.Drawing.Size(188, 23);
			this.button_controls_messageBox_showConfirmationDialog_show.TabIndex = 0;
			this.button_controls_messageBox_showConfirmationDialog_show.Text = "Show Confirmation Dialog";
			this.button_controls_messageBox_showConfirmationDialog_show.UseVisualStyleBackColor = true;
			// 
			// tab_network
			// 
			this.tab_network.Controls.Add(this.tabs_network);
			this.tab_network.Location = new System.Drawing.Point(4, 22);
			this.tab_network.Name = "tab_network";
			this.tab_network.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network.Size = new System.Drawing.Size(844, 322);
			this.tab_network.TabIndex = 5;
			this.tab_network.Text = "Network";
			this.tab_network.UseVisualStyleBackColor = true;
			// 
			// tabs_network
			// 
			this.tabs_network.Controls.Add(this.tab_network_wifi);
			this.tabs_network.Controls.Add(this.tab_network_packets);
			this.tabs_network.Controls.Add(this.tab_network_mobile);
			this.tabs_network.Controls.Add(this.tab_network_security);
			this.tabs_network.Controls.Add(this.tab_network_requests);
			this.tabs_network.Controls.Add(this.tab_network_apis);
			this.tabs_network.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_network.Location = new System.Drawing.Point(3, 3);
			this.tabs_network.Name = "tabs_network";
			this.tabs_network.SelectedIndex = 0;
			this.tabs_network.Size = new System.Drawing.Size(838, 316);
			this.tabs_network.TabIndex = 0;
			// 
			// tab_network_wifi
			// 
			this.tab_network_wifi.Controls.Add(this.tabs_network_wifi);
			this.tab_network_wifi.Location = new System.Drawing.Point(4, 22);
			this.tab_network_wifi.Name = "tab_network_wifi";
			this.tab_network_wifi.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_wifi.Size = new System.Drawing.Size(830, 290);
			this.tab_network_wifi.TabIndex = 0;
			this.tab_network_wifi.Text = "Wi-Fi";
			this.tab_network_wifi.UseVisualStyleBackColor = true;
			// 
			// tabs_network_wifi
			// 
			this.tabs_network_wifi.Controls.Add(this.tab_network_wifi_connect);
			this.tabs_network_wifi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_network_wifi.Location = new System.Drawing.Point(3, 3);
			this.tabs_network_wifi.Name = "tabs_network_wifi";
			this.tabs_network_wifi.SelectedIndex = 0;
			this.tabs_network_wifi.Size = new System.Drawing.Size(824, 284);
			this.tabs_network_wifi.TabIndex = 0;
			// 
			// tab_network_wifi_connect
			// 
			this.tab_network_wifi_connect.Controls.Add(this.button_network_wifi_connect_connect);
			this.tab_network_wifi_connect.Controls.Add(this.label_network_wifi_connect_ssid);
			this.tab_network_wifi_connect.Controls.Add(this.label_network_wifi_connect_password);
			this.tab_network_wifi_connect.Controls.Add(this.textBox_network_wifi_connect_wifiSsid);
			this.tab_network_wifi_connect.Controls.Add(this.textBox_network_wifi_connect_wifiPassword);
			this.tab_network_wifi_connect.Location = new System.Drawing.Point(4, 22);
			this.tab_network_wifi_connect.Name = "tab_network_wifi_connect";
			this.tab_network_wifi_connect.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_wifi_connect.Size = new System.Drawing.Size(816, 258);
			this.tab_network_wifi_connect.TabIndex = 0;
			this.tab_network_wifi_connect.Text = "Connect";
			this.tab_network_wifi_connect.UseVisualStyleBackColor = true;
			// 
			// tab_network_packets
			// 
			this.tab_network_packets.Controls.Add(this.tabs_network_packets);
			this.tab_network_packets.Location = new System.Drawing.Point(4, 22);
			this.tab_network_packets.Name = "tab_network_packets";
			this.tab_network_packets.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_packets.Size = new System.Drawing.Size(830, 290);
			this.tab_network_packets.TabIndex = 1;
			this.tab_network_packets.Text = "Packets";
			this.tab_network_packets.UseVisualStyleBackColor = true;
			// 
			// tabs_network_packets
			// 
			this.tabs_network_packets.Controls.Add(this.tab_network_packets_sendTcpPacket);
			this.tabs_network_packets.Controls.Add(this.tab_network_packets_waitTcpPacket);
			this.tabs_network_packets.Controls.Add(this.tab_network_packets_sendUdpPacket);
			this.tabs_network_packets.Controls.Add(this.tab_network_packets_waitUdpPacket);
			this.tabs_network_packets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_network_packets.Location = new System.Drawing.Point(3, 3);
			this.tabs_network_packets.Name = "tabs_network_packets";
			this.tabs_network_packets.SelectedIndex = 0;
			this.tabs_network_packets.Size = new System.Drawing.Size(824, 284);
			this.tabs_network_packets.TabIndex = 0;
			// 
			// tab_network_packets_sendTcpPacket
			// 
			this.tab_network_packets_sendTcpPacket.Controls.Add(this.label_network_packets_sendTcpPacket_message);
			this.tab_network_packets_sendTcpPacket.Controls.Add(this.label_network_packets_sendTcpPacket_remotePort);
			this.tab_network_packets_sendTcpPacket.Controls.Add(this.label_network_packets_sendTcpPacket_remoteIp);
			this.tab_network_packets_sendTcpPacket.Controls.Add(this.textBox_network_packets_sendTcpPacket_message);
			this.tab_network_packets_sendTcpPacket.Controls.Add(this.textBox_network_packets_sendTcpPacket_remoteIp);
			this.tab_network_packets_sendTcpPacket.Controls.Add(this.numeric_network_packets_sendTcpPacket_remotePort);
			this.tab_network_packets_sendTcpPacket.Controls.Add(this.button_network_packets_sendTcpPacket_send);
			this.tab_network_packets_sendTcpPacket.Location = new System.Drawing.Point(4, 22);
			this.tab_network_packets_sendTcpPacket.Name = "tab_network_packets_sendTcpPacket";
			this.tab_network_packets_sendTcpPacket.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_packets_sendTcpPacket.Size = new System.Drawing.Size(816, 258);
			this.tab_network_packets_sendTcpPacket.TabIndex = 0;
			this.tab_network_packets_sendTcpPacket.Text = "Send TCP Packet";
			this.tab_network_packets_sendTcpPacket.UseVisualStyleBackColor = true;
			// 
			// label_network_packets_sendTcpPacket_message
			// 
			this.label_network_packets_sendTcpPacket_message.AutoSize = true;
			this.label_network_packets_sendTcpPacket_message.Location = new System.Drawing.Point(236, 145);
			this.label_network_packets_sendTcpPacket_message.Name = "label_network_packets_sendTcpPacket_message";
			this.label_network_packets_sendTcpPacket_message.Size = new System.Drawing.Size(53, 13);
			this.label_network_packets_sendTcpPacket_message.TabIndex = 41;
			this.label_network_packets_sendTcpPacket_message.Text = "Message:";
			// 
			// label_network_packets_sendTcpPacket_remotePort
			// 
			this.label_network_packets_sendTcpPacket_remotePort.AutoSize = true;
			this.label_network_packets_sendTcpPacket_remotePort.Location = new System.Drawing.Point(220, 96);
			this.label_network_packets_sendTcpPacket_remotePort.Name = "label_network_packets_sendTcpPacket_remotePort";
			this.label_network_packets_sendTcpPacket_remotePort.Size = new System.Drawing.Size(69, 13);
			this.label_network_packets_sendTcpPacket_remotePort.TabIndex = 40;
			this.label_network_packets_sendTcpPacket_remotePort.Text = "Remote Port:";
			// 
			// label_network_packets_sendTcpPacket_remoteIp
			// 
			this.label_network_packets_sendTcpPacket_remoteIp.AutoSize = true;
			this.label_network_packets_sendTcpPacket_remoteIp.Location = new System.Drawing.Point(229, 71);
			this.label_network_packets_sendTcpPacket_remoteIp.Name = "label_network_packets_sendTcpPacket_remoteIp";
			this.label_network_packets_sendTcpPacket_remoteIp.Size = new System.Drawing.Size(60, 13);
			this.label_network_packets_sendTcpPacket_remoteIp.TabIndex = 39;
			this.label_network_packets_sendTcpPacket_remoteIp.Text = "Remote IP:";
			// 
			// textBox_network_packets_sendTcpPacket_message
			// 
			this.textBox_network_packets_sendTcpPacket_message.Location = new System.Drawing.Point(295, 142);
			this.textBox_network_packets_sendTcpPacket_message.Name = "textBox_network_packets_sendTcpPacket_message";
			this.textBox_network_packets_sendTcpPacket_message.Size = new System.Drawing.Size(302, 20);
			this.textBox_network_packets_sendTcpPacket_message.TabIndex = 38;
			// 
			// textBox_network_packets_sendTcpPacket_remoteIp
			// 
			this.textBox_network_packets_sendTcpPacket_remoteIp.Location = new System.Drawing.Point(295, 68);
			this.textBox_network_packets_sendTcpPacket_remoteIp.Name = "textBox_network_packets_sendTcpPacket_remoteIp";
			this.textBox_network_packets_sendTcpPacket_remoteIp.Size = new System.Drawing.Size(146, 20);
			this.textBox_network_packets_sendTcpPacket_remoteIp.TabIndex = 37;
			this.textBox_network_packets_sendTcpPacket_remoteIp.Text = "127.0.0.1";
			// 
			// numeric_network_packets_sendTcpPacket_remotePort
			// 
			this.numeric_network_packets_sendTcpPacket_remotePort.Location = new System.Drawing.Point(295, 94);
			this.numeric_network_packets_sendTcpPacket_remotePort.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numeric_network_packets_sendTcpPacket_remotePort.Name = "numeric_network_packets_sendTcpPacket_remotePort";
			this.numeric_network_packets_sendTcpPacket_remotePort.Size = new System.Drawing.Size(146, 20);
			this.numeric_network_packets_sendTcpPacket_remotePort.TabIndex = 36;
			this.numeric_network_packets_sendTcpPacket_remotePort.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
			// 
			// button_network_packets_sendTcpPacket_send
			// 
			this.button_network_packets_sendTcpPacket_send.Location = new System.Drawing.Point(481, 168);
			this.button_network_packets_sendTcpPacket_send.Name = "button_network_packets_sendTcpPacket_send";
			this.button_network_packets_sendTcpPacket_send.Size = new System.Drawing.Size(116, 23);
			this.button_network_packets_sendTcpPacket_send.TabIndex = 35;
			this.button_network_packets_sendTcpPacket_send.Text = "Send TCP Packet";
			this.button_network_packets_sendTcpPacket_send.UseVisualStyleBackColor = true;
			// 
			// tab_network_packets_waitTcpPacket
			// 
			this.tab_network_packets_waitTcpPacket.Controls.Add(this.label_network_packets_waitTcpPacket_localPort);
			this.tab_network_packets_waitTcpPacket.Controls.Add(this.numeric_network_packets_waitTcpPacket_localPort);
			this.tab_network_packets_waitTcpPacket.Controls.Add(this.button_network_packets_waitTcpPacket_wait);
			this.tab_network_packets_waitTcpPacket.Location = new System.Drawing.Point(4, 22);
			this.tab_network_packets_waitTcpPacket.Name = "tab_network_packets_waitTcpPacket";
			this.tab_network_packets_waitTcpPacket.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_packets_waitTcpPacket.Size = new System.Drawing.Size(816, 258);
			this.tab_network_packets_waitTcpPacket.TabIndex = 1;
			this.tab_network_packets_waitTcpPacket.Text = "Wait TCP Packet";
			this.tab_network_packets_waitTcpPacket.UseVisualStyleBackColor = true;
			// 
			// label_network_packets_waitTcpPacket_localPort
			// 
			this.label_network_packets_waitTcpPacket_localPort.AutoSize = true;
			this.label_network_packets_waitTcpPacket_localPort.Location = new System.Drawing.Point(322, 107);
			this.label_network_packets_waitTcpPacket_localPort.Name = "label_network_packets_waitTcpPacket_localPort";
			this.label_network_packets_waitTcpPacket_localPort.Size = new System.Drawing.Size(58, 13);
			this.label_network_packets_waitTcpPacket_localPort.TabIndex = 32;
			this.label_network_packets_waitTcpPacket_localPort.Text = "Local Port:";
			// 
			// numeric_network_packets_waitTcpPacket_localPort
			// 
			this.numeric_network_packets_waitTcpPacket_localPort.Location = new System.Drawing.Point(386, 105);
			this.numeric_network_packets_waitTcpPacket_localPort.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numeric_network_packets_waitTcpPacket_localPort.Name = "numeric_network_packets_waitTcpPacket_localPort";
			this.numeric_network_packets_waitTcpPacket_localPort.Size = new System.Drawing.Size(109, 20);
			this.numeric_network_packets_waitTcpPacket_localPort.TabIndex = 31;
			this.numeric_network_packets_waitTcpPacket_localPort.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
			// 
			// button_network_packets_waitTcpPacket_wait
			// 
			this.button_network_packets_waitTcpPacket_wait.Location = new System.Drawing.Point(386, 131);
			this.button_network_packets_waitTcpPacket_wait.Name = "button_network_packets_waitTcpPacket_wait";
			this.button_network_packets_waitTcpPacket_wait.Size = new System.Drawing.Size(109, 23);
			this.button_network_packets_waitTcpPacket_wait.TabIndex = 30;
			this.button_network_packets_waitTcpPacket_wait.Text = "Start TCP Server";
			this.button_network_packets_waitTcpPacket_wait.UseVisualStyleBackColor = true;
			// 
			// tab_network_packets_sendUdpPacket
			// 
			this.tab_network_packets_sendUdpPacket.Controls.Add(this.label_network_packets_sendUdpPacket_message);
			this.tab_network_packets_sendUdpPacket.Controls.Add(this.label_network_packets_sendUdpPacket_remotePort);
			this.tab_network_packets_sendUdpPacket.Controls.Add(this.label_network_packets_sendUdpPacket_remoteIp);
			this.tab_network_packets_sendUdpPacket.Controls.Add(this.textBox_network_packets_sendUdpPacket_message);
			this.tab_network_packets_sendUdpPacket.Controls.Add(this.textBox_network_packets_sendUdpPacket_remoteIp);
			this.tab_network_packets_sendUdpPacket.Controls.Add(this.numeric_network_packets_sendUdpPacket_remotePort);
			this.tab_network_packets_sendUdpPacket.Controls.Add(this.button_network_packets_sendUdpPacket_send);
			this.tab_network_packets_sendUdpPacket.Location = new System.Drawing.Point(4, 22);
			this.tab_network_packets_sendUdpPacket.Name = "tab_network_packets_sendUdpPacket";
			this.tab_network_packets_sendUdpPacket.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_packets_sendUdpPacket.Size = new System.Drawing.Size(816, 258);
			this.tab_network_packets_sendUdpPacket.TabIndex = 2;
			this.tab_network_packets_sendUdpPacket.Text = "Send UDP Packet";
			this.tab_network_packets_sendUdpPacket.UseVisualStyleBackColor = true;
			// 
			// label_network_packets_sendUdpPacket_message
			// 
			this.label_network_packets_sendUdpPacket_message.AutoSize = true;
			this.label_network_packets_sendUdpPacket_message.Location = new System.Drawing.Point(236, 145);
			this.label_network_packets_sendUdpPacket_message.Name = "label_network_packets_sendUdpPacket_message";
			this.label_network_packets_sendUdpPacket_message.Size = new System.Drawing.Size(53, 13);
			this.label_network_packets_sendUdpPacket_message.TabIndex = 34;
			this.label_network_packets_sendUdpPacket_message.Text = "Message:";
			// 
			// label_network_packets_sendUdpPacket_remotePort
			// 
			this.label_network_packets_sendUdpPacket_remotePort.AutoSize = true;
			this.label_network_packets_sendUdpPacket_remotePort.Location = new System.Drawing.Point(220, 96);
			this.label_network_packets_sendUdpPacket_remotePort.Name = "label_network_packets_sendUdpPacket_remotePort";
			this.label_network_packets_sendUdpPacket_remotePort.Size = new System.Drawing.Size(69, 13);
			this.label_network_packets_sendUdpPacket_remotePort.TabIndex = 33;
			this.label_network_packets_sendUdpPacket_remotePort.Text = "Remote Port:";
			// 
			// label_network_packets_sendUdpPacket_remoteIp
			// 
			this.label_network_packets_sendUdpPacket_remoteIp.AutoSize = true;
			this.label_network_packets_sendUdpPacket_remoteIp.Location = new System.Drawing.Point(229, 71);
			this.label_network_packets_sendUdpPacket_remoteIp.Name = "label_network_packets_sendUdpPacket_remoteIp";
			this.label_network_packets_sendUdpPacket_remoteIp.Size = new System.Drawing.Size(60, 13);
			this.label_network_packets_sendUdpPacket_remoteIp.TabIndex = 32;
			this.label_network_packets_sendUdpPacket_remoteIp.Text = "Remote IP:";
			// 
			// textBox_network_packets_sendUdpPacket_message
			// 
			this.textBox_network_packets_sendUdpPacket_message.Location = new System.Drawing.Point(295, 142);
			this.textBox_network_packets_sendUdpPacket_message.Name = "textBox_network_packets_sendUdpPacket_message";
			this.textBox_network_packets_sendUdpPacket_message.Size = new System.Drawing.Size(302, 20);
			this.textBox_network_packets_sendUdpPacket_message.TabIndex = 31;
			// 
			// textBox_network_packets_sendUdpPacket_remoteIp
			// 
			this.textBox_network_packets_sendUdpPacket_remoteIp.Location = new System.Drawing.Point(295, 68);
			this.textBox_network_packets_sendUdpPacket_remoteIp.Name = "textBox_network_packets_sendUdpPacket_remoteIp";
			this.textBox_network_packets_sendUdpPacket_remoteIp.Size = new System.Drawing.Size(146, 20);
			this.textBox_network_packets_sendUdpPacket_remoteIp.TabIndex = 30;
			this.textBox_network_packets_sendUdpPacket_remoteIp.Text = "127.0.0.1";
			// 
			// numeric_network_packets_sendUdpPacket_remotePort
			// 
			this.numeric_network_packets_sendUdpPacket_remotePort.Location = new System.Drawing.Point(295, 94);
			this.numeric_network_packets_sendUdpPacket_remotePort.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numeric_network_packets_sendUdpPacket_remotePort.Name = "numeric_network_packets_sendUdpPacket_remotePort";
			this.numeric_network_packets_sendUdpPacket_remotePort.Size = new System.Drawing.Size(146, 20);
			this.numeric_network_packets_sendUdpPacket_remotePort.TabIndex = 29;
			this.numeric_network_packets_sendUdpPacket_remotePort.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
			// 
			// button_network_packets_sendUdpPacket_send
			// 
			this.button_network_packets_sendUdpPacket_send.Location = new System.Drawing.Point(481, 168);
			this.button_network_packets_sendUdpPacket_send.Name = "button_network_packets_sendUdpPacket_send";
			this.button_network_packets_sendUdpPacket_send.Size = new System.Drawing.Size(116, 23);
			this.button_network_packets_sendUdpPacket_send.TabIndex = 28;
			this.button_network_packets_sendUdpPacket_send.Text = "Send UDP Packet";
			this.button_network_packets_sendUdpPacket_send.UseVisualStyleBackColor = true;
			// 
			// tab_network_packets_waitUdpPacket
			// 
			this.tab_network_packets_waitUdpPacket.Controls.Add(this.label_network_packets_waitUdpPacket_localPort);
			this.tab_network_packets_waitUdpPacket.Controls.Add(this.numeric_network_packets_waitUdpPacket_localPort);
			this.tab_network_packets_waitUdpPacket.Controls.Add(this.button_network_packets_waitUdpPacket_wait);
			this.tab_network_packets_waitUdpPacket.Location = new System.Drawing.Point(4, 22);
			this.tab_network_packets_waitUdpPacket.Name = "tab_network_packets_waitUdpPacket";
			this.tab_network_packets_waitUdpPacket.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_packets_waitUdpPacket.Size = new System.Drawing.Size(816, 258);
			this.tab_network_packets_waitUdpPacket.TabIndex = 3;
			this.tab_network_packets_waitUdpPacket.Text = "Wait UDP Packet";
			this.tab_network_packets_waitUdpPacket.UseVisualStyleBackColor = true;
			// 
			// label_network_packets_waitUdpPacket_localPort
			// 
			this.label_network_packets_waitUdpPacket_localPort.AutoSize = true;
			this.label_network_packets_waitUdpPacket_localPort.Location = new System.Drawing.Point(322, 107);
			this.label_network_packets_waitUdpPacket_localPort.Name = "label_network_packets_waitUdpPacket_localPort";
			this.label_network_packets_waitUdpPacket_localPort.Size = new System.Drawing.Size(58, 13);
			this.label_network_packets_waitUdpPacket_localPort.TabIndex = 29;
			this.label_network_packets_waitUdpPacket_localPort.Text = "Local Port:";
			// 
			// numeric_network_packets_waitUdpPacket_localPort
			// 
			this.numeric_network_packets_waitUdpPacket_localPort.Location = new System.Drawing.Point(386, 105);
			this.numeric_network_packets_waitUdpPacket_localPort.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numeric_network_packets_waitUdpPacket_localPort.Name = "numeric_network_packets_waitUdpPacket_localPort";
			this.numeric_network_packets_waitUdpPacket_localPort.Size = new System.Drawing.Size(109, 20);
			this.numeric_network_packets_waitUdpPacket_localPort.TabIndex = 28;
			this.numeric_network_packets_waitUdpPacket_localPort.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
			// 
			// button_network_packets_waitUdpPacket_wait
			// 
			this.button_network_packets_waitUdpPacket_wait.Location = new System.Drawing.Point(386, 131);
			this.button_network_packets_waitUdpPacket_wait.Name = "button_network_packets_waitUdpPacket_wait";
			this.button_network_packets_waitUdpPacket_wait.Size = new System.Drawing.Size(109, 23);
			this.button_network_packets_waitUdpPacket_wait.TabIndex = 27;
			this.button_network_packets_waitUdpPacket_wait.Text = "Start UDP Server";
			this.button_network_packets_waitUdpPacket_wait.UseVisualStyleBackColor = true;
			// 
			// tab_network_mobile
			// 
			this.tab_network_mobile.Controls.Add(this.tabs_network_mobile);
			this.tab_network_mobile.Location = new System.Drawing.Point(4, 22);
			this.tab_network_mobile.Name = "tab_network_mobile";
			this.tab_network_mobile.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_mobile.Size = new System.Drawing.Size(830, 290);
			this.tab_network_mobile.TabIndex = 2;
			this.tab_network_mobile.Text = "Mobile";
			this.tab_network_mobile.UseVisualStyleBackColor = true;
			// 
			// tabs_network_mobile
			// 
			this.tabs_network_mobile.Controls.Add(this.tab_network_mobile_sendSms);
			this.tabs_network_mobile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_network_mobile.Location = new System.Drawing.Point(3, 3);
			this.tabs_network_mobile.Name = "tabs_network_mobile";
			this.tabs_network_mobile.SelectedIndex = 0;
			this.tabs_network_mobile.Size = new System.Drawing.Size(824, 284);
			this.tabs_network_mobile.TabIndex = 0;
			// 
			// tab_network_mobile_sendSms
			// 
			this.tab_network_mobile_sendSms.Controls.Add(this.numeric_network_mobile_sendSms_smtpPort);
			this.tab_network_mobile_sendSms.Controls.Add(this.label_network_mobile_sendSms_smtpPort);
			this.tab_network_mobile_sendSms.Controls.Add(this.label_network_mobile_sendSms_smtpHost);
			this.tab_network_mobile_sendSms.Controls.Add(this.textBox_network_mobile_sendSms_smtpHost);
			this.tab_network_mobile_sendSms.Controls.Add(this.label_network_mobile_sendSms_smsCarrier);
			this.tab_network_mobile_sendSms.Controls.Add(this.textBox_network_mobile_sendSms_smsCarrier);
			this.tab_network_mobile_sendSms.Controls.Add(this.button_network_mobile_sendSms_sendSms);
			this.tab_network_mobile_sendSms.Controls.Add(this.label_network_mobile_sendSms_message);
			this.tab_network_mobile_sendSms.Controls.Add(this.textBox_network_mobile_sendSms_message);
			this.tab_network_mobile_sendSms.Controls.Add(this.label_network_mobile_sendSms_subject);
			this.tab_network_mobile_sendSms.Controls.Add(this.textBox_network_mobile_sendSms_subject);
			this.tab_network_mobile_sendSms.Controls.Add(this.label_network_mobile_sendSms_receiverPhone);
			this.tab_network_mobile_sendSms.Controls.Add(this.textBox_network_mobile_sendSms_receiverPhone);
			this.tab_network_mobile_sendSms.Controls.Add(this.label_network_mobile_sendSms_senderEmailPassword);
			this.tab_network_mobile_sendSms.Controls.Add(this.label_network_mobile_sendSms_senderEmail);
			this.tab_network_mobile_sendSms.Controls.Add(this.textBox_network_mobile_sendSms_senderEmailPassword);
			this.tab_network_mobile_sendSms.Controls.Add(this.textBox_network_mobile_sendSms_senderEmail);
			this.tab_network_mobile_sendSms.Location = new System.Drawing.Point(4, 22);
			this.tab_network_mobile_sendSms.Name = "tab_network_mobile_sendSms";
			this.tab_network_mobile_sendSms.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_mobile_sendSms.Size = new System.Drawing.Size(816, 258);
			this.tab_network_mobile_sendSms.TabIndex = 0;
			this.tab_network_mobile_sendSms.Text = "Send SMS";
			this.tab_network_mobile_sendSms.UseVisualStyleBackColor = true;
			// 
			// numeric_network_mobile_sendSms_smtpPort
			// 
			this.numeric_network_mobile_sendSms_smtpPort.Location = new System.Drawing.Point(578, 98);
			this.numeric_network_mobile_sendSms_smtpPort.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numeric_network_mobile_sendSms_smtpPort.Name = "numeric_network_mobile_sendSms_smtpPort";
			this.numeric_network_mobile_sendSms_smtpPort.Size = new System.Drawing.Size(136, 20);
			this.numeric_network_mobile_sendSms_smtpPort.TabIndex = 17;
			this.numeric_network_mobile_sendSms_smtpPort.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
			// 
			// label_network_mobile_sendSms_smtpPort
			// 
			this.label_network_mobile_sendSms_smtpPort.AutoSize = true;
			this.label_network_mobile_sendSms_smtpPort.Location = new System.Drawing.Point(510, 100);
			this.label_network_mobile_sendSms_smtpPort.Name = "label_network_mobile_sendSms_smtpPort";
			this.label_network_mobile_sendSms_smtpPort.Size = new System.Drawing.Size(62, 13);
			this.label_network_mobile_sendSms_smtpPort.TabIndex = 16;
			this.label_network_mobile_sendSms_smtpPort.Text = "SMTP Port:";
			// 
			// label_network_mobile_sendSms_smtpHost
			// 
			this.label_network_mobile_sendSms_smtpHost.AutoSize = true;
			this.label_network_mobile_sendSms_smtpHost.Location = new System.Drawing.Point(507, 75);
			this.label_network_mobile_sendSms_smtpHost.Name = "label_network_mobile_sendSms_smtpHost";
			this.label_network_mobile_sendSms_smtpHost.Size = new System.Drawing.Size(65, 13);
			this.label_network_mobile_sendSms_smtpHost.TabIndex = 14;
			this.label_network_mobile_sendSms_smtpHost.Text = "SMTP Host:";
			// 
			// textBox_network_mobile_sendSms_smtpHost
			// 
			this.textBox_network_mobile_sendSms_smtpHost.Location = new System.Drawing.Point(578, 72);
			this.textBox_network_mobile_sendSms_smtpHost.Name = "textBox_network_mobile_sendSms_smtpHost";
			this.textBox_network_mobile_sendSms_smtpHost.Size = new System.Drawing.Size(136, 20);
			this.textBox_network_mobile_sendSms_smtpHost.TabIndex = 13;
			this.textBox_network_mobile_sendSms_smtpHost.Text = "smtp.gmail.com";
			// 
			// label_network_mobile_sendSms_smsCarrier
			// 
			this.label_network_mobile_sendSms_smsCarrier.AutoSize = true;
			this.label_network_mobile_sendSms_smsCarrier.Location = new System.Drawing.Point(506, 38);
			this.label_network_mobile_sendSms_smsCarrier.Name = "label_network_mobile_sendSms_smsCarrier";
			this.label_network_mobile_sendSms_smsCarrier.Size = new System.Drawing.Size(66, 13);
			this.label_network_mobile_sendSms_smsCarrier.TabIndex = 12;
			this.label_network_mobile_sendSms_smsCarrier.Text = "SMS Carrier:";
			// 
			// textBox_network_mobile_sendSms_smsCarrier
			// 
			this.textBox_network_mobile_sendSms_smsCarrier.Location = new System.Drawing.Point(578, 35);
			this.textBox_network_mobile_sendSms_smsCarrier.Name = "textBox_network_mobile_sendSms_smsCarrier";
			this.textBox_network_mobile_sendSms_smsCarrier.Size = new System.Drawing.Size(136, 20);
			this.textBox_network_mobile_sendSms_smsCarrier.TabIndex = 11;
			this.textBox_network_mobile_sendSms_smsCarrier.Text = "txt.att.net";
			// 
			// button_network_mobile_sendSms_sendSms
			// 
			this.button_network_mobile_sendSms_sendSms.Location = new System.Drawing.Point(359, 200);
			this.button_network_mobile_sendSms_sendSms.Name = "button_network_mobile_sendSms_sendSms";
			this.button_network_mobile_sendSms_sendSms.Size = new System.Drawing.Size(94, 23);
			this.button_network_mobile_sendSms_sendSms.TabIndex = 10;
			this.button_network_mobile_sendSms_sendSms.Text = "Send SMS";
			this.button_network_mobile_sendSms_sendSms.UseVisualStyleBackColor = true;
			// 
			// label_network_mobile_sendSms_message
			// 
			this.label_network_mobile_sendSms_message.AutoSize = true;
			this.label_network_mobile_sendSms_message.Location = new System.Drawing.Point(184, 167);
			this.label_network_mobile_sendSms_message.Name = "label_network_mobile_sendSms_message";
			this.label_network_mobile_sendSms_message.Size = new System.Drawing.Size(53, 13);
			this.label_network_mobile_sendSms_message.TabIndex = 9;
			this.label_network_mobile_sendSms_message.Text = "Message:";
			// 
			// textBox_network_mobile_sendSms_message
			// 
			this.textBox_network_mobile_sendSms_message.Location = new System.Drawing.Point(243, 164);
			this.textBox_network_mobile_sendSms_message.Name = "textBox_network_mobile_sendSms_message";
			this.textBox_network_mobile_sendSms_message.Size = new System.Drawing.Size(210, 20);
			this.textBox_network_mobile_sendSms_message.TabIndex = 8;
			// 
			// label_network_mobile_sendSms_subject
			// 
			this.label_network_mobile_sendSms_subject.AutoSize = true;
			this.label_network_mobile_sendSms_subject.Location = new System.Drawing.Point(191, 141);
			this.label_network_mobile_sendSms_subject.Name = "label_network_mobile_sendSms_subject";
			this.label_network_mobile_sendSms_subject.Size = new System.Drawing.Size(46, 13);
			this.label_network_mobile_sendSms_subject.TabIndex = 7;
			this.label_network_mobile_sendSms_subject.Text = "Subject:";
			// 
			// textBox_network_mobile_sendSms_subject
			// 
			this.textBox_network_mobile_sendSms_subject.Location = new System.Drawing.Point(243, 138);
			this.textBox_network_mobile_sendSms_subject.Name = "textBox_network_mobile_sendSms_subject";
			this.textBox_network_mobile_sendSms_subject.Size = new System.Drawing.Size(210, 20);
			this.textBox_network_mobile_sendSms_subject.TabIndex = 6;
			// 
			// label_network_mobile_sendSms_receiverPhone
			// 
			this.label_network_mobile_sendSms_receiverPhone.AutoSize = true;
			this.label_network_mobile_sendSms_receiverPhone.Location = new System.Drawing.Point(103, 102);
			this.label_network_mobile_sendSms_receiverPhone.Name = "label_network_mobile_sendSms_receiverPhone";
			this.label_network_mobile_sendSms_receiverPhone.Size = new System.Drawing.Size(134, 13);
			this.label_network_mobile_sendSms_receiverPhone.TabIndex = 5;
			this.label_network_mobile_sendSms_receiverPhone.Text = "Receiver\'s Phone Number:";
			// 
			// textBox_network_mobile_sendSms_receiverPhone
			// 
			this.textBox_network_mobile_sendSms_receiverPhone.Location = new System.Drawing.Point(243, 99);
			this.textBox_network_mobile_sendSms_receiverPhone.Name = "textBox_network_mobile_sendSms_receiverPhone";
			this.textBox_network_mobile_sendSms_receiverPhone.Size = new System.Drawing.Size(210, 20);
			this.textBox_network_mobile_sendSms_receiverPhone.TabIndex = 4;
			// 
			// label_network_mobile_sendSms_senderEmailPassword
			// 
			this.label_network_mobile_sendSms_senderEmailPassword.AutoSize = true;
			this.label_network_mobile_sendSms_senderEmailPassword.Location = new System.Drawing.Point(109, 64);
			this.label_network_mobile_sendSms_senderEmailPassword.Name = "label_network_mobile_sendSms_senderEmailPassword";
			this.label_network_mobile_sendSms_senderEmailPassword.Size = new System.Drawing.Size(128, 13);
			this.label_network_mobile_sendSms_senderEmailPassword.TabIndex = 3;
			this.label_network_mobile_sendSms_senderEmailPassword.Text = "Sender\'s Email Password:";
			// 
			// label_network_mobile_sendSms_senderEmail
			// 
			this.label_network_mobile_sendSms_senderEmail.AutoSize = true;
			this.label_network_mobile_sendSms_senderEmail.Location = new System.Drawing.Point(158, 38);
			this.label_network_mobile_sendSms_senderEmail.Name = "label_network_mobile_sendSms_senderEmail";
			this.label_network_mobile_sendSms_senderEmail.Size = new System.Drawing.Size(79, 13);
			this.label_network_mobile_sendSms_senderEmail.TabIndex = 2;
			this.label_network_mobile_sendSms_senderEmail.Text = "Sender\'s Email:";
			// 
			// textBox_network_mobile_sendSms_senderEmailPassword
			// 
			this.textBox_network_mobile_sendSms_senderEmailPassword.Location = new System.Drawing.Point(243, 61);
			this.textBox_network_mobile_sendSms_senderEmailPassword.Name = "textBox_network_mobile_sendSms_senderEmailPassword";
			this.textBox_network_mobile_sendSms_senderEmailPassword.PasswordChar = '•';
			this.textBox_network_mobile_sendSms_senderEmailPassword.Size = new System.Drawing.Size(210, 20);
			this.textBox_network_mobile_sendSms_senderEmailPassword.TabIndex = 1;
			// 
			// textBox_network_mobile_sendSms_senderEmail
			// 
			this.textBox_network_mobile_sendSms_senderEmail.Location = new System.Drawing.Point(243, 35);
			this.textBox_network_mobile_sendSms_senderEmail.Name = "textBox_network_mobile_sendSms_senderEmail";
			this.textBox_network_mobile_sendSms_senderEmail.Size = new System.Drawing.Size(210, 20);
			this.textBox_network_mobile_sendSms_senderEmail.TabIndex = 0;
			// 
			// tab_network_security
			// 
			this.tab_network_security.Controls.Add(this.tabs_network_security);
			this.tab_network_security.Location = new System.Drawing.Point(4, 22);
			this.tab_network_security.Name = "tab_network_security";
			this.tab_network_security.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_security.Size = new System.Drawing.Size(830, 290);
			this.tab_network_security.TabIndex = 3;
			this.tab_network_security.Text = "Security";
			this.tab_network_security.UseVisualStyleBackColor = true;
			// 
			// tabs_network_security
			// 
			this.tabs_network_security.Controls.Add(this.tab_network_security_openFirewallPort);
			this.tabs_network_security.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_network_security.Location = new System.Drawing.Point(3, 3);
			this.tabs_network_security.Name = "tabs_network_security";
			this.tabs_network_security.SelectedIndex = 0;
			this.tabs_network_security.Size = new System.Drawing.Size(824, 284);
			this.tabs_network_security.TabIndex = 0;
			// 
			// tab_network_security_openFirewallPort
			// 
			this.tab_network_security_openFirewallPort.Controls.Add(this.label_network_security_openFirewallPort_warningAdmin);
			this.tab_network_security_openFirewallPort.Controls.Add(this.button_network_security_openFirewallPort_open);
			this.tab_network_security_openFirewallPort.Controls.Add(this.label_network_security_openFirewallPort_portType);
			this.tab_network_security_openFirewallPort.Controls.Add(this.comboBox_network_security_openFirewallPort_portType);
			this.tab_network_security_openFirewallPort.Controls.Add(this.label_network_security_openFirewallPort_description);
			this.tab_network_security_openFirewallPort.Controls.Add(this.label_network_security_openFirewallPort_portNumber);
			this.tab_network_security_openFirewallPort.Controls.Add(this.numeric_network_security_openFirewallPort_portNumber);
			this.tab_network_security_openFirewallPort.Controls.Add(this.textBox_network_security_openFirewallPort_description);
			this.tab_network_security_openFirewallPort.Location = new System.Drawing.Point(4, 22);
			this.tab_network_security_openFirewallPort.Name = "tab_network_security_openFirewallPort";
			this.tab_network_security_openFirewallPort.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_security_openFirewallPort.Size = new System.Drawing.Size(816, 258);
			this.tab_network_security_openFirewallPort.TabIndex = 1;
			this.tab_network_security_openFirewallPort.Text = "Open Firewall Port";
			this.tab_network_security_openFirewallPort.UseVisualStyleBackColor = true;
			// 
			// label_network_security_openFirewallPort_warningAdmin
			// 
			this.label_network_security_openFirewallPort_warningAdmin.AutoSize = true;
			this.label_network_security_openFirewallPort_warningAdmin.ForeColor = System.Drawing.Color.Red;
			this.label_network_security_openFirewallPort_warningAdmin.Location = new System.Drawing.Point(297, 170);
			this.label_network_security_openFirewallPort_warningAdmin.Name = "label_network_security_openFirewallPort_warningAdmin";
			this.label_network_security_openFirewallPort_warningAdmin.Size = new System.Drawing.Size(216, 13);
			this.label_network_security_openFirewallPort_warningAdmin.TabIndex = 9;
			this.label_network_security_openFirewallPort_warningAdmin.Text = "You need admin permissions to execute this.";
			// 
			// button_network_security_openFirewallPort_open
			// 
			this.button_network_security_openFirewallPort_open.Location = new System.Drawing.Point(490, 128);
			this.button_network_security_openFirewallPort_open.Name = "button_network_security_openFirewallPort_open";
			this.button_network_security_openFirewallPort_open.Size = new System.Drawing.Size(75, 22);
			this.button_network_security_openFirewallPort_open.TabIndex = 8;
			this.button_network_security_openFirewallPort_open.Text = "Add Port";
			this.button_network_security_openFirewallPort_open.UseVisualStyleBackColor = true;
			// 
			// label_network_security_openFirewallPort_portType
			// 
			this.label_network_security_openFirewallPort_portType.AutoSize = true;
			this.label_network_security_openFirewallPort_portType.Location = new System.Drawing.Point(265, 105);
			this.label_network_security_openFirewallPort_portType.Name = "label_network_security_openFirewallPort_portType";
			this.label_network_security_openFirewallPort_portType.Size = new System.Drawing.Size(56, 13);
			this.label_network_security_openFirewallPort_portType.TabIndex = 7;
			this.label_network_security_openFirewallPort_portType.Text = "Port Type:";
			// 
			// comboBox_network_security_openFirewallPort_portType
			// 
			this.comboBox_network_security_openFirewallPort_portType.FormattingEnabled = true;
			this.comboBox_network_security_openFirewallPort_portType.Location = new System.Drawing.Point(327, 102);
			this.comboBox_network_security_openFirewallPort_portType.Name = "comboBox_network_security_openFirewallPort_portType";
			this.comboBox_network_security_openFirewallPort_portType.Size = new System.Drawing.Size(157, 21);
			this.comboBox_network_security_openFirewallPort_portType.TabIndex = 6;
			// 
			// label_network_security_openFirewallPort_description
			// 
			this.label_network_security_openFirewallPort_description.AutoSize = true;
			this.label_network_security_openFirewallPort_description.Location = new System.Drawing.Point(258, 133);
			this.label_network_security_openFirewallPort_description.Name = "label_network_security_openFirewallPort_description";
			this.label_network_security_openFirewallPort_description.Size = new System.Drawing.Size(63, 13);
			this.label_network_security_openFirewallPort_description.TabIndex = 5;
			this.label_network_security_openFirewallPort_description.Text = "Rule Name:";
			// 
			// label_network_security_openFirewallPort_portNumber
			// 
			this.label_network_security_openFirewallPort_portNumber.AutoSize = true;
			this.label_network_security_openFirewallPort_portNumber.Location = new System.Drawing.Point(252, 78);
			this.label_network_security_openFirewallPort_portNumber.Name = "label_network_security_openFirewallPort_portNumber";
			this.label_network_security_openFirewallPort_portNumber.Size = new System.Drawing.Size(69, 13);
			this.label_network_security_openFirewallPort_portNumber.TabIndex = 4;
			this.label_network_security_openFirewallPort_portNumber.Text = "Port Number:";
			// 
			// numeric_network_security_openFirewallPort_portNumber
			// 
			this.numeric_network_security_openFirewallPort_portNumber.Location = new System.Drawing.Point(327, 76);
			this.numeric_network_security_openFirewallPort_portNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numeric_network_security_openFirewallPort_portNumber.Name = "numeric_network_security_openFirewallPort_portNumber";
			this.numeric_network_security_openFirewallPort_portNumber.Size = new System.Drawing.Size(157, 20);
			this.numeric_network_security_openFirewallPort_portNumber.TabIndex = 3;
			// 
			// textBox_network_security_openFirewallPort_description
			// 
			this.textBox_network_security_openFirewallPort_description.Location = new System.Drawing.Point(327, 129);
			this.textBox_network_security_openFirewallPort_description.Name = "textBox_network_security_openFirewallPort_description";
			this.textBox_network_security_openFirewallPort_description.Size = new System.Drawing.Size(157, 20);
			this.textBox_network_security_openFirewallPort_description.TabIndex = 2;
			// 
			// tab_network_requests
			// 
			this.tab_network_requests.Controls.Add(this.tabs_network_requests);
			this.tab_network_requests.Location = new System.Drawing.Point(4, 22);
			this.tab_network_requests.Name = "tab_network_requests";
			this.tab_network_requests.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_requests.Size = new System.Drawing.Size(830, 290);
			this.tab_network_requests.TabIndex = 4;
			this.tab_network_requests.Text = "Requests";
			this.tab_network_requests.UseVisualStyleBackColor = true;
			// 
			// tabs_network_requests
			// 
			this.tabs_network_requests.Controls.Add(this.tab_network_requests_get);
			this.tabs_network_requests.Controls.Add(this.tab_network_requests_post);
			this.tabs_network_requests.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_network_requests.Location = new System.Drawing.Point(3, 3);
			this.tabs_network_requests.Name = "tabs_network_requests";
			this.tabs_network_requests.SelectedIndex = 0;
			this.tabs_network_requests.Size = new System.Drawing.Size(824, 284);
			this.tabs_network_requests.TabIndex = 0;
			// 
			// tab_network_requests_get
			// 
			this.tab_network_requests_get.Controls.Add(this.label_network_requests_get_endpoint);
			this.tab_network_requests_get.Controls.Add(this.textBox_network_requests_get_endpoint);
			this.tab_network_requests_get.Controls.Add(this.button_network_requests_get_execute);
			this.tab_network_requests_get.Location = new System.Drawing.Point(4, 22);
			this.tab_network_requests_get.Name = "tab_network_requests_get";
			this.tab_network_requests_get.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_requests_get.Size = new System.Drawing.Size(816, 258);
			this.tab_network_requests_get.TabIndex = 0;
			this.tab_network_requests_get.Text = "GET";
			this.tab_network_requests_get.UseVisualStyleBackColor = true;
			// 
			// label_network_requests_get_endpoint
			// 
			this.label_network_requests_get_endpoint.AutoSize = true;
			this.label_network_requests_get_endpoint.Location = new System.Drawing.Point(172, 108);
			this.label_network_requests_get_endpoint.Name = "label_network_requests_get_endpoint";
			this.label_network_requests_get_endpoint.Size = new System.Drawing.Size(52, 13);
			this.label_network_requests_get_endpoint.TabIndex = 2;
			this.label_network_requests_get_endpoint.Text = "Endpoint:";
			// 
			// textBox_network_requests_get_endpoint
			// 
			this.textBox_network_requests_get_endpoint.Location = new System.Drawing.Point(230, 105);
			this.textBox_network_requests_get_endpoint.Name = "textBox_network_requests_get_endpoint";
			this.textBox_network_requests_get_endpoint.Size = new System.Drawing.Size(415, 20);
			this.textBox_network_requests_get_endpoint.TabIndex = 1;
			// 
			// button_network_requests_get_execute
			// 
			this.button_network_requests_get_execute.Location = new System.Drawing.Point(545, 131);
			this.button_network_requests_get_execute.Name = "button_network_requests_get_execute";
			this.button_network_requests_get_execute.Size = new System.Drawing.Size(100, 23);
			this.button_network_requests_get_execute.TabIndex = 0;
			this.button_network_requests_get_execute.Text = "Execute Request";
			this.button_network_requests_get_execute.UseVisualStyleBackColor = true;
			this.button_network_requests_get_execute.Click += new System.EventHandler(this.button_network_requests_get_execute_Click);
			// 
			// tab_network_requests_post
			// 
			this.tab_network_requests_post.Controls.Add(this.label_network_requests_post_data);
			this.tab_network_requests_post.Controls.Add(this.label_network_requests_post_endpoint);
			this.tab_network_requests_post.Controls.Add(this.textBox_network_requests_post_endpoint);
			this.tab_network_requests_post.Controls.Add(this.textBox_network_requests_post_data);
			this.tab_network_requests_post.Controls.Add(this.button_network_requests_post_execute);
			this.tab_network_requests_post.Location = new System.Drawing.Point(4, 22);
			this.tab_network_requests_post.Name = "tab_network_requests_post";
			this.tab_network_requests_post.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_requests_post.Size = new System.Drawing.Size(816, 258);
			this.tab_network_requests_post.TabIndex = 1;
			this.tab_network_requests_post.Text = "POST";
			this.tab_network_requests_post.UseVisualStyleBackColor = true;
			// 
			// label_network_requests_post_data
			// 
			this.label_network_requests_post_data.AutoSize = true;
			this.label_network_requests_post_data.Location = new System.Drawing.Point(191, 57);
			this.label_network_requests_post_data.Name = "label_network_requests_post_data";
			this.label_network_requests_post_data.Size = new System.Drawing.Size(33, 13);
			this.label_network_requests_post_data.TabIndex = 6;
			this.label_network_requests_post_data.Text = "Data:";
			// 
			// label_network_requests_post_endpoint
			// 
			this.label_network_requests_post_endpoint.AutoSize = true;
			this.label_network_requests_post_endpoint.Location = new System.Drawing.Point(172, 31);
			this.label_network_requests_post_endpoint.Name = "label_network_requests_post_endpoint";
			this.label_network_requests_post_endpoint.Size = new System.Drawing.Size(52, 13);
			this.label_network_requests_post_endpoint.TabIndex = 5;
			this.label_network_requests_post_endpoint.Text = "Endpoint:";
			// 
			// textBox_network_requests_post_endpoint
			// 
			this.textBox_network_requests_post_endpoint.Location = new System.Drawing.Point(230, 28);
			this.textBox_network_requests_post_endpoint.Name = "textBox_network_requests_post_endpoint";
			this.textBox_network_requests_post_endpoint.Size = new System.Drawing.Size(415, 20);
			this.textBox_network_requests_post_endpoint.TabIndex = 4;
			// 
			// textBox_network_requests_post_data
			// 
			this.textBox_network_requests_post_data.Location = new System.Drawing.Point(230, 54);
			this.textBox_network_requests_post_data.Multiline = true;
			this.textBox_network_requests_post_data.Name = "textBox_network_requests_post_data";
			this.textBox_network_requests_post_data.Size = new System.Drawing.Size(415, 147);
			this.textBox_network_requests_post_data.TabIndex = 3;
			// 
			// button_network_requests_post_execute
			// 
			this.button_network_requests_post_execute.Location = new System.Drawing.Point(545, 207);
			this.button_network_requests_post_execute.Name = "button_network_requests_post_execute";
			this.button_network_requests_post_execute.Size = new System.Drawing.Size(100, 23);
			this.button_network_requests_post_execute.TabIndex = 2;
			this.button_network_requests_post_execute.Text = "Execute Request";
			this.button_network_requests_post_execute.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis
			// 
			this.tab_network_apis.Controls.Add(this.tabs_network_apis);
			this.tab_network_apis.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis.Name = "tab_network_apis";
			this.tab_network_apis.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis.Size = new System.Drawing.Size(830, 290);
			this.tab_network_apis.TabIndex = 5;
			this.tab_network_apis.Text = "APIs";
			this.tab_network_apis.UseVisualStyleBackColor = true;
			// 
			// tabs_network_apis
			// 
			this.tabs_network_apis.Controls.Add(this.tab_network_apis_riotapi);
			this.tabs_network_apis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_network_apis.Location = new System.Drawing.Point(3, 3);
			this.tabs_network_apis.Name = "tabs_network_apis";
			this.tabs_network_apis.SelectedIndex = 0;
			this.tabs_network_apis.Size = new System.Drawing.Size(824, 284);
			this.tabs_network_apis.TabIndex = 0;
			// 
			// tab_network_apis_riotapi
			// 
			this.tab_network_apis_riotapi.Controls.Add(this.tabs_network_apis_riotapi);
			this.tab_network_apis_riotapi.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi.Name = "tab_network_apis_riotapi";
			this.tab_network_apis_riotapi.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi.Size = new System.Drawing.Size(816, 258);
			this.tab_network_apis_riotapi.TabIndex = 0;
			this.tab_network_apis_riotapi.Text = "RiotAPI";
			this.tab_network_apis_riotapi.UseVisualStyleBackColor = true;
			// 
			// tabs_network_apis_riotapi
			// 
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_championMastery);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_champion);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_leagueExp);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_league);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_lolStatus);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_match);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_spectator);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_summoner);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_tftLeague);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_tftMatch);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_tftSummoner);
			this.tabs_network_apis_riotapi.Controls.Add(this.tab_network_apis_riotapi_thirdPartyCode);
			this.tabs_network_apis_riotapi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_network_apis_riotapi.Location = new System.Drawing.Point(3, 3);
			this.tabs_network_apis_riotapi.Name = "tabs_network_apis_riotapi";
			this.tabs_network_apis_riotapi.SelectedIndex = 0;
			this.tabs_network_apis_riotapi.Size = new System.Drawing.Size(810, 252);
			this.tabs_network_apis_riotapi.TabIndex = 0;
			// 
			// tab_network_apis_riotapi_championMastery
			// 
			this.tab_network_apis_riotapi_championMastery.Controls.Add(this.tabs_network_apis_riotapi_championMastery);
			this.tab_network_apis_riotapi_championMastery.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_championMastery.Name = "tab_network_apis_riotapi_championMastery";
			this.tab_network_apis_riotapi_championMastery.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_championMastery.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_championMastery.TabIndex = 0;
			this.tab_network_apis_riotapi_championMastery.Text = "Champion Mastery";
			this.tab_network_apis_riotapi_championMastery.UseVisualStyleBackColor = true;
			// 
			// tabs_network_apis_riotapi_championMastery
			// 
			this.tabs_network_apis_riotapi_championMastery.Controls.Add(this.tab_network_apis_riotapi_championMastery_getChampionMasteryList);
			this.tabs_network_apis_riotapi_championMastery.Controls.Add(this.tab_network_apis_riotapi_championMastery_getMasteryByChampion);
			this.tabs_network_apis_riotapi_championMastery.Controls.Add(this.tab_network_apis_riotapi_championMastery_getTotalMasteryScore);
			this.tabs_network_apis_riotapi_championMastery.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_network_apis_riotapi_championMastery.Location = new System.Drawing.Point(3, 3);
			this.tabs_network_apis_riotapi_championMastery.Name = "tabs_network_apis_riotapi_championMastery";
			this.tabs_network_apis_riotapi_championMastery.SelectedIndex = 0;
			this.tabs_network_apis_riotapi_championMastery.Size = new System.Drawing.Size(796, 220);
			this.tabs_network_apis_riotapi_championMastery.TabIndex = 0;
			// 
			// tab_network_apis_riotapi_championMastery_getChampionMasteryList
			// 
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.Controls.Add(this.label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId);
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.Controls.Add(this.textBox_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId);
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.Controls.Add(this.button_network_apis_riotapi_championMastery_getChampionMasteryList_get);
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.Name = "tab_network_apis_riotapi_championMastery_getChampionMasteryList";
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.Size = new System.Drawing.Size(788, 194);
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.TabIndex = 0;
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.Text = "Get Champion Mastery List";
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.UseVisualStyleBackColor = true;
			// 
			// label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId
			// 
			this.label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.AutoSize = true;
			this.label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.Location = new System.Drawing.Point(93, 76);
			this.label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.Name = "label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummo" +
    "nerId";
			this.label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.Size = new System.Drawing.Size(125, 13);
			this.label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.TabIndex = 2;
			this.label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.Text = "Encrypted Summoner ID:";
			// 
			// textBox_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId
			// 
			this.textBox_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.Location = new System.Drawing.Point(224, 73);
			this.textBox_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.Name = "textBox_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSumm" +
    "onerId";
			this.textBox_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.Size = new System.Drawing.Size(472, 20);
			this.textBox_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.TabIndex = 1;
			// 
			// button_network_apis_riotapi_championMastery_getChampionMasteryList_get
			// 
			this.button_network_apis_riotapi_championMastery_getChampionMasteryList_get.Location = new System.Drawing.Point(621, 99);
			this.button_network_apis_riotapi_championMastery_getChampionMasteryList_get.Name = "button_network_apis_riotapi_championMastery_getChampionMasteryList_get";
			this.button_network_apis_riotapi_championMastery_getChampionMasteryList_get.Size = new System.Drawing.Size(75, 23);
			this.button_network_apis_riotapi_championMastery_getChampionMasteryList_get.TabIndex = 0;
			this.button_network_apis_riotapi_championMastery_getChampionMasteryList_get.Text = "GET";
			this.button_network_apis_riotapi_championMastery_getChampionMasteryList_get.UseVisualStyleBackColor = true;
			this.button_network_apis_riotapi_championMastery_getChampionMasteryList_get.Click += new System.EventHandler(this.button_network_apis_riotapi_championMastery_getChampionMasteryList_get_Click);
			// 
			// tab_network_apis_riotapi_championMastery_getMasteryByChampion
			// 
			this.tab_network_apis_riotapi_championMastery_getMasteryByChampion.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_championMastery_getMasteryByChampion.Name = "tab_network_apis_riotapi_championMastery_getMasteryByChampion";
			this.tab_network_apis_riotapi_championMastery_getMasteryByChampion.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_championMastery_getMasteryByChampion.Size = new System.Drawing.Size(788, 194);
			this.tab_network_apis_riotapi_championMastery_getMasteryByChampion.TabIndex = 1;
			this.tab_network_apis_riotapi_championMastery_getMasteryByChampion.Text = "Get Mastery By Champion";
			this.tab_network_apis_riotapi_championMastery_getMasteryByChampion.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_championMastery_getTotalMasteryScore
			// 
			this.tab_network_apis_riotapi_championMastery_getTotalMasteryScore.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_championMastery_getTotalMasteryScore.Name = "tab_network_apis_riotapi_championMastery_getTotalMasteryScore";
			this.tab_network_apis_riotapi_championMastery_getTotalMasteryScore.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_championMastery_getTotalMasteryScore.Size = new System.Drawing.Size(788, 194);
			this.tab_network_apis_riotapi_championMastery_getTotalMasteryScore.TabIndex = 2;
			this.tab_network_apis_riotapi_championMastery_getTotalMasteryScore.Text = "Get Total Mastery Score";
			this.tab_network_apis_riotapi_championMastery_getTotalMasteryScore.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_champion
			// 
			this.tab_network_apis_riotapi_champion.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_champion.Name = "tab_network_apis_riotapi_champion";
			this.tab_network_apis_riotapi_champion.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_champion.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_champion.TabIndex = 1;
			this.tab_network_apis_riotapi_champion.Text = "Champion";
			this.tab_network_apis_riotapi_champion.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_leagueExp
			// 
			this.tab_network_apis_riotapi_leagueExp.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_leagueExp.Name = "tab_network_apis_riotapi_leagueExp";
			this.tab_network_apis_riotapi_leagueExp.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_leagueExp.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_leagueExp.TabIndex = 2;
			this.tab_network_apis_riotapi_leagueExp.Text = "League Exp";
			this.tab_network_apis_riotapi_leagueExp.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_league
			// 
			this.tab_network_apis_riotapi_league.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_league.Name = "tab_network_apis_riotapi_league";
			this.tab_network_apis_riotapi_league.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_league.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_league.TabIndex = 3;
			this.tab_network_apis_riotapi_league.Text = "League";
			this.tab_network_apis_riotapi_league.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_lolStatus
			// 
			this.tab_network_apis_riotapi_lolStatus.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_lolStatus.Name = "tab_network_apis_riotapi_lolStatus";
			this.tab_network_apis_riotapi_lolStatus.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_lolStatus.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_lolStatus.TabIndex = 4;
			this.tab_network_apis_riotapi_lolStatus.Text = "LoL Status";
			this.tab_network_apis_riotapi_lolStatus.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_match
			// 
			this.tab_network_apis_riotapi_match.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_match.Name = "tab_network_apis_riotapi_match";
			this.tab_network_apis_riotapi_match.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_match.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_match.TabIndex = 5;
			this.tab_network_apis_riotapi_match.Text = "Match";
			this.tab_network_apis_riotapi_match.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_spectator
			// 
			this.tab_network_apis_riotapi_spectator.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_spectator.Name = "tab_network_apis_riotapi_spectator";
			this.tab_network_apis_riotapi_spectator.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_spectator.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_spectator.TabIndex = 6;
			this.tab_network_apis_riotapi_spectator.Text = "Spectator";
			this.tab_network_apis_riotapi_spectator.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_summoner
			// 
			this.tab_network_apis_riotapi_summoner.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_summoner.Name = "tab_network_apis_riotapi_summoner";
			this.tab_network_apis_riotapi_summoner.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_summoner.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_summoner.TabIndex = 7;
			this.tab_network_apis_riotapi_summoner.Text = "Summoner";
			this.tab_network_apis_riotapi_summoner.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_tftLeague
			// 
			this.tab_network_apis_riotapi_tftLeague.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_tftLeague.Name = "tab_network_apis_riotapi_tftLeague";
			this.tab_network_apis_riotapi_tftLeague.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_tftLeague.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_tftLeague.TabIndex = 8;
			this.tab_network_apis_riotapi_tftLeague.Text = "TFT League";
			this.tab_network_apis_riotapi_tftLeague.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_tftMatch
			// 
			this.tab_network_apis_riotapi_tftMatch.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_tftMatch.Name = "tab_network_apis_riotapi_tftMatch";
			this.tab_network_apis_riotapi_tftMatch.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_tftMatch.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_tftMatch.TabIndex = 9;
			this.tab_network_apis_riotapi_tftMatch.Text = "TFT Match";
			this.tab_network_apis_riotapi_tftMatch.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_tftSummoner
			// 
			this.tab_network_apis_riotapi_tftSummoner.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_tftSummoner.Name = "tab_network_apis_riotapi_tftSummoner";
			this.tab_network_apis_riotapi_tftSummoner.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_tftSummoner.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_tftSummoner.TabIndex = 10;
			this.tab_network_apis_riotapi_tftSummoner.Text = "TFT Summoner";
			this.tab_network_apis_riotapi_tftSummoner.UseVisualStyleBackColor = true;
			// 
			// tab_network_apis_riotapi_thirdPartyCode
			// 
			this.tab_network_apis_riotapi_thirdPartyCode.Location = new System.Drawing.Point(4, 22);
			this.tab_network_apis_riotapi_thirdPartyCode.Name = "tab_network_apis_riotapi_thirdPartyCode";
			this.tab_network_apis_riotapi_thirdPartyCode.Padding = new System.Windows.Forms.Padding(3);
			this.tab_network_apis_riotapi_thirdPartyCode.Size = new System.Drawing.Size(802, 226);
			this.tab_network_apis_riotapi_thirdPartyCode.TabIndex = 11;
			this.tab_network_apis_riotapi_thirdPartyCode.Text = "Third Party Code";
			this.tab_network_apis_riotapi_thirdPartyCode.UseVisualStyleBackColor = true;
			// 
			// tab_math
			// 
			this.tab_math.Controls.Add(this.tabs_math);
			this.tab_math.Location = new System.Drawing.Point(4, 22);
			this.tab_math.Name = "tab_math";
			this.tab_math.Padding = new System.Windows.Forms.Padding(3);
			this.tab_math.Size = new System.Drawing.Size(844, 322);
			this.tab_math.TabIndex = 6;
			this.tab_math.Text = "Math";
			this.tab_math.UseVisualStyleBackColor = true;
			// 
			// tabs_math
			// 
			this.tabs_math.Controls.Add(this.tab_math_calculateCombinations);
			this.tabs_math.Controls.Add(this.tab_math_calculateFactorial);
			this.tabs_math.Controls.Add(this.tab_math_isPrimeNumber);
			this.tabs_math.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_math.Location = new System.Drawing.Point(3, 3);
			this.tabs_math.Name = "tabs_math";
			this.tabs_math.SelectedIndex = 0;
			this.tabs_math.Size = new System.Drawing.Size(838, 316);
			this.tabs_math.TabIndex = 0;
			// 
			// tab_math_calculateCombinations
			// 
			this.tab_math_calculateCombinations.Controls.Add(this.numeric_math_calculateCombinations_group);
			this.tab_math_calculateCombinations.Controls.Add(this.label_math_calculateCombinations_elements);
			this.tab_math_calculateCombinations.Controls.Add(this.button_math_calculateCombinations_calculate);
			this.tab_math_calculateCombinations.Controls.Add(this.numeric_math_calculateCombinations_elements);
			this.tab_math_calculateCombinations.Controls.Add(this.label_math_calculateCombinations_group);
			this.tab_math_calculateCombinations.Location = new System.Drawing.Point(4, 22);
			this.tab_math_calculateCombinations.Name = "tab_math_calculateCombinations";
			this.tab_math_calculateCombinations.Padding = new System.Windows.Forms.Padding(3);
			this.tab_math_calculateCombinations.Size = new System.Drawing.Size(830, 290);
			this.tab_math_calculateCombinations.TabIndex = 0;
			this.tab_math_calculateCombinations.Text = "Calculate Combinations";
			this.tab_math_calculateCombinations.UseVisualStyleBackColor = true;
			// 
			// tab_math_calculateFactorial
			// 
			this.tab_math_calculateFactorial.Controls.Add(this.button_math_calculateFactorial_calculate);
			this.tab_math_calculateFactorial.Controls.Add(this.label_math_calculateFactorial_factorial);
			this.tab_math_calculateFactorial.Controls.Add(this.numeric_math_calculateFactorial_factorial);
			this.tab_math_calculateFactorial.Location = new System.Drawing.Point(4, 22);
			this.tab_math_calculateFactorial.Name = "tab_math_calculateFactorial";
			this.tab_math_calculateFactorial.Padding = new System.Windows.Forms.Padding(3);
			this.tab_math_calculateFactorial.Size = new System.Drawing.Size(830, 290);
			this.tab_math_calculateFactorial.TabIndex = 1;
			this.tab_math_calculateFactorial.Text = "Calculate Factorial";
			this.tab_math_calculateFactorial.UseVisualStyleBackColor = true;
			// 
			// tab_math_isPrimeNumber
			// 
			this.tab_math_isPrimeNumber.Controls.Add(this.label_math_isPrimeNumber_number);
			this.tab_math_isPrimeNumber.Controls.Add(this.textBox_math_isPrimeNumber_number);
			this.tab_math_isPrimeNumber.Controls.Add(this.button_math_isPrimeNumber_check);
			this.tab_math_isPrimeNumber.Location = new System.Drawing.Point(4, 22);
			this.tab_math_isPrimeNumber.Name = "tab_math_isPrimeNumber";
			this.tab_math_isPrimeNumber.Padding = new System.Windows.Forms.Padding(3);
			this.tab_math_isPrimeNumber.Size = new System.Drawing.Size(830, 290);
			this.tab_math_isPrimeNumber.TabIndex = 2;
			this.tab_math_isPrimeNumber.Text = "Is Prime Number";
			this.tab_math_isPrimeNumber.UseVisualStyleBackColor = true;
			// 
			// label_math_isPrimeNumber_number
			// 
			this.label_math_isPrimeNumber_number.AutoSize = true;
			this.label_math_isPrimeNumber_number.Location = new System.Drawing.Point(320, 124);
			this.label_math_isPrimeNumber_number.Name = "label_math_isPrimeNumber_number";
			this.label_math_isPrimeNumber_number.Size = new System.Drawing.Size(47, 13);
			this.label_math_isPrimeNumber_number.TabIndex = 2;
			this.label_math_isPrimeNumber_number.Text = "Number:";
			// 
			// textBox_math_isPrimeNumber_number
			// 
			this.textBox_math_isPrimeNumber_number.Location = new System.Drawing.Point(373, 121);
			this.textBox_math_isPrimeNumber_number.Name = "textBox_math_isPrimeNumber_number";
			this.textBox_math_isPrimeNumber_number.Size = new System.Drawing.Size(137, 20);
			this.textBox_math_isPrimeNumber_number.TabIndex = 1;
			// 
			// button_math_isPrimeNumber_check
			// 
			this.button_math_isPrimeNumber_check.Location = new System.Drawing.Point(435, 147);
			this.button_math_isPrimeNumber_check.Name = "button_math_isPrimeNumber_check";
			this.button_math_isPrimeNumber_check.Size = new System.Drawing.Size(75, 23);
			this.button_math_isPrimeNumber_check.TabIndex = 0;
			this.button_math_isPrimeNumber_check.Text = "Check";
			this.button_math_isPrimeNumber_check.UseVisualStyleBackColor = true;
			// 
			// tab_dynvars
			// 
			this.tab_dynvars.Controls.Add(this.label_dynvars_value);
			this.tab_dynvars.Controls.Add(this.label_dynvars_variable);
			this.tab_dynvars.Controls.Add(this.button_dynvars_run);
			this.tab_dynvars.Controls.Add(this.textBox_dynvars_value);
			this.tab_dynvars.Controls.Add(this.textBox_dynvars_variable);
			this.tab_dynvars.Location = new System.Drawing.Point(4, 22);
			this.tab_dynvars.Name = "tab_dynvars";
			this.tab_dynvars.Padding = new System.Windows.Forms.Padding(3);
			this.tab_dynvars.Size = new System.Drawing.Size(844, 322);
			this.tab_dynvars.TabIndex = 7;
			this.tab_dynvars.Text = "DynVars";
			this.tab_dynvars.UseVisualStyleBackColor = true;
			// 
			// label_dynvars_value
			// 
			this.label_dynvars_value.AutoSize = true;
			this.label_dynvars_value.Location = new System.Drawing.Point(263, 153);
			this.label_dynvars_value.Name = "label_dynvars_value";
			this.label_dynvars_value.Size = new System.Drawing.Size(37, 13);
			this.label_dynvars_value.TabIndex = 4;
			this.label_dynvars_value.Text = "Value:";
			// 
			// label_dynvars_variable
			// 
			this.label_dynvars_variable.AutoSize = true;
			this.label_dynvars_variable.Location = new System.Drawing.Point(252, 127);
			this.label_dynvars_variable.Name = "label_dynvars_variable";
			this.label_dynvars_variable.Size = new System.Drawing.Size(48, 13);
			this.label_dynvars_variable.TabIndex = 3;
			this.label_dynvars_variable.Text = "Variable:";
			// 
			// button_dynvars_run
			// 
			this.button_dynvars_run.Location = new System.Drawing.Point(517, 176);
			this.button_dynvars_run.Name = "button_dynvars_run";
			this.button_dynvars_run.Size = new System.Drawing.Size(75, 23);
			this.button_dynvars_run.TabIndex = 2;
			this.button_dynvars_run.Text = "Run";
			this.button_dynvars_run.UseVisualStyleBackColor = true;
			// 
			// textBox_dynvars_value
			// 
			this.textBox_dynvars_value.Location = new System.Drawing.Point(306, 150);
			this.textBox_dynvars_value.Name = "textBox_dynvars_value";
			this.textBox_dynvars_value.Size = new System.Drawing.Size(286, 20);
			this.textBox_dynvars_value.TabIndex = 1;
			// 
			// textBox_dynvars_variable
			// 
			this.textBox_dynvars_variable.Location = new System.Drawing.Point(306, 124);
			this.textBox_dynvars_variable.Name = "textBox_dynvars_variable";
			this.textBox_dynvars_variable.Size = new System.Drawing.Size(286, 20);
			this.textBox_dynvars_variable.TabIndex = 0;
			// 
			// tab_device
			// 
			this.tab_device.Controls.Add(this.tabs_device);
			this.tab_device.Location = new System.Drawing.Point(4, 22);
			this.tab_device.Name = "tab_device";
			this.tab_device.Padding = new System.Windows.Forms.Padding(3);
			this.tab_device.Size = new System.Drawing.Size(844, 322);
			this.tab_device.TabIndex = 8;
			this.tab_device.Text = "Device";
			this.tab_device.UseVisualStyleBackColor = true;
			// 
			// tabs_device
			// 
			this.tabs_device.Controls.Add(this.tab_device_getRam);
			this.tabs_device.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs_device.Location = new System.Drawing.Point(3, 3);
			this.tabs_device.Name = "tabs_device";
			this.tabs_device.SelectedIndex = 0;
			this.tabs_device.Size = new System.Drawing.Size(838, 316);
			this.tabs_device.TabIndex = 0;
			// 
			// tab_device_getRam
			// 
			this.tab_device_getRam.Controls.Add(this.label_device_getRam_gb);
			this.tab_device_getRam.Controls.Add(this.button_device_getRam_update);
			this.tab_device_getRam.Controls.Add(this.comboBox_device_getRam_ramType);
			this.tab_device_getRam.Controls.Add(this.textBox_device_getRam_value);
			this.tab_device_getRam.Location = new System.Drawing.Point(4, 22);
			this.tab_device_getRam.Name = "tab_device_getRam";
			this.tab_device_getRam.Padding = new System.Windows.Forms.Padding(3);
			this.tab_device_getRam.Size = new System.Drawing.Size(830, 290);
			this.tab_device_getRam.TabIndex = 1;
			this.tab_device_getRam.Text = "Get RAM";
			this.tab_device_getRam.UseVisualStyleBackColor = true;
			// 
			// label_device_getRam_gb
			// 
			this.label_device_getRam_gb.AutoSize = true;
			this.label_device_getRam_gb.Location = new System.Drawing.Point(524, 137);
			this.label_device_getRam_gb.Name = "label_device_getRam_gb";
			this.label_device_getRam_gb.Size = new System.Drawing.Size(22, 13);
			this.label_device_getRam_gb.TabIndex = 3;
			this.label_device_getRam_gb.Text = "GB";
			// 
			// button_device_getRam_update
			// 
			this.button_device_getRam_update.Location = new System.Drawing.Point(443, 160);
			this.button_device_getRam_update.Name = "button_device_getRam_update";
			this.button_device_getRam_update.Size = new System.Drawing.Size(75, 23);
			this.button_device_getRam_update.TabIndex = 2;
			this.button_device_getRam_update.Text = "Update";
			this.button_device_getRam_update.UseVisualStyleBackColor = true;
			this.button_device_getRam_update.Click += new System.EventHandler(this.button_device_getRam_update_Click);
			// 
			// comboBox_device_getRam_ramType
			// 
			this.comboBox_device_getRam_ramType.FormattingEnabled = true;
			this.comboBox_device_getRam_ramType.Location = new System.Drawing.Point(285, 107);
			this.comboBox_device_getRam_ramType.Name = "comboBox_device_getRam_ramType";
			this.comboBox_device_getRam_ramType.Size = new System.Drawing.Size(233, 21);
			this.comboBox_device_getRam_ramType.TabIndex = 1;
			this.comboBox_device_getRam_ramType.SelectedIndexChanged += new System.EventHandler(this.comboBox_device_getRam_ramType_SelectedIndexChanged);
			// 
			// textBox_device_getRam_value
			// 
			this.textBox_device_getRam_value.Location = new System.Drawing.Point(285, 134);
			this.textBox_device_getRam_value.Name = "textBox_device_getRam_value";
			this.textBox_device_getRam_value.Size = new System.Drawing.Size(233, 20);
			this.textBox_device_getRam_value.TabIndex = 0;
			// 
			// label_tg_databaseType
			// 
			this.label_tg_databaseType.AutoSize = true;
			this.label_tg_databaseType.Location = new System.Drawing.Point(8, 353);
			this.label_tg_databaseType.Name = "label_tg_databaseType";
			this.label_tg_databaseType.Size = new System.Drawing.Size(83, 13);
			this.label_tg_databaseType.TabIndex = 29;
			this.label_tg_databaseType.Text = "Database Type:";
			// 
			// label_tg_version
			// 
			this.label_tg_version.AutoSize = true;
			this.label_tg_version.Location = new System.Drawing.Point(603, 353);
			this.label_tg_version.Name = "label_tg_version";
			this.label_tg_version.Size = new System.Drawing.Size(94, 13);
			this.label_tg_version.TabIndex = 30;
			this.label_tg_version.Text = "ScriptsLib Version:";
			// 
			// textBox_tg_version
			// 
			this.textBox_tg_version.Location = new System.Drawing.Point(698, 350);
			this.textBox_tg_version.Name = "textBox_tg_version";
			this.textBox_tg_version.ReadOnly = true;
			this.textBox_tg_version.Size = new System.Drawing.Size(63, 20);
			this.textBox_tg_version.TabIndex = 31;
			// 
			// button_tg_test
			// 
			this.button_tg_test.Location = new System.Drawing.Point(763, 349);
			this.button_tg_test.Name = "button_tg_test";
			this.button_tg_test.Size = new System.Drawing.Size(40, 22);
			this.button_tg_test.TabIndex = 32;
			this.button_tg_test.Text = "Test";
			this.button_tg_test.UseVisualStyleBackColor = true;
			this.button_tg_test.Click += new System.EventHandler(this.button_tg_test_Click);
			// 
			// checkBox_tg_debug
			// 
			this.checkBox_tg_debug.AutoSize = true;
			this.checkBox_tg_debug.Location = new System.Drawing.Point(406, 353);
			this.checkBox_tg_debug.Name = "checkBox_tg_debug";
			this.checkBox_tg_debug.Size = new System.Drawing.Size(74, 17);
			this.checkBox_tg_debug.TabIndex = 33;
			this.checkBox_tg_debug.Text = "SL Debug";
			this.checkBox_tg_debug.UseVisualStyleBackColor = true;
			// 
			// checkBox_tg_debugErrors
			// 
			this.checkBox_tg_debugErrors.AutoSize = true;
			this.checkBox_tg_debugErrors.Location = new System.Drawing.Point(482, 353);
			this.checkBox_tg_debugErrors.Name = "checkBox_tg_debugErrors";
			this.checkBox_tg_debugErrors.Size = new System.Drawing.Size(77, 17);
			this.checkBox_tg_debugErrors.TabIndex = 34;
			this.checkBox_tg_debugErrors.Text = "Only Errors";
			this.checkBox_tg_debugErrors.UseVisualStyleBackColor = true;
			// 
			// numeric_tg_testingIndex
			// 
			this.numeric_tg_testingIndex.Location = new System.Drawing.Point(805, 350);
			this.numeric_tg_testingIndex.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.numeric_tg_testingIndex.Name = "numeric_tg_testingIndex";
			this.numeric_tg_testingIndex.Size = new System.Drawing.Size(43, 20);
			this.numeric_tg_testingIndex.TabIndex = 35;
			this.numeric_tg_testingIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// button_tg_keys
			// 
			this.button_tg_keys.Location = new System.Drawing.Point(285, 349);
			this.button_tg_keys.Name = "button_tg_keys";
			this.button_tg_keys.Size = new System.Drawing.Size(46, 22);
			this.button_tg_keys.TabIndex = 36;
			this.button_tg_keys.Text = "Keys";
			this.button_tg_keys.UseVisualStyleBackColor = true;
			this.button_tg_keys.Click += new System.EventHandler(this.button_tg_keys_Click);
			// 
			// button_tg_refresh
			// 
			this.button_tg_refresh.Location = new System.Drawing.Point(332, 349);
			this.button_tg_refresh.Name = "button_tg_refresh";
			this.button_tg_refresh.Size = new System.Drawing.Size(68, 22);
			this.button_tg_refresh.TabIndex = 37;
			this.button_tg_refresh.Text = "Refresh";
			this.button_tg_refresh.UseVisualStyleBackColor = true;
			this.button_tg_refresh.Click += new System.EventHandler(this.button_tg_refresh_Click);
			// 
			// tab_controls_form_allowDrag
			// 
			this.tab_controls_form_allowDrag.Controls.Add(this.checkBox_controls_form_allowDrag);
			this.tab_controls_form_allowDrag.Location = new System.Drawing.Point(4, 22);
			this.tab_controls_form_allowDrag.Name = "tab_controls_form_allowDrag";
			this.tab_controls_form_allowDrag.Padding = new System.Windows.Forms.Padding(3);
			this.tab_controls_form_allowDrag.Size = new System.Drawing.Size(802, 226);
			this.tab_controls_form_allowDrag.TabIndex = 1;
			this.tab_controls_form_allowDrag.Text = "Allow Drag";
			this.tab_controls_form_allowDrag.UseVisualStyleBackColor = true;
			// 
			// checkBox_controls_form_allowDrag
			// 
			this.checkBox_controls_form_allowDrag.AutoSize = true;
			this.checkBox_controls_form_allowDrag.Location = new System.Drawing.Point(363, 105);
			this.checkBox_controls_form_allowDrag.Name = "checkBox_controls_form_allowDrag";
			this.checkBox_controls_form_allowDrag.Size = new System.Drawing.Size(77, 17);
			this.checkBox_controls_form_allowDrag.TabIndex = 0;
			this.checkBox_controls_form_allowDrag.Text = "Allow Drag";
			this.checkBox_controls_form_allowDrag.UseVisualStyleBackColor = true;
			this.checkBox_controls_form_allowDrag.CheckedChanged += new System.EventHandler(this.checkBox_controls_form_allowDrag_CheckedChanged);
			// 
			// lineGraph
			// 
			this.lineGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lineGraph.Location = new System.Drawing.Point(308, 16);
			this.lineGraph.Name = "lineGraph";
			this.lineGraph.Size = new System.Drawing.Size(200, 200);
			this.lineGraph.TabIndex = 0;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 374);
			this.Controls.Add(this.button_tg_refresh);
			this.Controls.Add(this.button_tg_keys);
			this.Controls.Add(this.numeric_tg_testingIndex);
			this.Controls.Add(this.checkBox_tg_debugErrors);
			this.Controls.Add(this.checkBox_tg_debug);
			this.Controls.Add(this.button_tg_test);
			this.Controls.Add(this.label_tg_databaseType);
			this.Controls.Add(this.comboBox_tg_databaseType);
			this.Controls.Add(this.tabs_tg);
			this.Controls.Add(this.textBox_tg_version);
			this.Controls.Add(this.label_tg_version);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Testing Grounds";
			((System.ComponentModel.ISupportInitialize)(this.numeric_generators_generatePassword_length)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_math_calculateCombinations_group)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_math_calculateCombinations_elements)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_math_calculateFactorial_factorial)).EndInit();
			this.tabs_tg.ResumeLayout(false);
			this.tab_database.ResumeLayout(false);
			this.tabs_database.ResumeLayout(false);
			this.tab_database_createDatabase.ResumeLayout(false);
			this.tab_database_createTable.ResumeLayout(false);
			this.tab_database_insertInto.ResumeLayout(false);
			this.tab_database_deleteTable.ResumeLayout(false);
			this.tab_database_select.ResumeLayout(false);
			this.tab_database_delete.ResumeLayout(false);
			this.tab_tools.ResumeLayout(false);
			this.tabs_tools.ResumeLayout(false);
			this.tab_tools_hash.ResumeLayout(false);
			this.tab_tools_hash.PerformLayout();
			this.tab_tools_databaseTools.ResumeLayout(false);
			this.tabs_tools_databaseTools.ResumeLayout(false);
			this.tab_tools_databaseTools_checkLogin.ResumeLayout(false);
			this.tab_tools_databaseTools_checkLogin.PerformLayout();
			this.tab_tools_databaseTools_filterSql.ResumeLayout(false);
			this.tab_tools_databaseTools_filterSql.PerformLayout();
			this.tab_tools_databaseTools_selectUnique.ResumeLayout(false);
			this.tab_tools_databaseTools_selectUnique.PerformLayout();
			this.tab_tools_crash.ResumeLayout(false);
			this.tab_tools_log.ResumeLayout(false);
			this.tab_tools_log.PerformLayout();
			this.tab_tools_getDate.ResumeLayout(false);
			this.tab_tools_getDate.PerformLayout();
			this.tab_tools_setWallpaper6getGifFrames.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_tools_setWallpaper6getGifFrames_gif)).EndInit();
			this.tab_generators.ResumeLayout(false);
			this.tabs_generators.ResumeLayout(false);
			this.tab_generators_generatePassword.ResumeLayout(false);
			this.tab_generators_generatePassword.PerformLayout();
			this.tab_controls.ResumeLayout(false);
			this.tabs_controls.ResumeLayout(false);
			this.tab_controls_controls.ResumeLayout(false);
			this.tabs_controls_controls.ResumeLayout(false);
			this.tab_lineGraph.ResumeLayout(false);
			this.tab_controls_tweaks.ResumeLayout(false);
			this.tabs_controls_tweaks.ResumeLayout(false);
			this.tab_controls_tweaks_comboBox.ResumeLayout(false);
			this.tabs_controls_comboBox.ResumeLayout(false);
			this.tab_controls_comboBox_resizeComboBox.ResumeLayout(false);
			this.tab_controls_textBox.ResumeLayout(false);
			this.tabs_controls_textBox.ResumeLayout(false);
			this.tab_controls_textBox_onlyNumbersTextBox.ResumeLayout(false);
			this.tab_controls_textBox_onlyNumbersTextBox.PerformLayout();
			this.tab_controls_form.ResumeLayout(false);
			this.tabs_controls_form.ResumeLayout(false);
			this.tab_controls_form_getOpenForms.ResumeLayout(false);
			this.tab_controls_messageBox.ResumeLayout(false);
			this.tabs_controls_messageBox.ResumeLayout(false);
			this.tab_controls_messageBox_showConfirmationDialog.ResumeLayout(false);
			this.tab_network.ResumeLayout(false);
			this.tabs_network.ResumeLayout(false);
			this.tab_network_wifi.ResumeLayout(false);
			this.tabs_network_wifi.ResumeLayout(false);
			this.tab_network_wifi_connect.ResumeLayout(false);
			this.tab_network_wifi_connect.PerformLayout();
			this.tab_network_packets.ResumeLayout(false);
			this.tabs_network_packets.ResumeLayout(false);
			this.tab_network_packets_sendTcpPacket.ResumeLayout(false);
			this.tab_network_packets_sendTcpPacket.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_packets_sendTcpPacket_remotePort)).EndInit();
			this.tab_network_packets_waitTcpPacket.ResumeLayout(false);
			this.tab_network_packets_waitTcpPacket.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_packets_waitTcpPacket_localPort)).EndInit();
			this.tab_network_packets_sendUdpPacket.ResumeLayout(false);
			this.tab_network_packets_sendUdpPacket.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_packets_sendUdpPacket_remotePort)).EndInit();
			this.tab_network_packets_waitUdpPacket.ResumeLayout(false);
			this.tab_network_packets_waitUdpPacket.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_packets_waitUdpPacket_localPort)).EndInit();
			this.tab_network_mobile.ResumeLayout(false);
			this.tabs_network_mobile.ResumeLayout(false);
			this.tab_network_mobile_sendSms.ResumeLayout(false);
			this.tab_network_mobile_sendSms.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_mobile_sendSms_smtpPort)).EndInit();
			this.tab_network_security.ResumeLayout(false);
			this.tabs_network_security.ResumeLayout(false);
			this.tab_network_security_openFirewallPort.ResumeLayout(false);
			this.tab_network_security_openFirewallPort.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_network_security_openFirewallPort_portNumber)).EndInit();
			this.tab_network_requests.ResumeLayout(false);
			this.tabs_network_requests.ResumeLayout(false);
			this.tab_network_requests_get.ResumeLayout(false);
			this.tab_network_requests_get.PerformLayout();
			this.tab_network_requests_post.ResumeLayout(false);
			this.tab_network_requests_post.PerformLayout();
			this.tab_network_apis.ResumeLayout(false);
			this.tabs_network_apis.ResumeLayout(false);
			this.tab_network_apis_riotapi.ResumeLayout(false);
			this.tabs_network_apis_riotapi.ResumeLayout(false);
			this.tab_network_apis_riotapi_championMastery.ResumeLayout(false);
			this.tabs_network_apis_riotapi_championMastery.ResumeLayout(false);
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.ResumeLayout(false);
			this.tab_network_apis_riotapi_championMastery_getChampionMasteryList.PerformLayout();
			this.tab_math.ResumeLayout(false);
			this.tabs_math.ResumeLayout(false);
			this.tab_math_calculateCombinations.ResumeLayout(false);
			this.tab_math_calculateCombinations.PerformLayout();
			this.tab_math_calculateFactorial.ResumeLayout(false);
			this.tab_math_calculateFactorial.PerformLayout();
			this.tab_math_isPrimeNumber.ResumeLayout(false);
			this.tab_math_isPrimeNumber.PerformLayout();
			this.tab_dynvars.ResumeLayout(false);
			this.tab_dynvars.PerformLayout();
			this.tab_device.ResumeLayout(false);
			this.tabs_device.ResumeLayout(false);
			this.tab_device_getRam.ResumeLayout(false);
			this.tab_device_getRam.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_tg_testingIndex)).EndInit();
			this.tab_controls_form_allowDrag.ResumeLayout(false);
			this.tab_controls_form_allowDrag.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button button_database_createTable;
		internal System.Windows.Forms.Button button_database_deleteTable;
		internal System.Windows.Forms.Button button_database_insert;
		internal System.Windows.Forms.Button button_database_createDatabase;
		internal System.Windows.Forms.Button button_database_select;
		internal System.Windows.Forms.TextBox textBox_generators_generatePassword_password;
		internal System.Windows.Forms.NumericUpDown numeric_generators_generatePassword_length;
		internal System.Windows.Forms.ComboBox comboBox_tg_databaseType;
		internal System.Windows.Forms.Button button_database_delete;
		internal System.Windows.Forms.Button button_generators_generatePassword_generate;
		internal System.Windows.Forms.Timer timer_tg_date;
		internal System.Windows.Forms.OpenFileDialog fileDialog_tg_searchGif;
		internal System.Windows.Forms.Button button_network_wifi_connect_connect;
		internal System.Windows.Forms.Label label_network_wifi_connect_password;
		internal System.Windows.Forms.Label label_network_wifi_connect_ssid;
		internal System.Windows.Forms.TextBox textBox_network_wifi_connect_wifiPassword;
		internal System.Windows.Forms.TextBox textBox_network_wifi_connect_wifiSsid;
		internal System.Windows.Forms.OpenFileDialog fileDialog_tg_readFile;
		internal System.Windows.Forms.Button button_math_calculateCombinations_calculate;
		internal System.Windows.Forms.NumericUpDown numeric_math_calculateCombinations_elements;
		internal System.Windows.Forms.NumericUpDown numeric_math_calculateCombinations_group;
		internal System.Windows.Forms.Label label_math_calculateCombinations_group;
		internal System.Windows.Forms.Label label_math_calculateCombinations_elements;
		internal System.Windows.Forms.Button button_math_calculateFactorial_calculate;
		internal System.Windows.Forms.Label label_math_calculateFactorial_factorial;
		internal System.Windows.Forms.NumericUpDown numeric_math_calculateFactorial_factorial;
		internal System.Windows.Forms.TabControl tabs_tg;
		internal System.Windows.Forms.TabPage tab_database;
		internal System.Windows.Forms.TabPage tab_tools;
		internal System.Windows.Forms.TabPage tab_generators;
		internal System.Windows.Forms.TabControl tabs_generators;
		internal System.Windows.Forms.TabPage tab_generators_generatePassword;
		internal System.Windows.Forms.Label _generators_generatePassword_length;
		internal System.Windows.Forms.TabPage tab_controls;
		internal System.Windows.Forms.TabPage tab_network;
		internal System.Windows.Forms.TabControl tabs_network;
		internal System.Windows.Forms.TabPage tab_network_wifi;
		internal System.Windows.Forms.TabControl tabs_network_wifi;
		internal System.Windows.Forms.TabPage tab_network_wifi_connect;
		internal System.Windows.Forms.TabPage tab_network_packets;
		internal System.Windows.Forms.TabControl tabs_network_packets;
		internal System.Windows.Forms.TabPage tab_network_packets_sendTcpPacket;
		internal System.Windows.Forms.TabPage tab_network_packets_waitTcpPacket;
		internal System.Windows.Forms.TabPage tab_math;
		internal System.Windows.Forms.TabControl tabs_math;
		internal System.Windows.Forms.TabPage tab_math_calculateCombinations;
		internal System.Windows.Forms.TabPage tab_math_calculateFactorial;
		internal System.Windows.Forms.Label label_tg_databaseType;
		internal System.Windows.Forms.TabControl tabs_database;
		internal System.Windows.Forms.TabPage tab_database_createDatabase;
		internal System.Windows.Forms.TabPage tab_database_createTable;
		internal System.Windows.Forms.TabPage tab_database_insertInto;
		internal System.Windows.Forms.TabPage tab_database_deleteTable;
		internal System.Windows.Forms.TabPage tab_database_select;
		internal System.Windows.Forms.TabPage tab_database_delete;
		internal System.Windows.Forms.Label label_tg_version;
		internal System.Windows.Forms.TextBox textBox_tg_version;
		internal System.Windows.Forms.TabPage tab_network_packets_sendUdpPacket;
		internal System.Windows.Forms.Button button_network_packets_sendUdpPacket_send;
		internal System.Windows.Forms.TabPage tab_network_packets_waitUdpPacket;
		internal System.Windows.Forms.Button button_network_packets_waitUdpPacket_wait;
		internal System.Windows.Forms.NumericUpDown numeric_network_packets_sendUdpPacket_remotePort;
		internal System.Windows.Forms.Label label_network_packets_waitUdpPacket_localPort;
		internal System.Windows.Forms.NumericUpDown numeric_network_packets_waitUdpPacket_localPort;
		internal System.Windows.Forms.Label label_network_packets_sendUdpPacket_message;
		internal System.Windows.Forms.Label label_network_packets_sendUdpPacket_remotePort;
		internal System.Windows.Forms.Label label_network_packets_sendUdpPacket_remoteIp;
		internal System.Windows.Forms.TextBox textBox_network_packets_sendUdpPacket_message;
		internal System.Windows.Forms.TextBox textBox_network_packets_sendUdpPacket_remoteIp;
		internal System.Windows.Forms.Label label_network_packets_sendTcpPacket_message;
		internal System.Windows.Forms.Label label_network_packets_sendTcpPacket_remotePort;
		internal System.Windows.Forms.Label label_network_packets_sendTcpPacket_remoteIp;
		internal System.Windows.Forms.TextBox textBox_network_packets_sendTcpPacket_message;
		internal System.Windows.Forms.TextBox textBox_network_packets_sendTcpPacket_remoteIp;
		internal System.Windows.Forms.NumericUpDown numeric_network_packets_sendTcpPacket_remotePort;
		internal System.Windows.Forms.Button button_network_packets_sendTcpPacket_send;
		internal System.Windows.Forms.Label label_network_packets_waitTcpPacket_localPort;
		internal System.Windows.Forms.NumericUpDown numeric_network_packets_waitTcpPacket_localPort;
		internal System.Windows.Forms.Button button_network_packets_waitTcpPacket_wait;
		internal System.Windows.Forms.TabPage tab_network_mobile;
		internal System.Windows.Forms.TabControl tabs_network_mobile;
		internal System.Windows.Forms.TabPage tab_network_mobile_sendSms;
		internal System.Windows.Forms.TextBox textBox_network_mobile_sendSms_senderEmail;
		internal System.Windows.Forms.Label label_network_mobile_sendSms_senderEmailPassword;
		internal System.Windows.Forms.Label label_network_mobile_sendSms_senderEmail;
		internal System.Windows.Forms.TextBox textBox_network_mobile_sendSms_senderEmailPassword;
		internal System.Windows.Forms.Label label_network_mobile_sendSms_receiverPhone;
		internal System.Windows.Forms.TextBox textBox_network_mobile_sendSms_receiverPhone;
		internal System.Windows.Forms.Label label_network_mobile_sendSms_message;
		internal System.Windows.Forms.TextBox textBox_network_mobile_sendSms_message;
		internal System.Windows.Forms.Label label_network_mobile_sendSms_subject;
		internal System.Windows.Forms.TextBox textBox_network_mobile_sendSms_subject;
		internal System.Windows.Forms.Button button_network_mobile_sendSms_sendSms;
		internal System.Windows.Forms.Label label_network_mobile_sendSms_smtpHost;
		internal System.Windows.Forms.TextBox textBox_network_mobile_sendSms_smtpHost;
		internal System.Windows.Forms.Label label_network_mobile_sendSms_smsCarrier;
		internal System.Windows.Forms.TextBox textBox_network_mobile_sendSms_smsCarrier;
		internal System.Windows.Forms.NumericUpDown numeric_network_mobile_sendSms_smtpPort;
		internal System.Windows.Forms.Label label_network_mobile_sendSms_smtpPort;
		internal System.Windows.Forms.Button button_tg_test;
		internal System.Windows.Forms.TabPage tab_dynvars;
		internal System.Windows.Forms.Label label_dynvars_value;
		internal System.Windows.Forms.Label label_dynvars_variable;
		internal System.Windows.Forms.Button button_dynvars_run;
		internal System.Windows.Forms.TextBox textBox_dynvars_value;
		internal System.Windows.Forms.TextBox textBox_dynvars_variable;
		internal System.Windows.Forms.TabPage tab_math_isPrimeNumber;
		internal System.Windows.Forms.Label label_math_isPrimeNumber_number;
		internal System.Windows.Forms.TextBox textBox_math_isPrimeNumber_number;
		internal System.Windows.Forms.Button button_math_isPrimeNumber_check;
		internal System.Windows.Forms.CheckBox checkBox_tg_debug;
		internal System.Windows.Forms.CheckBox checkBox_tg_debugErrors;
		internal System.Windows.Forms.TabPage tab_network_security;
		internal System.Windows.Forms.TabControl tabs_network_security;
		internal System.Windows.Forms.TabPage tab_network_security_openFirewallPort;
		internal System.Windows.Forms.Button button_network_security_openFirewallPort_open;
		internal System.Windows.Forms.Label label_network_security_openFirewallPort_portType;
		internal System.Windows.Forms.ComboBox comboBox_network_security_openFirewallPort_portType;
		internal System.Windows.Forms.Label label_network_security_openFirewallPort_description;
		internal System.Windows.Forms.Label label_network_security_openFirewallPort_portNumber;
		internal System.Windows.Forms.NumericUpDown numeric_network_security_openFirewallPort_portNumber;
		internal System.Windows.Forms.TextBox textBox_network_security_openFirewallPort_description;
		internal System.Windows.Forms.NumericUpDown numeric_tg_testingIndex;
        internal System.Windows.Forms.TextBox textBox_generators_generatePassword_allowedChars;
        internal System.Windows.Forms.Label label_generators_generatePassword_allowedChars;
        internal System.Windows.Forms.Label label_network_security_openFirewallPort_warningAdmin;
        internal System.Windows.Forms.TabPage tab_device;
        internal System.Windows.Forms.TabControl tabs_device;
        internal System.Windows.Forms.TabPage tab_device_getRam;
        internal System.Windows.Forms.Button button_device_getRam_update;
        internal System.Windows.Forms.ComboBox comboBox_device_getRam_ramType;
        internal System.Windows.Forms.TextBox textBox_device_getRam_value;
		internal System.Windows.Forms.TabControl tabs_controls_tweaks;
		internal System.Windows.Forms.TabPage tab_controls_tweaks_comboBox;
		internal System.Windows.Forms.TabControl tabs_controls_comboBox;
		internal System.Windows.Forms.TabPage tab_controls_comboBox_resizeComboBox;
		internal System.Windows.Forms.ComboBox comboBox_controls_comboBox_resizeComboBox_resize;
		internal System.Windows.Forms.Button button_controls_comboBox_resizeComboBox_resize;
		internal System.Windows.Forms.TabPage tab_controls_textBox;
		internal System.Windows.Forms.TabControl tabs_controls_textBox;
		internal System.Windows.Forms.TabPage tab_controls_textBox_onlyNumbersTextBox;
		internal System.Windows.Forms.CheckBox checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers;
		internal System.Windows.Forms.TextBox textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers;
		internal System.Windows.Forms.TabPage tab_controls_form;
		internal System.Windows.Forms.TabControl tabs_controls_form;
		internal System.Windows.Forms.TabPage tab_controls_form_getOpenForms;
		internal System.Windows.Forms.Button button_controls_form_getOpenForms_getOpenForms;
		internal System.Windows.Forms.TabPage tab_controls_messageBox;
		internal System.Windows.Forms.TabControl tabs_controls_messageBox;
		internal System.Windows.Forms.TabPage tab_controls_messageBox_showConfirmationDialog;
		internal System.Windows.Forms.Button button_controls_messageBox_showConfirmationDialog_show;
		internal System.Windows.Forms.Label label_device_getRam_gb;
		internal System.Windows.Forms.TabControl tabs_controls;
		internal System.Windows.Forms.TabPage tab_controls_controls;
		internal System.Windows.Forms.TabPage tab_controls_tweaks;
		internal System.Windows.Forms.TabControl tabs_controls_controls;
		internal System.Windows.Forms.TabPage tab_lineGraph;
		internal ScriptsLib.Controls.LineGraph lineGraph;
		internal System.Windows.Forms.Button button_lineGraph_drawTest;
		internal System.Windows.Forms.TabControl tabs_tools;
		internal System.Windows.Forms.TabPage tab_tools_hash;
		internal System.Windows.Forms.Label label_tools_hash_hashed;
		internal System.Windows.Forms.Label label_tools_hash_text;
		internal System.Windows.Forms.TextBox textBox_tools_hash_hashed;
		internal System.Windows.Forms.TextBox textBox_tools_hash_text;
		internal System.Windows.Forms.TabPage tab_tools_databaseTools;
		internal System.Windows.Forms.TabControl tabs_tools_databaseTools;
		internal System.Windows.Forms.TabPage tab_tools_databaseTools_checkLogin;
		internal System.Windows.Forms.TextBox textBox_tools_databaseTools_checkLogin_user;
		internal System.Windows.Forms.Button button_tools_databaseTools_checkLogin_login;
		internal System.Windows.Forms.Label label_tools_databaseTools_checkLogin_pass;
		internal System.Windows.Forms.Label label_tools_databaseTools_checkLogin_user;
		internal System.Windows.Forms.TextBox textBox_tools_databaseTools_checkLogin_pass;
		internal System.Windows.Forms.TabPage tab_tools_databaseTools_filterSql;
		internal System.Windows.Forms.Button button_tools_databaseTools_filterSql_filter;
		internal System.Windows.Forms.TextBox textBox_tools_databaseTools_filterSql_text;
		internal System.Windows.Forms.TabPage tab_tools_databaseTools_selectUnique;
		internal System.Windows.Forms.Button button_tools_databaseTools_selectUnique_select;
		internal System.Windows.Forms.TextBox textBox_tools_databaseTools_selectUnique_table;
		internal System.Windows.Forms.TextBox textBox_tools_databaseTools_selectUnique_column;
		internal System.Windows.Forms.TabPage tab_tools_crash;
		internal System.Windows.Forms.Button button_tools_crash_crash;
		internal System.Windows.Forms.TabPage tab_tools_log;
		internal System.Windows.Forms.Label label_tools_log_message;
		internal System.Windows.Forms.Label label_tools_log_type;
		internal System.Windows.Forms.TextBox textBox_tools_log_logSource;
		internal System.Windows.Forms.TextBox textBox_tools_log_logMessage;
		internal System.Windows.Forms.ComboBox comboBox_tools_log_logType;
		internal System.Windows.Forms.Label label_tools_log_source;
		internal System.Windows.Forms.Button button_tools_log_log;
		internal System.Windows.Forms.TabPage tab_tools_getDate;
		internal System.Windows.Forms.Label label_tools_getDate_date;
		internal System.Windows.Forms.TabPage tab_tools_setWallpaper6getGifFrames;
		internal System.Windows.Forms.Button button_tools_setWallpaper6getGifFrames_searchGif;
		internal System.Windows.Forms.PictureBox pictureBox_tools_setWallpaper6getGifFrames_gif;
		internal System.Windows.Forms.Button button_tools_setWallpaper6getGifFrames_setWallpaper;
		internal System.Windows.Forms.TabPage tab_network_requests;
		internal System.Windows.Forms.TabControl tabs_network_requests;
		internal System.Windows.Forms.TabPage tab_network_requests_get;
		internal System.Windows.Forms.TextBox textBox_network_requests_get_endpoint;
		internal System.Windows.Forms.Button button_network_requests_get_execute;
		internal System.Windows.Forms.Label label_network_requests_get_endpoint;
		internal System.Windows.Forms.TabPage tab_network_requests_post;
		internal System.Windows.Forms.TextBox textBox_network_requests_post_endpoint;
		internal System.Windows.Forms.TextBox textBox_network_requests_post_data;
		internal System.Windows.Forms.Button button_network_requests_post_execute;
		internal System.Windows.Forms.Label label_network_requests_post_endpoint;
		internal System.Windows.Forms.Label label_network_requests_post_data;
		internal System.Windows.Forms.TabPage tab_network_apis;
		internal System.Windows.Forms.TabControl tabs_network_apis;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi;
		internal System.Windows.Forms.TabControl tabs_network_apis_riotapi;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_championMastery;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_champion;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_leagueExp;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_league;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_lolStatus;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_match;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_spectator;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_summoner;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_tftLeague;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_tftMatch;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_tftSummoner;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_thirdPartyCode;
		internal System.Windows.Forms.TabControl tabs_network_apis_riotapi_championMastery;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_championMastery_getChampionMasteryList;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_championMastery_getMasteryByChampion;
		internal System.Windows.Forms.TabPage tab_network_apis_riotapi_championMastery_getTotalMasteryScore;
		internal System.Windows.Forms.Label label1_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId;
		internal System.Windows.Forms.TextBox textBox_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId;
		internal System.Windows.Forms.Button button_network_apis_riotapi_championMastery_getChampionMasteryList_get;
		internal System.Windows.Forms.Button button_tg_keys;
		internal System.Windows.Forms.Button button_tg_refresh;
		internal System.Windows.Forms.TabPage tab_controls_form_allowDrag;
		internal System.Windows.Forms.CheckBox checkBox_controls_form_allowDrag;
	}
}