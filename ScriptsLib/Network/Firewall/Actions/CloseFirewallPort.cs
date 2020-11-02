namespace ScriptsLib.Network
{
	public static partial class Firewall
	{
		/// <summary>Opens the given port in the local firewall.</summary>
		/// <param name="portNumber">The number of the port to close.</param>
		/// <param name="protocol">The port type (TCP, UDP or Any).</param>
		/// https://social.msdn.microsoft.com/Forums/vstudio/en-US/a3e390d1-4383-4f23-bad9-b725bef33499/add-firewall-rule-programatically?forum=wcf
		public static void CloseFirewallPort(short portNumber, Protocol protocol)
		{
			GetProfileInstance().GloballyOpenPorts.Remove(portNumber, ParseProtocol(protocol));
		}
	}
}