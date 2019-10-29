#region Usings
using System;

using NetFwTypeLib;
#endregion Usings

// # = #
// https://social.msdn.microsoft.com/Forums/vstudio/en-US/a3e390d1-4383-4f23-bad9-b725bef33499/add-firewall-rule-programatically?forum=wcf
// # = #

namespace ScriptsLib.Network
{
	public static partial class Security
	{
		/// <summary>Opens the given port in the local firewall.</summary>
		/// <param name="_PortNumber">The number of the port to open.</param>
		/// <param name="_PortType">The port type (TCP, UDP or Any).</param>
		/// <param name="_RuleName">The name of the rule.</param>
		public static void OpenFirewallPort(int _PortNumber, PortType _PortType, string _RuleName)
		{
			INetFwOpenPort _Port = (INetFwOpenPort)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWOpenPort"));
			INetFwProfile _Profile = ((INetFwMgr)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwMgr"))).LocalPolicy.CurrentProfile;


			// Set the port properties
			_Port.Scope = NET_FW_SCOPE_.NET_FW_SCOPE_ALL;
			_Port.Enabled = true;
			_Port.Name = _RuleName;
			_Port.Port = _PortNumber;

			switch (_PortType)
			{
				case PortType.TCP:
					_Port.Protocol = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP; break;
				case PortType.UDP:
					_Port.Protocol = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP; break;
				case PortType.Any:
					_Port.Protocol = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY; break;
			}


			// Add the port to the ICF Permissions List
			_Profile.GloballyOpenPorts.Add(_Port);
		}

		public enum PortType
		{
			TCP,
			UDP,
			Any,
		}
	}
}
