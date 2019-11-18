namespace TestingGrounds
{
	partial class Keys
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
			this.label_riotapi = new System.Windows.Forms.Label();
			this.textBox_riotapi = new System.Windows.Forms.TextBox();
			this.button_ok = new System.Windows.Forms.Button();
			this.comboBox_lolRegion = new System.Windows.Forms.ComboBox();
			this.label_lolRegion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_riotapi
			// 
			this.label_riotapi.AutoSize = true;
			this.label_riotapi.Location = new System.Drawing.Point(49, 26);
			this.label_riotapi.Name = "label_riotapi";
			this.label_riotapi.Size = new System.Drawing.Size(46, 13);
			this.label_riotapi.TabIndex = 0;
			this.label_riotapi.Text = "RiotAPI:";
			// 
			// textBox_riotapi
			// 
			this.textBox_riotapi.Location = new System.Drawing.Point(101, 23);
			this.textBox_riotapi.Name = "textBox_riotapi";
			this.textBox_riotapi.Size = new System.Drawing.Size(442, 20);
			this.textBox_riotapi.TabIndex = 1;
			// 
			// button_ok
			// 
			this.button_ok.Location = new System.Drawing.Point(468, 130);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(75, 23);
			this.button_ok.TabIndex = 2;
			this.button_ok.Text = "OK";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// comboBox_lolRegion
			// 
			this.comboBox_lolRegion.FormattingEnabled = true;
			this.comboBox_lolRegion.Location = new System.Drawing.Point(101, 49);
			this.comboBox_lolRegion.Name = "comboBox_lolRegion";
			this.comboBox_lolRegion.Size = new System.Drawing.Size(442, 21);
			this.comboBox_lolRegion.TabIndex = 3;
			// 
			// label_lolRegion
			// 
			this.label_lolRegion.AutoSize = true;
			this.label_lolRegion.Location = new System.Drawing.Point(30, 52);
			this.label_lolRegion.Name = "label_lolRegion";
			this.label_lolRegion.Size = new System.Drawing.Size(65, 13);
			this.label_lolRegion.TabIndex = 4;
			this.label_lolRegion.Text = "LoL Region:";
			// 
			// Keys
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 176);
			this.Controls.Add(this.label_lolRegion);
			this.Controls.Add(this.comboBox_lolRegion);
			this.Controls.Add(this.button_ok);
			this.Controls.Add(this.textBox_riotapi);
			this.Controls.Add(this.label_riotapi);
			this.Name = "Keys";
			this.Text = "Keys";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Keys_FormClosing);
			this.Load += new System.EventHandler(this.Keys_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_riotapi;
		private System.Windows.Forms.TextBox textBox_riotapi;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.ComboBox comboBox_lolRegion;
		private System.Windows.Forms.Label label_lolRegion;
	}
}