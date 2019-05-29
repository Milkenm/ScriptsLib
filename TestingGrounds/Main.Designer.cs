namespace TestingGrounds
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.button_criarTabela = new System.Windows.Forms.Button();
			this.button_apagarTabela = new System.Windows.Forms.Button();
			this.button_insert = new System.Windows.Forms.Button();
			this.button_criarBd = new System.Windows.Forms.Button();
			this.button_crash = new System.Windows.Forms.Button();
			this.button_login = new System.Windows.Forms.Button();
			this.groupBox_database = new System.Windows.Forms.GroupBox();
			this.button_delete = new System.Windows.Forms.Button();
			this.comboBox_databaseType = new System.Windows.Forms.ComboBox();
			this.button_select = new System.Windows.Forms.Button();
			this.groupBox_tools_crash = new System.Windows.Forms.GroupBox();
			this.comboBox_resize = new System.Windows.Forms.ComboBox();
			this.button_resizeCombobox = new System.Windows.Forms.Button();
			this.button_sqlFilter = new System.Windows.Forms.Button();
			this.textBox_sqlFilter = new System.Windows.Forms.TextBox();
			this.numeric_passwordLength = new System.Windows.Forms.NumericUpDown();
			this.textBox_generatePassword = new System.Windows.Forms.TextBox();
			this.button_generatePassword = new System.Windows.Forms.Button();
			this.textBox_logMessage = new System.Windows.Forms.TextBox();
			this.button_log = new System.Windows.Forms.Button();
			this.label_pass = new System.Windows.Forms.Label();
			this.label_user = new System.Windows.Forms.Label();
			this.textBox_pass = new System.Windows.Forms.TextBox();
			this.textBox_user = new System.Windows.Forms.TextBox();
			this.textBox_logSource = new System.Windows.Forms.TextBox();
			this.comboBox_logType = new System.Windows.Forms.ComboBox();
			this.groupBox_toolHash = new System.Windows.Forms.GroupBox();
			this.textBox_hash = new System.Windows.Forms.TextBox();
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.statusBarPanel_label = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel_message = new System.Windows.Forms.StatusBarPanel();
			this.groupBox_tools_checkLogin = new System.Windows.Forms.GroupBox();
			this.groupBox__tools_log = new System.Windows.Forms.GroupBox();
			this.groupBox_controls_resizeComboBox = new System.Windows.Forms.GroupBox();
			this.groupBox_tools_sqlFilter = new System.Windows.Forms.GroupBox();
			this.groupBox_generators_generatePassword = new System.Windows.Forms.GroupBox();
			this.groupBox_controls_onlyNumbersTextBox = new System.Windows.Forms.GroupBox();
			this.textBox_onlyNumbers = new System.Windows.Forms.TextBox();
			this.checkBox_onlyNumbers = new System.Windows.Forms.CheckBox();
			this.groupBox_database.SuspendLayout();
			this.groupBox_tools_crash.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_passwordLength)).BeginInit();
			this.groupBox_toolHash.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel_label)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel_message)).BeginInit();
			this.groupBox_tools_checkLogin.SuspendLayout();
			this.groupBox__tools_log.SuspendLayout();
			this.groupBox_controls_resizeComboBox.SuspendLayout();
			this.groupBox_tools_sqlFilter.SuspendLayout();
			this.groupBox_generators_generatePassword.SuspendLayout();
			this.groupBox_controls_onlyNumbersTextBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_criarTabela
			// 
			this.button_criarTabela.Location = new System.Drawing.Point(109, 19);
			this.button_criarTabela.Name = "button_criarTabela";
			this.button_criarTabela.Size = new System.Drawing.Size(85, 23);
			this.button_criarTabela.TabIndex = 0;
			this.button_criarTabela.Text = "Criar Tabela";
			this.button_criarTabela.UseVisualStyleBackColor = true;
			this.button_criarTabela.Click += new System.EventHandler(this.button_criarTabela_Click);
			// 
			// button_apagarTabela
			// 
			this.button_apagarTabela.Location = new System.Drawing.Point(109, 48);
			this.button_apagarTabela.Name = "button_apagarTabela";
			this.button_apagarTabela.Size = new System.Drawing.Size(85, 23);
			this.button_apagarTabela.TabIndex = 1;
			this.button_apagarTabela.Text = "Apagar Tabela";
			this.button_apagarTabela.UseVisualStyleBackColor = true;
			this.button_apagarTabela.Click += new System.EventHandler(this.button_apagarTabela_Click);
			// 
			// button_insert
			// 
			this.button_insert.Location = new System.Drawing.Point(6, 48);
			this.button_insert.Name = "button_insert";
			this.button_insert.Size = new System.Drawing.Size(85, 23);
			this.button_insert.TabIndex = 2;
			this.button_insert.Text = "Insert";
			this.button_insert.UseVisualStyleBackColor = true;
			this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
			// 
			// button_criarBd
			// 
			this.button_criarBd.Location = new System.Drawing.Point(6, 19);
			this.button_criarBd.Name = "button_criarBd";
			this.button_criarBd.Size = new System.Drawing.Size(85, 23);
			this.button_criarBd.TabIndex = 3;
			this.button_criarBd.Text = "Criar BD";
			this.button_criarBd.UseVisualStyleBackColor = true;
			this.button_criarBd.Click += new System.EventHandler(this.button_criarBd_Click);
			// 
			// button_crash
			// 
			this.button_crash.Location = new System.Drawing.Point(6, 19);
			this.button_crash.Name = "button_crash";
			this.button_crash.Size = new System.Drawing.Size(188, 23);
			this.button_crash.TabIndex = 4;
			this.button_crash.Text = "Crash";
			this.button_crash.UseVisualStyleBackColor = true;
			this.button_crash.Click += new System.EventHandler(this.button_crash_Click);
			// 
			// button_login
			// 
			this.button_login.Location = new System.Drawing.Point(110, 60);
			this.button_login.Name = "button_login";
			this.button_login.Size = new System.Drawing.Size(85, 23);
			this.button_login.TabIndex = 5;
			this.button_login.Text = "Login";
			this.button_login.UseVisualStyleBackColor = true;
			this.button_login.Click += new System.EventHandler(this.button_login_Click);
			// 
			// groupBox_database
			// 
			this.groupBox_database.Controls.Add(this.button_delete);
			this.groupBox_database.Controls.Add(this.comboBox_databaseType);
			this.groupBox_database.Controls.Add(this.button_select);
			this.groupBox_database.Controls.Add(this.button_criarTabela);
			this.groupBox_database.Controls.Add(this.button_insert);
			this.groupBox_database.Controls.Add(this.button_apagarTabela);
			this.groupBox_database.Controls.Add(this.button_criarBd);
			this.groupBox_database.Location = new System.Drawing.Point(2, 2);
			this.groupBox_database.Name = "groupBox_database";
			this.groupBox_database.Size = new System.Drawing.Size(200, 148);
			this.groupBox_database.TabIndex = 6;
			this.groupBox_database.TabStop = false;
			this.groupBox_database.Text = "Database";
			// 
			// button_delete
			// 
			this.button_delete.Location = new System.Drawing.Point(109, 77);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(85, 23);
			this.button_delete.TabIndex = 6;
			this.button_delete.Text = "Delete";
			this.button_delete.UseVisualStyleBackColor = true;
			this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
			// 
			// comboBox_databaseType
			// 
			this.comboBox_databaseType.FormattingEnabled = true;
			this.comboBox_databaseType.Items.AddRange(new object[] {
            "Sql Server",
            "Access",
            "MySql"});
			this.comboBox_databaseType.Location = new System.Drawing.Point(6, 119);
			this.comboBox_databaseType.Name = "comboBox_databaseType";
			this.comboBox_databaseType.Size = new System.Drawing.Size(188, 21);
			this.comboBox_databaseType.TabIndex = 5;
			// 
			// button_select
			// 
			this.button_select.Location = new System.Drawing.Point(6, 77);
			this.button_select.Name = "button_select";
			this.button_select.Size = new System.Drawing.Size(85, 23);
			this.button_select.TabIndex = 4;
			this.button_select.Text = "Select";
			this.button_select.UseVisualStyleBackColor = true;
			this.button_select.Click += new System.EventHandler(this.button_select_Click);
			// 
			// groupBox_tools_crash
			// 
			this.groupBox_tools_crash.Controls.Add(this.button_crash);
			this.groupBox_tools_crash.Location = new System.Drawing.Point(208, 150);
			this.groupBox_tools_crash.Name = "groupBox_tools_crash";
			this.groupBox_tools_crash.Size = new System.Drawing.Size(200, 51);
			this.groupBox_tools_crash.TabIndex = 7;
			this.groupBox_tools_crash.TabStop = false;
			this.groupBox_tools_crash.Text = "Tools.Crash";
			// 
			// comboBox_resize
			// 
			this.comboBox_resize.FormattingEnabled = true;
			this.comboBox_resize.Location = new System.Drawing.Point(53, 20);
			this.comboBox_resize.Name = "comboBox_resize";
			this.comboBox_resize.Size = new System.Drawing.Size(141, 21);
			this.comboBox_resize.TabIndex = 14;
			// 
			// button_resizeCombobox
			// 
			this.button_resizeCombobox.Location = new System.Drawing.Point(6, 19);
			this.button_resizeCombobox.Name = "button_resizeCombobox";
			this.button_resizeCombobox.Size = new System.Drawing.Size(47, 39);
			this.button_resizeCombobox.TabIndex = 13;
			this.button_resizeCombobox.Text = "Resize";
			this.button_resizeCombobox.UseVisualStyleBackColor = true;
			this.button_resizeCombobox.Click += new System.EventHandler(this.button_resizeCombobox_Click);
			// 
			// button_sqlFilter
			// 
			this.button_sqlFilter.Location = new System.Drawing.Point(157, 18);
			this.button_sqlFilter.Name = "button_sqlFilter";
			this.button_sqlFilter.Size = new System.Drawing.Size(37, 22);
			this.button_sqlFilter.TabIndex = 14;
			this.button_sqlFilter.Text = "Filter";
			this.button_sqlFilter.UseVisualStyleBackColor = true;
			this.button_sqlFilter.Click += new System.EventHandler(this.button_sqlFilter_Click);
			// 
			// textBox_sqlFilter
			// 
			this.textBox_sqlFilter.Location = new System.Drawing.Point(6, 19);
			this.textBox_sqlFilter.Name = "textBox_sqlFilter";
			this.textBox_sqlFilter.Size = new System.Drawing.Size(151, 20);
			this.textBox_sqlFilter.TabIndex = 13;
			// 
			// numeric_passwordLength
			// 
			this.numeric_passwordLength.Location = new System.Drawing.Point(6, 40);
			this.numeric_passwordLength.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.numeric_passwordLength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numeric_passwordLength.Name = "numeric_passwordLength";
			this.numeric_passwordLength.Size = new System.Drawing.Size(33, 20);
			this.numeric_passwordLength.TabIndex = 12;
			this.numeric_passwordLength.Tag = "";
			this.numeric_passwordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// textBox_generatePassword
			// 
			this.textBox_generatePassword.Location = new System.Drawing.Point(6, 19);
			this.textBox_generatePassword.Name = "textBox_generatePassword";
			this.textBox_generatePassword.Size = new System.Drawing.Size(188, 20);
			this.textBox_generatePassword.TabIndex = 11;
			// 
			// button_generatePassword
			// 
			this.button_generatePassword.Location = new System.Drawing.Point(83, 40);
			this.button_generatePassword.Name = "button_generatePassword";
			this.button_generatePassword.Size = new System.Drawing.Size(111, 22);
			this.button_generatePassword.TabIndex = 10;
			this.button_generatePassword.Text = "Generate Password";
			this.button_generatePassword.UseVisualStyleBackColor = true;
			this.button_generatePassword.Click += new System.EventHandler(this.button_generatePassword_Click);
			// 
			// textBox_logMessage
			// 
			this.textBox_logMessage.Location = new System.Drawing.Point(8, 19);
			this.textBox_logMessage.Name = "textBox_logMessage";
			this.textBox_logMessage.Size = new System.Drawing.Size(128, 20);
			this.textBox_logMessage.TabIndex = 16;
			// 
			// button_log
			// 
			this.button_log.Location = new System.Drawing.Point(136, 18);
			this.button_log.Name = "button_log";
			this.button_log.Size = new System.Drawing.Size(58, 22);
			this.button_log.TabIndex = 15;
			this.button_log.Text = "Log";
			this.button_log.UseVisualStyleBackColor = true;
			this.button_log.Click += new System.EventHandler(this.button_log_Click);
			// 
			// label_pass
			// 
			this.label_pass.AutoSize = true;
			this.label_pass.Location = new System.Drawing.Point(6, 43);
			this.label_pass.Name = "label_pass";
			this.label_pass.Size = new System.Drawing.Size(33, 13);
			this.label_pass.TabIndex = 9;
			this.label_pass.Text = "Pass:";
			// 
			// label_user
			// 
			this.label_user.AutoSize = true;
			this.label_user.Location = new System.Drawing.Point(7, 22);
			this.label_user.Name = "label_user";
			this.label_user.Size = new System.Drawing.Size(32, 13);
			this.label_user.TabIndex = 8;
			this.label_user.Text = "User:";
			// 
			// textBox_pass
			// 
			this.textBox_pass.Location = new System.Drawing.Point(40, 40);
			this.textBox_pass.Name = "textBox_pass";
			this.textBox_pass.Size = new System.Drawing.Size(154, 20);
			this.textBox_pass.TabIndex = 7;
			// 
			// textBox_user
			// 
			this.textBox_user.Location = new System.Drawing.Point(40, 19);
			this.textBox_user.Name = "textBox_user";
			this.textBox_user.Size = new System.Drawing.Size(154, 20);
			this.textBox_user.TabIndex = 6;
			// 
			// textBox_logSource
			// 
			this.textBox_logSource.Location = new System.Drawing.Point(8, 40);
			this.textBox_logSource.Name = "textBox_logSource";
			this.textBox_logSource.Size = new System.Drawing.Size(128, 20);
			this.textBox_logSource.TabIndex = 17;
			// 
			// comboBox_logType
			// 
			this.comboBox_logType.FormattingEnabled = true;
			this.comboBox_logType.Items.AddRange(new object[] {
            "INFO",
            "ERROR",
            "WARNING"});
			this.comboBox_logType.Location = new System.Drawing.Point(137, 40);
			this.comboBox_logType.Name = "comboBox_logType";
			this.comboBox_logType.Size = new System.Drawing.Size(56, 21);
			this.comboBox_logType.TabIndex = 18;
			// 
			// groupBox_toolHash
			// 
			this.groupBox_toolHash.Controls.Add(this.textBox_hash);
			this.groupBox_toolHash.Location = new System.Drawing.Point(2, 156);
			this.groupBox_toolHash.Name = "groupBox_toolHash";
			this.groupBox_toolHash.Size = new System.Drawing.Size(200, 50);
			this.groupBox_toolHash.TabIndex = 8;
			this.groupBox_toolHash.TabStop = false;
			this.groupBox_toolHash.Text = "Tools.Hash";
			// 
			// textBox_hash
			// 
			this.textBox_hash.Location = new System.Drawing.Point(6, 19);
			this.textBox_hash.Name = "textBox_hash";
			this.textBox_hash.Size = new System.Drawing.Size(188, 20);
			this.textBox_hash.TabIndex = 0;
			this.textBox_hash.TextChanged += new System.EventHandler(this.textBox_hash_TextChanged);
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 357);
			this.statusBar.Name = "statusBar";
			this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel_label,
            this.statusBarPanel_message});
			this.statusBar.ShowPanels = true;
			this.statusBar.Size = new System.Drawing.Size(592, 22);
			this.statusBar.TabIndex = 9;
			// 
			// statusBarPanel_label
			// 
			this.statusBarPanel_label.Name = "statusBarPanel_label";
			this.statusBarPanel_label.Width = 50;
			// 
			// statusBarPanel_message
			// 
			this.statusBarPanel_message.Name = "statusBarPanel_message";
			this.statusBarPanel_message.Width = 609;
			// 
			// groupBox_tools_checkLogin
			// 
			this.groupBox_tools_checkLogin.Controls.Add(this.textBox_user);
			this.groupBox_tools_checkLogin.Controls.Add(this.button_login);
			this.groupBox_tools_checkLogin.Controls.Add(this.textBox_pass);
			this.groupBox_tools_checkLogin.Controls.Add(this.label_user);
			this.groupBox_tools_checkLogin.Controls.Add(this.label_pass);
			this.groupBox_tools_checkLogin.Location = new System.Drawing.Point(2, 212);
			this.groupBox_tools_checkLogin.Name = "groupBox_tools_checkLogin";
			this.groupBox_tools_checkLogin.Size = new System.Drawing.Size(200, 92);
			this.groupBox_tools_checkLogin.TabIndex = 10;
			this.groupBox_tools_checkLogin.TabStop = false;
			this.groupBox_tools_checkLogin.Text = "Tools.CheckLogin";
			// 
			// groupBox__tools_log
			// 
			this.groupBox__tools_log.Controls.Add(this.comboBox_logType);
			this.groupBox__tools_log.Controls.Add(this.textBox_logMessage);
			this.groupBox__tools_log.Controls.Add(this.textBox_logSource);
			this.groupBox__tools_log.Controls.Add(this.button_log);
			this.groupBox__tools_log.Location = new System.Drawing.Point(208, 207);
			this.groupBox__tools_log.Name = "groupBox__tools_log";
			this.groupBox__tools_log.Size = new System.Drawing.Size(200, 68);
			this.groupBox__tools_log.TabIndex = 11;
			this.groupBox__tools_log.TabStop = false;
			this.groupBox__tools_log.Text = "Tools.Log";
			// 
			// groupBox_controls_resizeComboBox
			// 
			this.groupBox_controls_resizeComboBox.Controls.Add(this.comboBox_resize);
			this.groupBox_controls_resizeComboBox.Controls.Add(this.button_resizeCombobox);
			this.groupBox_controls_resizeComboBox.Location = new System.Drawing.Point(208, 79);
			this.groupBox_controls_resizeComboBox.Name = "groupBox_controls_resizeComboBox";
			this.groupBox_controls_resizeComboBox.Size = new System.Drawing.Size(200, 65);
			this.groupBox_controls_resizeComboBox.TabIndex = 12;
			this.groupBox_controls_resizeComboBox.TabStop = false;
			this.groupBox_controls_resizeComboBox.Text = "Controls.ResizeComboBox";
			// 
			// groupBox_tools_sqlFilter
			// 
			this.groupBox_tools_sqlFilter.Controls.Add(this.button_sqlFilter);
			this.groupBox_tools_sqlFilter.Controls.Add(this.textBox_sqlFilter);
			this.groupBox_tools_sqlFilter.Location = new System.Drawing.Point(2, 310);
			this.groupBox_tools_sqlFilter.Name = "groupBox_tools_sqlFilter";
			this.groupBox_tools_sqlFilter.Size = new System.Drawing.Size(200, 46);
			this.groupBox_tools_sqlFilter.TabIndex = 13;
			this.groupBox_tools_sqlFilter.TabStop = false;
			this.groupBox_tools_sqlFilter.Text = "Tools.SqlFilter";
			// 
			// groupBox_generators_generatePassword
			// 
			this.groupBox_generators_generatePassword.Controls.Add(this.numeric_passwordLength);
			this.groupBox_generators_generatePassword.Controls.Add(this.textBox_generatePassword);
			this.groupBox_generators_generatePassword.Controls.Add(this.button_generatePassword);
			this.groupBox_generators_generatePassword.Location = new System.Drawing.Point(208, 2);
			this.groupBox_generators_generatePassword.Name = "groupBox_generators_generatePassword";
			this.groupBox_generators_generatePassword.Size = new System.Drawing.Size(200, 71);
			this.groupBox_generators_generatePassword.TabIndex = 14;
			this.groupBox_generators_generatePassword.TabStop = false;
			this.groupBox_generators_generatePassword.Text = "Generators.GeneratePassword";
			// 
			// groupBox_controls_onlyNumbersTextBox
			// 
			this.groupBox_controls_onlyNumbersTextBox.Controls.Add(this.checkBox_onlyNumbers);
			this.groupBox_controls_onlyNumbersTextBox.Controls.Add(this.textBox_onlyNumbers);
			this.groupBox_controls_onlyNumbersTextBox.Location = new System.Drawing.Point(208, 281);
			this.groupBox_controls_onlyNumbersTextBox.Name = "groupBox_controls_onlyNumbersTextBox";
			this.groupBox_controls_onlyNumbersTextBox.Size = new System.Drawing.Size(200, 75);
			this.groupBox_controls_onlyNumbersTextBox.TabIndex = 15;
			this.groupBox_controls_onlyNumbersTextBox.TabStop = false;
			this.groupBox_controls_onlyNumbersTextBox.Text = "Controls.OnlyNumbersTextBox";
			// 
			// textBox_onlyNumbers
			// 
			this.textBox_onlyNumbers.Location = new System.Drawing.Point(8, 19);
			this.textBox_onlyNumbers.Name = "textBox_onlyNumbers";
			this.textBox_onlyNumbers.Size = new System.Drawing.Size(186, 20);
			this.textBox_onlyNumbers.TabIndex = 0;
			// 
			// checkBox_onlyNumbers
			// 
			this.checkBox_onlyNumbers.AutoSize = true;
			this.checkBox_onlyNumbers.Location = new System.Drawing.Point(8, 45);
			this.checkBox_onlyNumbers.Name = "checkBox_onlyNumbers";
			this.checkBox_onlyNumbers.Size = new System.Drawing.Size(126, 17);
			this.checkBox_onlyNumbers.TabIndex = 1;
			this.checkBox_onlyNumbers.Text = "Only accept numbers";
			this.checkBox_onlyNumbers.UseVisualStyleBackColor = true;
			this.checkBox_onlyNumbers.CheckedChanged += new System.EventHandler(this.checkBox_onlyNumbers_CheckedChanged);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 379);
			this.Controls.Add(this.groupBox_controls_onlyNumbersTextBox);
			this.Controls.Add(this.groupBox_generators_generatePassword);
			this.Controls.Add(this.groupBox_tools_sqlFilter);
			this.Controls.Add(this.groupBox_controls_resizeComboBox);
			this.Controls.Add(this.groupBox__tools_log);
			this.Controls.Add(this.groupBox_tools_checkLogin);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.groupBox_toolHash);
			this.Controls.Add(this.groupBox_tools_crash);
			this.Controls.Add(this.groupBox_database);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.Text = "Testing Grounds";
			this.Load += new System.EventHandler(this.Main_Load);
			this.groupBox_database.ResumeLayout(false);
			this.groupBox_tools_crash.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numeric_passwordLength)).EndInit();
			this.groupBox_toolHash.ResumeLayout(false);
			this.groupBox_toolHash.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel_label)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel_message)).EndInit();
			this.groupBox_tools_checkLogin.ResumeLayout(false);
			this.groupBox_tools_checkLogin.PerformLayout();
			this.groupBox__tools_log.ResumeLayout(false);
			this.groupBox__tools_log.PerformLayout();
			this.groupBox_controls_resizeComboBox.ResumeLayout(false);
			this.groupBox_tools_sqlFilter.ResumeLayout(false);
			this.groupBox_tools_sqlFilter.PerformLayout();
			this.groupBox_generators_generatePassword.ResumeLayout(false);
			this.groupBox_generators_generatePassword.PerformLayout();
			this.groupBox_controls_onlyNumbersTextBox.ResumeLayout(false);
			this.groupBox_controls_onlyNumbersTextBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_criarTabela;
		private System.Windows.Forms.Button button_apagarTabela;
		private System.Windows.Forms.Button button_insert;
		private System.Windows.Forms.Button button_criarBd;
		private System.Windows.Forms.Button button_crash;
		private System.Windows.Forms.Button button_login;
		private System.Windows.Forms.GroupBox groupBox_database;
		private System.Windows.Forms.GroupBox groupBox_tools_crash;
		private System.Windows.Forms.Label label_pass;
		private System.Windows.Forms.Label label_user;
		private System.Windows.Forms.TextBox textBox_pass;
		private System.Windows.Forms.TextBox textBox_user;
		private System.Windows.Forms.Button button_select;
		private System.Windows.Forms.TextBox textBox_generatePassword;
		private System.Windows.Forms.NumericUpDown numeric_passwordLength;
		private System.Windows.Forms.ComboBox comboBox_resize;
		private System.Windows.Forms.Button button_resizeCombobox;
		private System.Windows.Forms.ComboBox comboBox_databaseType;
		private System.Windows.Forms.Button button_sqlFilter;
		private System.Windows.Forms.TextBox textBox_sqlFilter;
		private System.Windows.Forms.Button button_delete;
		private System.Windows.Forms.Button button_generatePassword;
		private System.Windows.Forms.TextBox textBox_logMessage;
		private System.Windows.Forms.Button button_log;
		private System.Windows.Forms.TextBox textBox_logSource;
		private System.Windows.Forms.ComboBox comboBox_logType;
		private System.Windows.Forms.GroupBox groupBox_toolHash;
		private System.Windows.Forms.TextBox textBox_hash;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel_label;
		private System.Windows.Forms.StatusBarPanel statusBarPanel_message;
		private System.Windows.Forms.GroupBox groupBox_tools_checkLogin;
		private System.Windows.Forms.GroupBox groupBox__tools_log;
		private System.Windows.Forms.GroupBox groupBox_controls_resizeComboBox;
		private System.Windows.Forms.GroupBox groupBox_tools_sqlFilter;
		private System.Windows.Forms.GroupBox groupBox_generators_generatePassword;
		private System.Windows.Forms.GroupBox groupBox_controls_onlyNumbersTextBox;
		private System.Windows.Forms.CheckBox checkBox_onlyNumbers;
		private System.Windows.Forms.TextBox textBox_onlyNumbers;
	}
}

