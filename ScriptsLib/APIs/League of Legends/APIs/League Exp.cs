using Newtonsoft.Json;

using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class LeagueExp
		{
			/// <summary>Get all the league entries.</summary>
			/// <param name="queue">Note that the queue value must be a valid ranked queue.</param>
			public LeagueEntryDTO[] GetLeagueEntries(Regions region, string queue, string tier, string division)
			{
				string request = GET(ServerString(region) + $"/lol/league-exp/v4/entries/{queue}/{tier}/{division}" + ApiString());
				return JsonConvert.DeserializeObject<LeagueEntryDTO[]>(request);
			}
		}
	}
}