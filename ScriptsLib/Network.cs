#region Usings
using System;
using System.IO;

using static ScriptsLib.Dev.Debug;
#endregion Usings



namespace ScriptsLib.Network
{
	public class Network
	{
		public class Wifi
		{
			#region Refs
			Dev.Debug _Debug = new Dev.Debug();
			#endregion Refs

			public void Connect(string _SSID, string _Password)
			{
				try
				{
					string _EESWPA2PSKAES_Template = String.Join("\n", File.ReadAllLines(@"Resources\Templates\Network\Wifi\EES_WPA2PSK_AES.xml"));
					string _AppdataXmlPath = new Resources.Values()._AppdataPath + @"Temp\WifiNetworkAdd.xml";

					Tools.Tools _Tools = new Tools.Tools();
					_EESWPA2PSKAES_Template = _Tools.ReplaceString(_EESWPA2PSKAES_Template, "{SSID}", _SSID);
					_EESWPA2PSKAES_Template = _Tools.ReplaceString(_EESWPA2PSKAES_Template, "{PASSWORD}", _Password);

					Directory.CreateDirectory(new Resources.Values()._AppdataPath + @"Temp\");
					File.WriteAllText(_AppdataXmlPath, _EESWPA2PSKAES_Template);

					_Tools.ExecuteCmdCommand($@"netsh wlan add profile filename=""{_AppdataXmlPath}"" interface=""Wi-Fi"" user=current");
				}
				catch (Exception _Exception)
				{
					_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				}

			}
		}
	}
}
