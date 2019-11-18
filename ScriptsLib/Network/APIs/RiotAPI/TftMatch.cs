#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class TftMatch // v1
		{
			/// <summary>Get a list of match ids by PUUID.</summary>
			public static string GetMatchIds(string encryptedPUUID)
			{
				return GET(ServerString() + $"/tft/match/v1/matches/by-puuid/{encryptedPUUID}/ids" + ApiString());
			}

			/// <summary>Get a match by match id.</summary>
			public static string GetMatchById(string matchId)
			{
				return GET(ServerString() + $"/tft/match/v1/matches/{matchId}" + ApiString());
			}
		}
	}
}
