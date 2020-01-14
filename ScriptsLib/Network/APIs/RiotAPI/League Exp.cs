#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class LeagueExp
		{
			/// <summary>Get all the league entries.</summary>
			/// <param name="queue">Note that the queue value must be a valid ranked queue.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetLeagueEntries(string queue, string tier, string division, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/league-exp/v4/entries/{queue}/{tier}/{division}" + ApiString());

				return ReturnRequest<LeagueEntryDTO[]>(request, getJsonObject);
			}
		}
	}
}
