#region Usings
using System;
using System.Windows.Forms;

using static TestingGrounds.Events;
using static TestingGrounds.Functions;
using static TestingGrounds.Static;
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
		
		private void button_tg_test_Click(object sender, EventArgs e) => TestingButton();







		private void button_device_getRam_update_Click(object sender, EventArgs e) => GetRAM();

		private void comboBox_device_getRam_ramType_SelectedIndexChanged(object sender, EventArgs e) => GetRAM();

		private void button_lineGraph_drawTest_Click(object sender, EventArgs e) => DrawTest();
	}
}