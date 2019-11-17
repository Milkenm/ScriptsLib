#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class LolStatus // v3
		{
			/// <summary>Get League of Legends status for the given shard.</summary>
			public static string GetLolStatus() => GET(ServerString() + "/lol/status/v3/shard-data" + ApiString());
		}
	}
}
