#region Usings
using System;
using System.IO;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nNetwork
{
	public static partial class Wifi
	{
		public static void Connect(string _SSID, string _Password)
		{
			try
			{
				string _EESWPA2PSKAES_Template = String.Join("\n", File.ReadAllLines(@"Resources\Templates\Network\Wifi\EES_WPA2PSK_AES.xml"));
				string _AppdataXmlPath = Info._AppdataPath + @"Temp\WifiNetworkAdd.xml";
				
				_EESWPA2PSKAES_Template = Tools.ReplaceString(_EESWPA2PSKAES_Template, "{SSID}", _SSID);
				_EESWPA2PSKAES_Template = Tools.ReplaceString(_EESWPA2PSKAES_Template, "{PASSWORD}", _Password);

				Directory.CreateDirectory(Info._AppdataPath + @"Temp\");
				File.WriteAllText(_AppdataXmlPath, _EESWPA2PSKAES_Template);

				Tools.ExecuteCmdCommand($@"netsh wlan add profile filename=""{_AppdataXmlPath}"" interface=""Wi-Fi"" user=current");
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}

		}
	}
}
