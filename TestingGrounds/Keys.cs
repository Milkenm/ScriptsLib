#region Usings
using System;
using System.Windows.Forms;

using TestingGrounds.Properties;
using static ScriptsLib.Network.APIs.RiotAPI;
#endregion Usings



namespace TestingGrounds
{
	public partial class Keys : Form
	{
		private static Settings set = new Settings();

		public Keys()
		{
			InitializeComponent();
		}

		private void Keys_Load(object sender, EventArgs e)
		{
			textBox_riotapi.Text = set.RiotAPIKey;

			foreach (var value in Enum.GetValues(typeof(Regions)))
			{
				comboBox_lolRegion.Items.Add(value.ToString());
			}

			if (!string.IsNullOrEmpty(set.LoLRegion))
			{
				comboBox_lolRegion.SelectedText = set.LoLRegion;
			}
		}

		private void button_ok_Click(object sender, EventArgs e)
		{
			set.RiotAPIKey = textBox_riotapi.Text;
			set.LoLRegion = comboBox_lolRegion.Text;
			Close();
		}

		private void Keys_FormClosing(object sender, FormClosingEventArgs e)
		{
			set.Save();
		}
	}
}
