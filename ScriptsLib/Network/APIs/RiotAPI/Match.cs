#region Usings
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class Match // v4
		{
			/// <summary>Get match by match ID.</summary>
			public static string GetMatchById(long matchId) => GET(ServerString() + $"/lol/match/v4/matches/{matchId}" + ApiString());

			/// <summary>Get matchlist for games played on given account ID and platform ID and filtered using given filter parameters, if any.</summary>
			/// <param name="encryptedAccountId">The account ID.</param>
			/// <param name="champion">Set of champion IDs for filtering the matchlist.</param>
			/// <param name="queue">Set of queue IDs for filtering the matchlist.</param>
			/// <param name="endTime">The end time to use for filtering matchlist specified as epoch milliseconds. If beginTime is specified, but not endTime, then endTime defaults to the the current unix timestamp in milliseconds (the maximum time range limitation is not observed in this specific case). If endTime is specified, but not beginTime, then beginTime defaults to the start of the account's match history returning a 400 due to the maximum time range limitation. If both are specified, then endTime should be greater than beginTime. The maximum time range allowed is one week, otherwise a 400 error code is returned.</param>
			/// <param name="beginTime">The begin time to use for filtering matchlist specified as epoch milliseconds. If beginTime is specified, but not endTime, then endTime defaults to the the current unix timestamp in milliseconds (the maximum time range limitation is not observed in this specific case). If endTime is specified, but not beginTime, then beginTime defaults to the start of the account's match history returning a 400 due to the maximum time range limitation. If both are specified, then endTime should be greater than beginTime. The maximum time range allowed is one week, otherwise a 400 error code is returned.</param>
			/// <param name="endIndex">The end index to use for filtering matchlist. If beginIndex is specified, but not endIndex, then endIndex defaults to beginIndex+100. If endIndex is specified, but not beginIndex, then beginIndex defaults to 0. If both are specified, then endIndex must be greater than beginIndex. The maximum range allowed is 100, otherwise a 400 error code is returned.</param>
			/// <param name="beginIndex">The begin index to use for filtering matchlist. If beginIndex is specified, but not endIndex, then endIndex defaults to beginIndex+100. If endIndex is specified, but not beginIndex, then beginIndex defaults to 0. If both are specified, then endIndex must be greater than beginIndex. The maximum range allowed is 100, otherwise a 400 error code is returned.</param>
			public static string GetMatchHistory(string encryptedAccountId, int?[] champion, int?[] queue, long? endTime, long? beginTime, int? endIndex, int? beginIndex)
			{
				string request = ServerString() + $"/lol/match/v4/matchlists/by-account/{encryptedAccountId}" + ApiString();

				if (champion != null) foreach (int cid in champion) request += "&champion=" + cid;
				if (queue != null) foreach (int qid in queue) request += "&queue=" + qid;
				if (endTime != null) request += "&endTime=" + endTime;
				if (beginTime != null) request += "&beginTime=" + beginTime;
				if (endIndex != null) request += "&endIndex=" + endIndex;
				if (beginIndex != null) request += "&beginIndex=" + beginIndex;

				return GET(request);
			}

			/// <summary>Get match timeline by match ID.</summary>
			/// <param name="matchId">The match ID.</param>
			public static string GetMatchTimeline(long matchId) => GET(ServerString() + $"/lol/match/v4/timelines/by-match/{matchId}" + ApiString());

			/// <summary>Get match IDs by tournament code.</summary>
			/// <param name="tournamentCode">The tournament code.</param>
			public static string GetMatchIdByTournamentCode(string tournamentCode) => GET(ServerString() + $"/lol/match/v4/matches/by-tournament-code/{tournamentCode}/ids" + ApiString());

			/// <summary>Get match by match ID and tournament code.</summary>
			/// <param name="tournamentCode">The tournament code.</param>
			/// <param name="matchId">The match ID.</param>
			public static string GetMatchByIdAndTournamentCode(string tournamentCode, long matchId) => GET(ServerString() + $"/lol/match/v4/matches/{matchId}/by-tournament-code/{tournamentCode}" + ApiString());
		}
	}
}
