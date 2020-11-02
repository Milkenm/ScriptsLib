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
			Protocol _PortType = new Protocol();
			switch (MainForm.comboBox_network_security_openFirewallPort_portType.Text)
			{
				case "TCP":
					_PortType = Protocol.TCP; break;
				case "UDP":
					_PortType = Protocol.UDP; break;
				case "Any":
					_PortType = Protocol.Any; break;
			}
			OpenFirewallPort((int)MainForm.numeric_network_security_openFirewallPort_portNumber.Value, _PortType, MainForm.textBox_network_security_openFirewallPort_description.Text);

			MessageBox.Show("Port added!");
		}
	}
}
