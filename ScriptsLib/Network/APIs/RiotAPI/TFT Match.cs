#region Usings
using System.Collections.Generic;

using Newtonsoft.Json;

using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class TftMatch // v1
		{
			/// <summary>Get a list of match ids by PUUID.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static List<string> GetMatchIds(string encryptedPUUID)
			{
				string request = GET(ServerString() + $"/tft/match/v1/matches/by-puuid/{encryptedPUUID}/ids" + ApiString());

				return JsonConvert.DeserializeObject<List<string>>(request);
			}

			/// <summary>Get a match by match id.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static string GetMatchById(string matchId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/tft/match/v1/matches/{matchId}" + ApiString());

				return ReturnResponse<MatchDTO>(request, getJsonObject);
			}
		}
	}
}
