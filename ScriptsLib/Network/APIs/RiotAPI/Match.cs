#region Usings
using System.Collections.Generic;
using Newtonsoft.Json;
using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		public static class Match // v4
		{
			/// <summary>Get match by match ID.</summary>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetMatchById(long matchId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/match/v4/matches/{matchId}" + ApiString());

				return ReturnResponse<MatchDTO>(request, getJsonObject);
			}

			/// <summary>Get matchlist for games played on given account ID and platform ID and filtered using given filter parameters, if any.</summary>
			/// <param name="encryptedAccountId">The account ID.</param>
			/// <param name="champion">Set of champion IDs for filtering the matchlist.</param>
			/// <param name="queue">Set of queue IDs for filtering the matchlist.</param>
			/// <param name="endTime">The end time to use for filtering matchlist specified as epoch milliseconds. If beginTime is specified, but not endTime, then endTime defaults to the the current unix timestamp in milliseconds (the maximum time range limitation is not observed in this specific case). If endTime is specified, but not beginTime, then beginTime defaults to the start of the account's match history returning a 400 due to the maximum time range limitation. If both are specified, then endTime should be greater than beginTime. The maximum time range allowed is one week, otherwise a 400 error code is returned.</param>
			/// <param name="beginTime">The begin time to use for filtering matchlist specified as epoch milliseconds. If beginTime is specified, but not endTime, then endTime defaults to the the current unix timestamp in milliseconds (the maximum time range limitation is not observed in this specific case). If endTime is specified, but not beginTime, then beginTime defaults to the start of the account's match history returning a 400 due to the maximum time range limitation. If both are specified, then endTime should be greater than beginTime. The maximum time range allowed is one week, otherwise a 400 error code is returned.</param>
			/// <param name="endIndex">The end index to use for filtering matchlist. If beginIndex is specified, but not endIndex, then endIndex defaults to beginIndex+100. If endIndex is specified, but not beginIndex, then beginIndex defaults to 0. If both are specified, then endIndex must be greater than beginIndex. The maximum range allowed is 100, otherwise a 400 error code is returned.</param>
			/// <param name="beginIndex">The begin index to use for filtering matchlist. If beginIndex is specified, but not endIndex, then endIndex defaults to beginIndex+100. If endIndex is specified, but not beginIndex, then beginIndex defaults to 0. If both are specified, then endIndex must be greater than beginIndex. The maximum range allowed is 100, otherwise a 400 error code is returned.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetMatchHistory(string encryptedAccountId, int?[] champion, int?[] queue, long? endTime, long? beginTime, int? endIndex, int? beginIndex, bool getJsonObject = false)
			{
				string requestString = ServerString() + $"/lol/match/v4/matchlists/by-account/{encryptedAccountId}" + ApiString();

				if (champion != null)
				{
					foreach (int cid in champion)
					{
						requestString += "&champion=" + cid;
					}
				}

				if (queue != null)
				{
					foreach (int qid in queue)
					{
						requestString += "&queue=" + qid;
					}
				}

				if (endTime != null)
				{
					requestString += "&endTime=" + endTime;
				}

				if (beginTime != null)
				{
					requestString += "&beginTime=" + beginTime;
				}

				if (endIndex != null)
				{
					requestString += "&endIndex=" + endIndex;
				}

				if (beginIndex != null)
				{
					requestString += "&beginIndex=" + beginIndex;
				}

				string request = GET(requestString);

				return ReturnResponse<MatchlistDTO>(request, getJsonObject);
			}

			/// <summary>Get match timeline by match ID.</summary>
			/// <param name="matchId">The match ID.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetMatchTimeline(long matchId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/match/v4/timelines/by-match/{matchId}" + ApiString());

				return ReturnResponse<MatchTimelineDTO>(request, getJsonObject);
			}

			/// <summary>Get match IDs by tournament code.</summary>
			/// <param name="tournamentCode">The tournament code.</param>
			public static List<long> GetMatchIdByTournamentCode(string tournamentCode)
			{
				string request = GET(ServerString() + $"/lol/match/v4/matches/by-tournament-code/{tournamentCode}/ids" + ApiString());

				return JsonConvert.DeserializeObject<List<long>>(request);
			}

			/// <summary>Get match by match ID and tournament code.</summary>
			/// <param name="tournamentCode">The tournament code.</param>
			/// <param name="matchId">The match ID.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetMatchByIdAndTournamentCode(string tournamentCode, long matchId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/match/v4/matches/{matchId}/by-tournament-code/{tournamentCode}" + ApiString());

				return ReturnResponse<MatchDTO>(request, getJsonObject);
			}
		}
	}
}
