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
			this.SuspendLayout();
			// 
			// button_criarTabela
			// 
			this.button_criarTabela.Location = new System.Drawing.Point(0, 0);
			this.button_criarTabela.Name = "button_criarTabela";
			this.button_criarTabela.Size = new System.Drawing.Size(85, 23);
			this.button_criarTabela.TabIndex = 0;
			this.button_criarTabela.Text = "Criar Tabela";
			this.button_criarTabela.UseVisualStyleBackColor = true;
			this.button_criarTabela.Click += new System.EventHandler(this.button_criarTabela_Click);
			// 
			// button_apagarTabela
			// 
			this.button_apagarTabela.Location = new System.Drawing.Point(0, 22);
			this.button_apagarTabela.Name = "button_apagarTabela";
			this.button_apagarTabela.Size = new System.Drawing.Size(85, 23);
			this.button_apagarTabela.TabIndex = 1;
			this.button_apagarTabela.Text = "Apagar Tabela";
			this.button_apagarTabela.UseVisualStyleBackColor = true;
			this.button_apagarTabela.Click += new System.EventHandler(this.button_apagarTabela_Click);
			// 
			// button_insert
			// 
			this.button_insert.Location = new System.Drawing.Point(84, 0);
			this.button_insert.Name = "button_insert";
			this.button_insert.Size = new System.Drawing.Size(85, 23);
			this.button_insert.TabIndex = 2;
			this.button_insert.Text = "Insert";
			this.button_insert.UseVisualStyleBackColor = true;
			this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
			// 
			// button_criarBd
			// 
			this.button_criarBd.Location = new System.Drawing.Point(84, 22);
			this.button_criarBd.Name = "button_criarBd";
			this.button_criarBd.Size = new System.Drawing.Size(85, 23);
			this.button_criarBd.TabIndex = 3;
			this.button_criarBd.Text = "Criar BD";
			this.button_criarBd.UseVisualStyleBackColor = true;
			this.button_criarBd.Click += new System.EventHandler(this.button_criarBd_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(169, 45);
			this.Controls.Add(this.button_criarBd);
			this.Controls.Add(this.button_insert);
			this.Controls.Add(this.button_apagarTabela);
			this.Controls.Add(this.button_criarTabela);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Main";
			this.Text = "Main";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_criarTabela;
		private System.Windows.Forms.Button button_apagarTabela;
		private System.Windows.Forms.Button button_insert;
		private System.Windows.Forms.Button button_criarBd;
	}
}

