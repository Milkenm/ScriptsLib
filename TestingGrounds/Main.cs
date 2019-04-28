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
				SlDatabase.Fields _Field_ID = new SlDatabase.Fields();
				_Field_ID.Name = "ID";
				_Field_ID.DataType = SlDatabase.SqlDataTypes.number;
				SlDatabase.Fields _Field_Name = new SlDatabase.Fields();
				_Field_Name.Name = "Name";
				_Field_Name.DataType = SlDatabase.SqlDataTypes.text;

				List<SlDatabase.Fields> _FieldsList = new List<SlDatabase.Fields>();
				_FieldsList.Add(_Field_ID);
				_FieldsList.Add(_Field_Name);

				string _TableName = "TestTable";
				_Database.CreateTable(_FieldsList, _TableName).GetAwaiter();
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
	}
}
