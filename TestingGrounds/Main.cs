#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib.Network.APIs;

using TestingGrounds.Properties;

using static ScriptsLib.Network.APIs.RiotAPI;
using static ScriptsLib.Network.APIs.RiotAPI.ChampionMastery;
using static ScriptsLib.Network.Requests;
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

		private void button_tg_test_Click(object sender, EventArgs e)
		{
			TestingButton();
		}

		private void button_device_getRam_update_Click(object sender, EventArgs e)
		{
			GetRAM();
		}

		private void comboBox_device_getRam_ramType_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetRAM();
		}

		private void button_lineGraph_drawTest_Click(object sender, EventArgs e)
		{
			DrawTest();
		}

		private void button_network_requests_get_execute_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show(GET(textBox_network_requests_get_endpoint.Text), "GET Request");
			}
			catch (Exception ex) { Ex(ex); }
		}

		private void button_network_apis_riotapi_championMastery_getChampionMasteryList_get_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show(GetChampionMasteryList(textBox_network_apis_riotapi_championMastery_getChampionMasteryList_encryptedSummonerId.Text));
			}
			catch (Exception ex) { Ex(ex); }
		}

		private void button_tg_refresh_Click(object sender, EventArgs e)
		{
			ApiKey = new Settings().RiotAPIKey;
			if (!string.IsNullOrEmpty(new Settings().LoLRegion))
			{
				RiotAPI.Region = (Regions) Enum.Parse(typeof(Regions), new Settings().LoLRegion, true);
			}
		}

		private void button_tg_keys_Click(object sender, EventArgs e)
		{
			new Keys().Show();
		}
	}
}