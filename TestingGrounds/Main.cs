#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ScriptsLib.Database;
#endregion Usings



namespace TestingGrounds
{
	public partial class Main : Form
	{
		SlDatabase _Database = new SlDatabase();

		public Main()
		{
			InitializeComponent();
			SlDatabase._DatabasePath = @"C:\Milkenm\Data\Tests.mdf";
		}

		private void button_criarTabela_Click(object sender, EventArgs e)
		{
			try
			{
				List<SlDatabase.TableFields> _Fields = new List<SlDatabase.TableFields>();
				SlDatabase.TableFields _Field = new SlDatabase.TableFields();


				_Field.Name = "ID";
				_Field.DataType = SlDatabase.SqlDataTypes.number;
				_Fields.Add(_Field);

				_Field.Name = "Name";
				_Field.DataType = SlDatabase.SqlDataTypes.text;
				_Fields.Add(_Field);



				string _TableName = "TestTable";
				_Database.CreateTable(_TableName, _Fields).GetAwaiter();
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
				_Database.DeleteTable("TestTable").GetAwaiter();
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
				_Database.InsertInto("TestTable", "ID, Name", "1, 'Some Text!'").GetAwaiter();
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
				string _Path = @"C:\Milkenm\Data\Tests.mdf";
				_Database.CreateDatabase(_Path).GetAwaiter();
			}
			catch (Exception _Exception)
			{
				MessageBox.Show(_Exception.Message);
			}
		}

		private void button_crash_Click(object sender, EventArgs e)
		{
			ScriptsLib.Crash.Crash crash = new ScriptsLib.Crash.Crash();
			crash.StackOverflow().GetAwaiter();
		}
	}
}
