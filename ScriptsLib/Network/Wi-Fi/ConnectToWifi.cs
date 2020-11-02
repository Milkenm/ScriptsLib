using System.IO;

namespace ScriptsLib.Network
{
	public static partial class Wifi
	{
		public static void Connect(string ssid, string password)
		{
			string template = Properties.Resources.EES_WPA2PSK_AES_XML;
			template = template.Replace("{SSID}", ssid).Replace("{PASSWORD}", password);

			string filePath = Info.AppdataPath + @"Temp\WifiNetworkAdd.xml";
			Directory.CreateDirectory(Info.AppdataPath + @"Temp\");
			File.WriteAllText(filePath, template);

			Tools.ExecuteCmdCommand($"netsh wlan add profile filename=\"{filePath}\" interface=\"Wi-Fi\" user=current");
			File.Delete(filePath);
		}
	}
}
