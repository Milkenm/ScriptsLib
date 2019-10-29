#region Usings
using System;
using System.Windows.Forms;

using ScriptsLib.Network;

using static TestingGrounds.Functions;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_ConnectToWifi()
		{
			try
			{
				if (!String.IsNullOrEmpty(MainForm.textBox_network_wifi_connect_wifiPassword.Text) && !String.IsNullOrEmpty(MainForm.textBox_network_wifi_connect_wifiSsid.Text))
				{
					Wifi.Connect(MainForm.textBox_network_wifi_connect_wifiSsid.Text, MainForm.textBox_network_wifi_connect_wifiPassword.Text);
				}
				else
				{
					MessageBox.Show("Fill all fields.");
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
	}
}