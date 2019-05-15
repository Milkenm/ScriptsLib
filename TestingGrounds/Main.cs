﻿#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ScriptsLib.Database;
using ScriptsLib.Tools;
#endregion Usings



namespace TestingGrounds
{

	public partial class Main : Form
	{

		#region Refs
		SlDatabase _Database = new SlDatabase();
		Tools _Tools = new Tools();
		#endregion Refs

		#region Form
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			SlDatabase._DatabasePath = @"C:\Milkenm\Data\Tests.mdf";

			textBox_user.Text = "User1";
			textBox_pass.Text = "Pass1";
		}
		#endregion Form











		#region Database
		private void button_criarTabela_Click(object sender, EventArgs e)
		{
			try
			{
				List<SlDatabase.TableFields> _Fields = new List<SlDatabase.TableFields>();
				SlDatabase.TableFields _Field = new SlDatabase.TableFields();


				_Field.Name = "ID";
				_Field.DataType = SlDatabase.SqlDataTypes.Number;
				_Fields.Add(_Field);

				_Field.Name = "Name";
				_Field.DataType = SlDatabase.SqlDataTypes.Text;
				_Fields.Add(_Field);

				_Field.Name = "Password";
				_Field.DataType = SlDatabase.SqlDataTypes.Text;
				_Fields.Add(_Field);


				_Database.CreateTable("Users", _Fields, "ID").GetAwaiter();



				MessageBox.Show("Done.");
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
				_Database.InsertInto("Users", "Name, Password", "'User1', 'Pass1'").GetAwaiter();



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
			try
			{
				foreach (var _Loop in _Database.Select("Users"))
				{
					MessageBox.Show($"{_Loop}", "Selected values");
				}
			}
			catch (Exception _Exception)
			{
				MessageBox.Show(_Exception.Message);
			}
		}
		
		private void button_update_Click(object sender, EventArgs e)
		{
			try
			{
				_Database.Update("Users", "Name = 'UserUpdate'", "Name = 'User1'").GetAwaiter();
				MessageBox.Show("Updated.");
			}
			catch (Exception _Exception)
			{
				MessageBox.Show(_Exception.Message);
			}
		}

		private void button_orderby_Click(object sender, EventArgs e)
		{
			try
			{
				_Database.OrderBy("Users", "Name", SlDatabase.SortType.Ascending).GetAwaiter();
				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				MessageBox.Show(_Exception.Message);
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
			try
			{
				Tools tools = new Tools();
				bool _Success = tools.CheckLogin("Users", textBox_user.Text, textBox_pass.Text, "Name", "Password");

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
				MessageBox.Show(_Exception.Message);
			}
		}
		#endregion Tools
	}
}
