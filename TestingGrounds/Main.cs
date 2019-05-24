#region Usings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

using ScriptsLib.Databases;
using ScriptsLib.Tools;
#endregion Usings



namespace TestingGrounds
{
	public partial class Main : Form
	{
		#region Refs
		SqlServer_Database _SqlDatabase = new SqlServer_Database();
		Access_Database _AccessDatabase = new Access_Database();
		MySql_Database _MySqlDatabase = new MySql_Database();

		Tools _Tools = new Tools();
		#endregion Refs

		#region Form
		public Main()
		{
			InitializeComponent();
		}



		private void Main_Load(object sender, EventArgs e)
		{
			if (Debugger.IsAttached == true)
			{
				this.Text = $"{this.Text} - DE3UG";
			}

			ScriptsLib.Dev.Debug._Debug = true;




			SqlServer_Database._DatabasePath = @"C:\Milkenm\Data\Tests.mdf";

			Access_Database._DatabasePath = @"C:\Milkenm\Data\TestsAccess.mdb";
			
			MySql_Database._Server = "127.0.0.1";
			MySql_Database._Port = 3306;
			MySql_Database._Database = "test";
			MySql_Database._User = "root";
			MySql_Database._Password = "";
			MySql_Database._SslMode = "none";



			#region Perform Actions
			textBox_user.Text = "User1";
			textBox_pass.Text = "Pass1";

			textBox_generatePassword.Text = _Tools.PasswordGenerator((int)numeric_passwordLength.Value);

			textBox_sqlFilter.Text = "ABC;DEF;GHI'JKL'MNO";

			comboBox_databaseType.SelectedIndex = 2;
			#endregion Perform Actions
		}
		#endregion Form

		#region Stuff
		private void timer_debug_Tick(object sender, EventArgs e)
		{
			button_resizeCombobox.Text = $"Resize {button_resizeCombobox.Height} | {comboBox_resize.Height}";
		}

		private void Ex(Exception _Exception)
		{
			MessageBox.Show(_Exception.Message, _Exception.Source);
		}

		private void Libs()
		{
			//File.WriteAllBytes()
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


					_SqlDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				else if (comboBox_databaseType.SelectedIndex == 1)
				{
					List<Access_Database.TableFields> _Fields = new List<Access_Database.TableFields>();
					Access_Database.TableFields _Field = new Access_Database.TableFields();


					_Field.Name = "ID";
					_Field.DataType = Access_Database.AccessDataTypes.Key;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = Access_Database.AccessDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = Access_Database.AccessDataTypes.Text;
					_Fields.Add(_Field);


					_AccessDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				else if (comboBox_databaseType.SelectedIndex == 2)
				{
					List<MySql_Database.TableFields> _Fields = new List<MySql_Database.TableFields>();
					MySql_Database.TableFields _Field = new MySql_Database.TableFields();


					_Field.Name = "ID";
					_Field.DataType = MySql_Database.MySqlDataTypes.Key;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = MySql_Database.MySqlDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = MySql_Database.MySqlDataTypes.Text;
					_Fields.Add(_Field);


					_MySqlDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}

		private void button_apagarTabela_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0)
				{
					_SqlDatabase.DeleteTable("Users").GetAwaiter();
				}
				else
				{
					_AccessDatabase.DeleteTable("Users").GetAwaiter();
				}
				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}

		private void button_insert_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0)
				{
					_SqlDatabase.InsertInto("Users", "ID, Name, Password", "1, 'User1', 'Pass1'").GetAwaiter();
				}
				else
				{
					_AccessDatabase.InsertInto("[Users]", "[Name], [Password]", "'User1', 'Pass1'").GetAwaiter();
				}
				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}

		private void button_criarBd_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0)
				{
					_SqlDatabase.CreateDatabase(@"C:\Milkenm\Data\Tests.mdf").GetAwaiter();
				}
				else
				{
					MessageBox.Show("There is no 'Create Database' yet.");
					return;
				}
				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}

		private void button_select_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0)
				{
					foreach (var _Loop in _SqlDatabase.Select("Users"))
					{
						MessageBox.Show($"{_Loop}", "Selected values");
					}
				}
				else
				{
					foreach (var _Loop in _AccessDatabase.Select("Users"))
					{
						MessageBox.Show($"{_Loop}", "Selected values");
					}
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
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
			bool _Success;
			if (comboBox_databaseType.SelectedIndex == 0)
			{
				 _Success = _Tools.CheckLogin("Users", textBox_user.Text, textBox_pass.Text, "Name", "Password", Tools.DatabaseType.SqlServer);
			}
			else
			{
				_Success = _Tools.CheckLogin("Users", textBox_user.Text, textBox_pass.Text, "Name", "Password", Tools.DatabaseType.Access);
			}

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

		private void button_sqlFilter_Click(object sender, EventArgs e)
		{
			textBox_sqlFilter.Text = _Tools.SqlFilter(textBox_sqlFilter.Text);
		}
		#endregion Tools
	}
}
