using System.IO;

using ScriptsLibR.Resources;

namespace ScriptsLibR.Util
{
	public static partial class NetworkUtils
	{
		public static void ConnectToWifi(string ssid, string password)
		{
			string template = Resources.Resources.EES_WPA2PSK_AES_XML;
			template = template.Replace("{SSID}", ssid).Replace("{PASSWORD}", password);

			string filePath = Info.AppdataPath + @"Temp\WifiNetworkAdd.xml";
			Directory.CreateDirectory(Info.AppdataPath + @"Temp\");
			File.WriteAllText(filePath, template);

			Utils.ExecuteCmdCommand($"netsh wlan add profile filename=\"{filePath}\" interface=\"Wi-Fi\" user=current");
			File.Delete(filePath);
		}
	}
}