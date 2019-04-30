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
			this.button_criarTabela = new System.Windows.Forms.Button();
			this.button_apagarTabela = new System.Windows.Forms.Button();
			this.button_insert = new System.Windows.Forms.Button();
			this.button_criarBd = new System.Windows.Forms.Button();
			this.button_crash = new System.Windows.Forms.Button();
			this.button_login = new System.Windows.Forms.Button();
			this.groupBox_database = new System.Windows.Forms.GroupBox();
			this.button_select = new System.Windows.Forms.Button();
			this.groupBox_tools = new System.Windows.Forms.GroupBox();
			this.label_pass = new System.Windows.Forms.Label();
			this.label_user = new System.Windows.Forms.Label();
			this.textBox_pass = new System.Windows.Forms.TextBox();
			this.textBox_user = new System.Windows.Forms.TextBox();
			this.groupBox_database.SuspendLayout();
			this.groupBox_tools.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_criarTabela
			// 
			this.button_criarTabela.Location = new System.Drawing.Point(97, 19);
			this.button_criarTabela.Name = "button_criarTabela";
			this.button_criarTabela.Size = new System.Drawing.Size(85, 23);
			this.button_criarTabela.TabIndex = 0;
			this.button_criarTabela.Text = "Criar Tabela";
			this.button_criarTabela.UseVisualStyleBackColor = true;
			this.button_criarTabela.Click += new System.EventHandler(this.button_criarTabela_Click);
			// 
			// button_apagarTabela
			// 
			this.button_apagarTabela.Location = new System.Drawing.Point(97, 48);
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
			this.button_crash.Size = new System.Drawing.Size(85, 23);
			this.button_crash.TabIndex = 4;
			this.button_crash.Text = "Crash";
			this.button_crash.UseVisualStyleBackColor = true;
			this.button_crash.Click += new System.EventHandler(this.button_crash_Click);
			// 
			// button_login
			// 
			this.button_login.Location = new System.Drawing.Point(107, 243);
			this.button_login.Name = "button_login";
			this.button_login.Size = new System.Drawing.Size(75, 23);
			this.button_login.TabIndex = 5;
			this.button_login.Text = "Login";
			this.button_login.UseVisualStyleBackColor = true;
			this.button_login.Click += new System.EventHandler(this.button_login_Click);
			// 
			// groupBox_database
			// 
			this.groupBox_database.Controls.Add(this.button_select);
			this.groupBox_database.Controls.Add(this.button_criarTabela);
			this.groupBox_database.Controls.Add(this.button_insert);
			this.groupBox_database.Controls.Add(this.button_apagarTabela);
			this.groupBox_database.Controls.Add(this.button_criarBd);
			this.groupBox_database.Location = new System.Drawing.Point(2, 2);
			this.groupBox_database.Name = "groupBox_database";
			this.groupBox_database.Size = new System.Drawing.Size(188, 272);
			this.groupBox_database.TabIndex = 6;
			this.groupBox_database.TabStop = false;
			this.groupBox_database.Text = "Database";
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
			// groupBox_tools
			// 
			this.groupBox_tools.Controls.Add(this.label_pass);
			this.groupBox_tools.Controls.Add(this.label_user);
			this.groupBox_tools.Controls.Add(this.textBox_pass);
			this.groupBox_tools.Controls.Add(this.textBox_user);
			this.groupBox_tools.Controls.Add(this.button_login);
			this.groupBox_tools.Controls.Add(this.button_crash);
			this.groupBox_tools.Location = new System.Drawing.Point(196, 2);
			this.groupBox_tools.Name = "groupBox_tools";
			this.groupBox_tools.Size = new System.Drawing.Size(188, 272);
			this.groupBox_tools.TabIndex = 7;
			this.groupBox_tools.TabStop = false;
			this.groupBox_tools.Text = "Tools";
			// 
			// label_pass
			// 
			this.label_pass.AutoSize = true;
			this.label_pass.Location = new System.Drawing.Point(7, 220);
			this.label_pass.Name = "label_pass";
			this.label_pass.Size = new System.Drawing.Size(33, 13);
			this.label_pass.TabIndex = 9;
			this.label_pass.Text = "Pass:";
			// 
			// label_user
			// 
			this.label_user.AutoSize = true;
			this.label_user.Location = new System.Drawing.Point(8, 194);
			this.label_user.Name = "label_user";
			this.label_user.Size = new System.Drawing.Size(32, 13);
			this.label_user.TabIndex = 8;
			this.label_user.Text = "User:";
			// 
			// textBox_pass
			// 
			this.textBox_pass.Location = new System.Drawing.Point(46, 217);
			this.textBox_pass.Name = "textBox_pass";
			this.textBox_pass.Size = new System.Drawing.Size(136, 20);
			this.textBox_pass.TabIndex = 7;
			// 
			// textBox_user
			// 
			this.textBox_user.Location = new System.Drawing.Point(46, 191);
			this.textBox_user.Name = "textBox_user";
			this.textBox_user.Size = new System.Drawing.Size(136, 20);
			this.textBox_user.TabIndex = 6;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 275);
			this.Controls.Add(this.groupBox_tools);
			this.Controls.Add(this.groupBox_database);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Main";
			this.Text = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.groupBox_database.ResumeLayout(false);
			this.groupBox_tools.ResumeLayout(false);
			this.groupBox_tools.PerformLayout();
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
		private System.Windows.Forms.GroupBox groupBox_tools;
		private System.Windows.Forms.Label label_pass;
		private System.Windows.Forms.Label label_user;
		private System.Windows.Forms.TextBox textBox_pass;
		private System.Windows.Forms.TextBox textBox_user;
		private System.Windows.Forms.Button button_select;
	}
}

