#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ScriptsLib.Databases;
using ScriptsLib.Tools;
#endregion Usings



namespace TestingGrounds
{

	public partial class Main : Form
	{

		#region Refs
		SqlServer_Database _Database = new SqlServer_Database();
		Tools _Tools = new Tools();
		#endregion Refs

		#region Form
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			SqlServer_Database._DatabasePath = @"C:\Milkenm\Data\Tests.mdf";



			#region Perform Actions
			textBox_user.Text = "User1";
			textBox_pass.Text = "Pass1";

			textBox_generatePassword.Text = _Tools.PasswordGenerator((int)numeric_passwordLength.Value);
			#endregion Perform Actions
		}
		#endregion Form

		#region Stuff
		private void timer_debug_Tick(object sender, EventArgs e)
		{
			button_resizeCombobox.Text = $"Resize {button_resizeCombobox.Height} | {comboBox_resize.Height}";
		}
		#endregion Stuff










		#region Database
		private void button_criarTabela_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0)
				{
					List<SqlServer_Database.TableFields> _Fields = new List<SqlServer_Database.TableFields>();
					SqlServer_Database.TableFields _Field = new SqlServer_Database.TableFields();


					_Field.Name = "ID";
					_Field.DataType = SqlServer_Database.SqlDataTypes.Number;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = SqlServer_Database.SqlDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = SqlServer_Database.SqlDataTypes.Text;
					_Fields.Add(_Field);


					_Database.CreateTable("Users", _Fields).GetAwaiter();



					MessageBox.Show("Done.");
				}
				else
				{
					List<Access_Database.TableFields> _Fields = new List<Access_Database.TableFields>();
					Access_Database.TableFields _Field = new Access_Database.TableFields();


					_Field.Name = "ID";
					_Field.DataType = Access_Database.SqlDataTypes.Number;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = Access_Database.SqlDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = Access_Database.SqlDataTypes.Text;
					_Fields.Add(_Field);


					_Database.CreateTable("Users", _Fields).GetAwaiter();



					MessageBox.Show("Done.");
				}
			}
			catch (Exception _Exception)
			{
				MessageBox.Show(_Exception.Message);
			}
		}

		private void button_apagarTabela_Click(object sender, EventArgs e)
		{
			try
			{
				_Database.DeleteTable("Users").GetAwaiter();



				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				MessageBox.Show(_Exception.Message);
			}
		}

		private void button_insert_Click(object sender, EventArgs e)
		{
			try
			{
				_Database.InsertInto("Users", "ID, Name, Password", "1, 'User1', 'Pass1'").GetAwaiter();



				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				MessageBox.Show(_Exception.Message);
			}
		}

		private void button_criarBd_Click(object sender, EventArgs e)
		{
			try
			{
				_Database.CreateDatabase(@"C:\Milkenm\Data\Tests.mdf").GetAwaiter();



				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				MessageBox.Show(_Exception.Message);
			}
		}

		private void button_select_Click(object sender, EventArgs e)
		{
			foreach (var _Loop in _Database.Select("Users"))
			{
				MessageBox.Show($"{_Loop}", "Selected values");
			}
		}
		#endregion Database



		#region Tools
		private void button_crash_Click(object sender, EventArgs e)
		{
			_Tools.Crash().GetAwaiter();
		}

		private void button_login_Click(object sender, EventArgs e)
		{
			bool _Success = _Tools.CheckLogin("Users", textBox_user.Text, textBox_pass.Text, "Name", "Password");

			if (_Success == true)
			{
				MessageBox.Show("Logged in.");
			}
			else
			{
				MessageBox.Show("Invalid login credentials.");
			}
		}

		private void button_generatePassword_Click(object sender, EventArgs e)
		{
			textBox_generatePassword.Text = _Tools.PasswordGenerator((int)numeric_passwordLength.Value);
		}

		private void button_resizeCombobox_Click(object sender, EventArgs e)
		{
			if (comboBox_resize.Height == 37)
			{
				_Tools.ResizeCombobox(comboBox_resize, 21);
			}
			else
			{
				_Tools.ResizeCombobox(comboBox_resize, 37);
			}
		}
		#endregion Tools
	}
}
