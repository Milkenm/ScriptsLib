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
using static TestingGrounds.Static;
using static TestingGrounds.Testing;
#endregion Usings



namespace TestingGrounds
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			MainForm = this;
			MainInitEvents();
		}


		private void button_tg_test_Click(object sender, EventArgs e) => TestingButton(numeric);







		private void button_device_getRam_update_Click(object sender, EventArgs e) => GetRAM();

		private void comboBox_device_getRam_ramType_SelectedIndexChanged(object sender, EventArgs e) => GetRAM();
	}
}