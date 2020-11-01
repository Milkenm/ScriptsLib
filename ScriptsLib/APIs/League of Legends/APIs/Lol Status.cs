using Newtonsoft.Json;

using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class LolStatus // v3
		{
			/// <summary>Get League of Legends status for the given shard.</summary>
			public ShardStatus GetLolStatus(Regions region)
			{
				string request = GET(ServerString(region) + "/lol/status/v3/shard-data" + ApiString());
				return JsonConvert.DeserializeObject<ShardStatus>(request);
			}
		}
	}
}
