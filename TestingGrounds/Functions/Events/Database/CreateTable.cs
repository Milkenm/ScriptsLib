﻿#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ScriptsLib.Databases;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_DatabaseCreateTable()
		{
			try
			{
				if (MainForm.comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server Database
				{
					List<SqlServerDatabase.SqlServerTableFields> _Fields = new List<SqlServerDatabase.SqlServerTableFields>();
					SqlServerDatabase.SqlServerTableFields _Field = new SqlServerDatabase.SqlServerTableFields();


					_Field.Name = "ID";
					_Field.DataType = SqlServerDatabase.SqlServerDataTypes.Number;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = SqlServerDatabase.SqlServerDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = SqlServerDatabase.SqlServerDataTypes.Text;
					_Fields.Add(_Field);


					SqlServerDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				else if (MainForm.comboBox_tg_databaseType.SelectedIndex == 1) // Access Database
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


					AccessDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				else if (MainForm.comboBox_tg_databaseType.SelectedIndex == 2) // MySql Server
				{
					List<MySqlDatabase.MySqlTableFields> _Fields = new List<MySqlDatabase.MySqlTableFields>();
					MySqlDatabase.MySqlTableFields _Field = new MySqlDatabase.MySqlTableFields();


					_Field.Name = "ID";
					_Field.DataType = MySqlDatabase.MySqlDataTypes.Key;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = MySqlDatabase.MySqlDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = MySqlDatabase.MySqlDataTypes.Text;
					_Fields.Add(_Field);


					MySqlDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}
