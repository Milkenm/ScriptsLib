using Newtonsoft.Json;

using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class Champion // v3
		{
			/// <summary>Returns champion rotations, including free-to-play and low-level free-to-play rotations (REST).</summary>
			public dynamic GetChampionRotation(Regions region)
			{
				string request = GET(ServerString(region) + "/lol/platform/v3/champion-rotations" + ApiString());
				return JsonConvert.DeserializeObject<ChampionInfo>(request);
			}
		}
	}
}