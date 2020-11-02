using NetFwTypeLib;

using System;

namespace ScriptsLib.Network
{
	public static partial class Firewall
	{
		public enum Protocol
		{
			TCP,
			UDP,
			Any,
		}

		public static NET_FW_IP_PROTOCOL_ ParseProtocol(Protocol protocol)
		{
			return protocol switch
			{
				Protocol.TCP => NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP,
				Protocol.UDP => NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP,
				Protocol.Any => NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY,
			};
		}

		public static INetFwProfile GetProfileInstance()
		{
			return ((INetFwMgr)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwMgr"))).LocalPolicy.CurrentProfile;
		}

		public static INetFwOpenPort GetPortInstance()
		{
			return (INetFwOpenPort)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWOpenPort"));
		}
	}
}
