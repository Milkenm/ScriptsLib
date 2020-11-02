using NetFwTypeLib;

namespace ScriptsLib.Network
{
	public static partial class Firewall
	{
		/// <summary>Opens the given port in the local firewall.</summary>
		/// <param name="portNumber">The number of the port to open.</param>
		/// <param name="protocol">The port type (TCP, UDP or Any).</param>
		/// <param name="ruleName">The name of the rule.</param>
		/// https://social.msdn.microsoft.com/Forums/vstudio/en-US/a3e390d1-4383-4f23-bad9-b725bef33499/add-firewall-rule-programatically?forum=wcf
		public static void OpenFirewallPort(short portNumber, Protocol protocol, string ruleName)
		{
			INetFwOpenPort port = GetPortInstance();
			port.Scope = NET_FW_SCOPE_.NET_FW_SCOPE_ALL;
			port.Enabled = true;
			port.Name = ruleName;
			port.Port = portNumber;
			port.Protocol = ParseProtocol(protocol);

			GetProfileInstance().GloballyOpenPorts.Add(port);
		}
	}
}
