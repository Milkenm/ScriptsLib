using NetFwTypeLib;

using System;

namespace ScriptsLib.Network
{
	public static partial class Firewall
	{
		public static void DisableFirewall()
		{
			INetFwProfile profile = ((INetFwMgr)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwMgr"))).LocalPolicy.CurrentProfile;
			profile.FirewallEnabled = false;
		}
	}
}