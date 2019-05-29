#region Usings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

using ScriptsLib.Controls;
using ScriptsLib.Databases;
using ScriptsLib.Generators;
using ScriptsLib.Tools;
#endregion Usings



namespace TestingGrounds
{
	public partial class Main : Form
	{
		#region Refs
		// # ================================================================================================ #
		SqlServerDatabase _SqlDatabase = new SqlServerDatabase();
		AccessDatabase _AccessDatabase = new AccessDatabase();
		MySqlDatabase _MySqlDatabase = new MySqlDatabase();



		Tools _Tools = new Tools();
		Generators _Generators = new Generators();

		Controls.ComboBox _ComboBox = new Controls.ComboBox();
		Controls.TextBox _TextBox = new Controls.TextBox();
		Tools.DatabaseTools _DatabaseTools = new Tools.DatabaseTools();
		// # ================================================================================================ #
		#endregion Refs

		#region Form
		// # ================================================================================================ #
		public Main()
		{
			InitializeComponent();
		}
		// # ================================================================================================ #
		private void Main_Load(object sender, EventArgs e)
		{
			if (Debugger.IsAttached == true)
			{
				this.Text = $"{this.Text} - DE3UG";
			}

			ScriptsLib.Dev.Debug._Debug = true;
			ScriptsLib.Dev.Debug._ErrorsOnly = true;




			SqlServerDatabase._DatabasePath = @"C:\Milkenm\Data\Tests.mdf";

			AccessDatabase._DatabasePath = @"C:\Milkenm\Data\TestsAccess.mdb";

			MySqlDatabase._Server = "127.0.0.1";
			MySqlDatabase._Port = 3306;
			MySqlDatabase._Database = "test";
			MySqlDatabase._User = "root";
			MySqlDatabase._Password = "";
			MySqlDatabase._SslMode = "none";



			#region Perform Actions
			textBox_user.Text = "User1";
			textBox_pass.Text = "Pass1";

			textBox_generatePassword.Text = _Generators.GeneratePassword((int)numeric_passwordLength.Value);

			textBox_sqlFilter.Text = "ABC;DEF;GHI'JKL'MNO";

			comboBox_databaseType.SelectedIndex = 2;

			comboBox_logType.SelectedIndex = 0;
			_ComboBox.Resize(comboBox_logType, 20);

			button_resizeCombobox.Text = $"Resize {button_resizeCombobox.Height} | {comboBox_resize.Height}";

			textBox_table.Text = "Unique";
			textBox_column.Text = "Value";
			#endregion Perform Actions
		}
		// # ================================================================================================ #
		#endregion Form

		#region Stuff
		// # ================================================================================================ #
		private void Ex(Exception _Exception)
		{
			MessageBox.Show(_Exception.Message, _Exception.Source);
		}
		// # ================================================================================================ #
		#endregion Stuff










		#region Database
		// # ================================================================================================ #
		private void button_criarTabela_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0) // SQL Server
				{
					List<SqlServerDatabase.TableFields> _Fields = new List<SqlServerDatabase.TableFields>();
					SqlServerDatabase.TableFields _Field = new SqlServerDatabase.TableFields();


					_Field.Name = "ID";
					_Field.DataType = SqlServerDatabase.SqlDataTypes.Number;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = SqlServerDatabase.SqlDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = SqlServerDatabase.SqlDataTypes.Text;
					_Fields.Add(_Field);


					_SqlDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				else if (comboBox_databaseType.SelectedIndex == 1)
				{
					List<AccessDatabase.TableFields> _Fields = new List<AccessDatabase.TableFields>();
					AccessDatabase.TableFields _Field = new AccessDatabase.TableFields();


					_Field.Name = "ID";
					_Field.DataType = AccessDatabase.AccessDataTypes.Key;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = AccessDatabase.AccessDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = AccessDatabase.AccessDataTypes.Text;
					_Fields.Add(_Field);


					_AccessDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				else if (comboBox_databaseType.SelectedIndex == 2)
				{
					List<MySqlDatabase.TableFields> _Fields = new List<MySqlDatabase.TableFields>();
					MySqlDatabase.TableFields _Field = new MySqlDatabase.TableFields();


					_Field.Name = "ID";
					_Field.DataType = MySqlDatabase.MySqlDataTypes.Key;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = MySqlDatabase.MySqlDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = MySqlDatabase.MySqlDataTypes.Text;
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
		// # ================================================================================================ #
		private void button_apagarTabela_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0) // SQL Server
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
		// # ================================================================================================ #
		private void button_insert_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0) // SQL Server
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
		// # ================================================================================================ #
		private void button_criarBd_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0) // SQL Server
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
		// # ================================================================================================ #
		private void button_select_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0) // SQL Server
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
		// # ================================================================================================ #
		private void button_delete_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 0) // SQL Server
				{
					_SqlDatabase.Delete("Users", "ID = 1").GetAwaiter();
				}
				else // Access MDB
				{
					_AccessDatabase.Delete("Users", "ID = 1").GetAwaiter();
				}

				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Database



		#region Tools
		#region Tools.Crash
		// # ================================================================================================ #
		private void button_crash_Click(object sender, EventArgs e)
		{
			_Tools.Crash().GetAwaiter();
		}
		// # ================================================================================================ #
		#endregion Tools.Crash



		#region Tools.Log
		// # ================================================================================================ #
		private void button_log_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_logType.SelectedIndex == 0) // INFO
				{
					_Tools.Log(textBox_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", textBox_logSource.Text, Tools.LogType.Info).GetAwaiter();
				}
				else if (comboBox_logType.SelectedIndex == 1) // ERROR
				{
					_Tools.Log(textBox_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", textBox_logSource.Text, Tools.LogType.Error).GetAwaiter();
				}
				else if (comboBox_logType.SelectedIndex == 2) // WARNING
				{
					_Tools.Log(textBox_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", textBox_logSource.Text, Tools.LogType.Warning).GetAwaiter();
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Tools.Log



		#region Tools.Hash
		// # ================================================================================================ #
		private void button_hash_Click(object sender, EventArgs e)
		{
			MessageBox.Show(_Tools.Hash(textBox_hash.Text));
		}
		// # ================================================================================================ #
		private void textBox_hash_TextChanged(object sender, EventArgs e)
		{
			statusBarPanel_label.Text = "Hash:";
			statusBarPanel_message.Text = _Tools.Hash(textBox_hash.Text);
		}
		// # ================================================================================================ #
		#endregion Tools.Hash



		#region Tools.GetDate
		private void timer_date_Tick(object sender, EventArgs e)
		{
			label_date.Text = _Tools.GetDate();
		}
		#endregion Tools.GetDate
		#endregion Tools



		#region Tools.DatabaseTools
		#region Tools.DatabaseTools.CheckLogin
		// # ================================================================================================ #
		private void button_login_Click(object sender, EventArgs e)
		{
			try
			{
				bool _Success;
				if (comboBox_databaseType.SelectedIndex == 0) // SQL Server
				{
					_Success = _DatabaseTools.CheckLogin("Users", textBox_user.Text, textBox_pass.Text, "Name", "Password", Tools.DatabaseTools.DatabaseType.SqlServer);
				}
				else
				{
					_Success = _DatabaseTools.CheckLogin("Users", textBox_user.Text, textBox_pass.Text, "Name", "Password", Tools.DatabaseTools.DatabaseType.Access);
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
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Tools.DatabaseTools.CheckLogin



		#region Tools.DatabaseTools.SqlFilter
		// # ================================================================================================ #
		private void button_sqlFilter_Click(object sender, EventArgs e)
		{
			textBox_sqlFilter.Text = _DatabaseTools.FilterSql(textBox_sqlFilter.Text);
		}
		// # ================================================================================================ #
		#endregion Tools.DatabaseTools.SqlFilter



		#region Tools.DatabaseTools.SelectUnique
		// # ================================================================================================ #
		private void button_selectUnique_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_databaseType.SelectedIndex == 1)
				{
					List<string> _Select = _DatabaseTools.SelectUnique(textBox_table.Text, textBox_column.Text, Tools.DatabaseTools.DatabaseType.Access);

					string _String = null;
					foreach (string _Value in _Select)
					{
						if (!String.IsNullOrEmpty(_String))
						{
							_String = $"{_String}, {_Value}";
						}
						else
						{
							_String = _Value;
						}
					}

					MessageBox.Show(_String);
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Tools.DatabaseTools.SelectUnique
		#endregion Tools.DatabaseTools



		#region Generators
		#region Generators.GeneratePassword
		// # ================================================================================================ #
		private void button_generatePassword_Click(object sender, EventArgs e)
		{
			textBox_generatePassword.Text = _Generators.GeneratePassword((int)numeric_passwordLength.Value);
		}
		// # ================================================================================================ #
		#endregion Generators.GeneratePassword
		#endregion Generators



		#region Controls
		#region Controls.ComboBox.ResizeComboBox
		// # ================================================================================================ #
		private void button_resizeCombobox_Click(object sender, EventArgs e)
		{
			if (comboBox_resize.Height == 37)
			{
				_ComboBox.Resize(comboBox_resize, 21);
			}
			else
			{
				_ComboBox.Resize(comboBox_resize, 37);
			}

			button_resizeCombobox.Text = $"Resize {button_resizeCombobox.Height} | {comboBox_resize.Height}";
		}
		// # ================================================================================================ #
		#endregion Controls.ComboBox.ResizeComboBox



		#region Controls.ComboBox.OnlyNumbersTextBox
		// # ================================================================================================ #
		private void checkBox_onlyNumbers_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_onlyNumbers.Checked == true)
			{
				_TextBox.OnlyNumbers(textBox_onlyNumbers, false);
			}
			else
			{
				_TextBox.OnlyNumbers(textBox_onlyNumbers, false, false);
			}
		}
		// # ================================================================================================ #
		#endregion Controls.ComboBox.OnlyNumbersTextBox

		#endregion Controls
	}
}