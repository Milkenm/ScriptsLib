#region Usings
using System.Windows.Forms;
using static ScriptsLib.Network.Security;
using static TestingGrounds.Static;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void Event_OpenFirewallPort()
		{
			PortType _PortType = new PortType();
			switch (_MainForm.comboBox_network_security_openFirewallPort_portType.Text)
			{
				case "TCP":
					_PortType = PortType.TCP; break;
				case "UDP":
					_PortType = PortType.UDP; break;
				case "Any":
					_PortType = PortType.Any; break;
			}
			OpenFirewallPort((int)_MainForm.numeric_network_security_openFirewallPort_portNumber.Value, _PortType, _MainForm.textBox_network_security_openFirewallPort_description.Text);

			MessageBox.Show("Port added!");
		}
	}
}
