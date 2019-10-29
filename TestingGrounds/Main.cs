#region Usings
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using static TestingGrounds.Events;
using static TestingGrounds.Functions;
using static TestingGrounds.Values;
using static TestingGrounds.Testing;
#endregion Usings



namespace TestingGrounds
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			_MainForm = this;
			MainInitEvents();
		}


		private void button_tg_test_Click(object sender, EventArgs e)
		{
			try
			{
				switch (numeric_tg_testingIndex.Value)
				{
					case 1:
						Testing1(); break;
					case 2:
						Testing2(); break;
					case 3:
						Testing3(); break;
					case 4:
						Testing4(); break;
					case 5:
						Testing5(); break;
					case 6:
						Testing6(); break;
					case 7:
						Testing7(); break;
					case 8:
						Testing8(); break;
					case 9:
						Testing9(); break;
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}







		private void button_device_getRam_update_Click(object sender, EventArgs e) => GetRAM();

		private void comboBox_device_getRam_ramType_SelectedIndexChanged(object sender, EventArgs e) => GetRAM();
	}
}