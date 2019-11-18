internal static partial class APIs
	{
		internal static class RiotAPI
		{
			#region Enums
			internal enum Regions
			{
				RU,
				KR,
				BR1,
				OC1,
				JP1,
				NA1,
				EUN1,
				EUW1,
				TR1,
				LA1,
				LA2,
			}

			internal enum Queues
			{
				RANKED_SOLO_5x5,
				RANKED_TFT,
				RANKED_FLEX_SR,
				RANKED_FLEX_TT,
			}

			internal enum Tiers
			{
				IRON,
				BRONZE,
				SILVER,
				GOLD,
				PLATINUM,
				DIAMOND,
				MASTER,
				GRANDMASTER,
				CHALLENGER,
			}

			internal enum Divisions
			{
				I,
				II,
				III,
				IV,
			}
			#endregion Enums

			internal static string ApiKey;
			internal static Regions Region;

			private static string ApiString() => "?api_key=" + ApiKey;
			private static string ServerString() => string.Format(RiotAPIOrigin, Region);





			internal static class Requests
			{
				internal static class ChampionMastery // v4
				{
					/// <summary>Get all champion mastery entries sorted by number of champion points descending.</summary>
					/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
					internal static string GetChampionMasteryList(string encryptedSummonerId) => GET(ServerString() + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}" + ApiString());

					/// <summary>Get a champion mastery by player ID and champion ID.</summary>
					/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
					/// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
					internal static string GetMasteryByChampion(string encryptedSummonerId, long championId) => GET(ServerString() + $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}" + ApiString());

					/// <summary>Get a player's total champion mastery score, which is the sum of individual champion mastery levels.</summary>
					/// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
					internal static string GetTotalMasteryScore(string encryptedSummonerId) => GET(ServerString() + $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}" + ApiString());
				}

				internal static class Champion // v3
				{
					/// <summary>Returns champion rotations, including free-to-play and low-level free-to-play rotations (REST).</summary>
					internal static string GetChampionRotation() => GET(ServerString() + "/lol/platform/v3/champion-rotations" + ApiString());
				}

				internal static class League // v4
				{
					/// <summary>Get the challenger league for given queue.</summary>
					internal static string GetChallengerEntries(Queues queue) => GET(ServerString() + $"/lol/league/v4/challengerleagues/by-queue/{queue}" + ApiString());

					/// <summary>Get league entries in all queues for a given summoner ID.</summary>
					internal static string GetSummonerLeagues(string encryptedSummonerId) => GET(ServerString() + $"/lol/league/v4/entries/by-summoner/{encryptedSummonerId}" + ApiString());

					/// <summary>Get all the league entries.</summary>
					/// <param name="queue">Note that the queue value must be a valid ranked queue.</param>
					/// <param name="page">Starts with page 1.</param>
					internal static string GetLeagueEntries(Queues queue, Tiers tier, Divisions division, int? page)
					{
						string request = ServerString() + $"/lol/league/v4/entries/{queue}/{tier}/{division}" + ApiString();

						if (page != null) request += "&page=" + page;

						return request;
					}

					/// <summary>Get the grandmaster league of a specific queue.</summary>
					internal static string GetGrandmasterEntries(Queues queue) => GET(ServerString() + $"/lol/league/v4/grandmasterleagues/by-queue/{queue}" + ApiString());

					/// <summary>Get league with given ID, including inactive entries.</summary>
					/// <param name="leagueId">The UUID of the league.</param>
					internal static string GetLeagueById(int leagueId) => GET(ServerString() + $"/lol/league/v4/leagues/{leagueId}" + ApiString());

					/// <summary>Get the master league for given queue.</summary>
					internal static string GetMasterEntries(Queues queue) => GET(ServerString() + $"/lol/league/v4/masterleagues/by-queue/{queue}" + ApiString());
				}

				internal static class LolStatus // v3
				{
					/// <summary>Get League of Legends status for the given shard.</summary>
					internal static string GetLolStatus() => GET(ServerString() + "/lol/status/v3/shard-data" + ApiString());
				}

				internal static class Match // v4
				{
					/// <summary>Get match by match ID.</summary>
					internal static string GetMatchById(long matchId) => GET(ServerString() + $"/lol/match/v4/matches/{matchId}" + ApiString());

					/// <summary>Get matchlist for games played on given account ID and platform ID and filtered using given filter parameters, if any.</summary>
					/// <param name="encryptedAccountId">The account ID.</param>
					/// <param name="champion">Set of champion IDs for filtering the matchlist.</param>
					/// <param name="queue">Set of queue IDs for filtering the matchlist.</param>
					/// <param name="endTime">The end time to use for filtering matchlist specified as epoch milliseconds. If beginTime is specified, but not endTime, then endTime defaults to the the current unix timestamp in milliseconds (the maximum time range limitation is not observed in this specific case). If endTime is specified, but not beginTime, then beginTime defaults to the start of the account's match history returning a 400 due to the maximum time range limitation. If both are specified, then endTime should be greater than beginTime. The maximum time range allowed is one week, otherwise a 400 error code is returned.</param>
					/// <param name="beginTime">The begin time to use for filtering matchlist specified as epoch milliseconds. If beginTime is specified, but not endTime, then endTime defaults to the the current unix timestamp in milliseconds (the maximum time range limitation is not observed in this specific case). If endTime is specified, but not beginTime, then beginTime defaults to the start of the account's match history returning a 400 due to the maximum time range limitation. If both are specified, then endTime should be greater than beginTime. The maximum time range allowed is one week, otherwise a 400 error code is returned.</param>
					/// <param name="endIndex">The end index to use for filtering matchlist. If beginIndex is specified, but not endIndex, then endIndex defaults to beginIndex+100. If endIndex is specified, but not beginIndex, then beginIndex defaults to 0. If both are specified, then endIndex must be greater than beginIndex. The maximum range allowed is 100, otherwise a 400 error code is returned.</param>
					/// <param name="beginIndex">The begin index to use for filtering matchlist. If beginIndex is specified, but not endIndex, then endIndex defaults to beginIndex+100. If endIndex is specified, but not beginIndex, then beginIndex defaults to 0. If both are specified, then endIndex must be greater than beginIndex. The maximum range allowed is 100, otherwise a 400 error code is returned.</param>
					internal static string GetMatchHistory(string encryptedAccountId, int?[] champion, int?[] queue, long? endTime, long? beginTime, int? endIndex, int? beginIndex)
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
					internal static string GetMatchTimeline(long matchId) => GET(ServerString() + $"/lol/match/v4/timelines/by-match/{matchId}" + ApiString());

					/// <summary>Get match IDs by tournament code.</summary>
					/// <param name="tournamentCode">The tournament code.</param>
					internal static string GetMatchIdByTournamentCode(string tournamentCode) => GET(ServerString() + $"/lol/match/v4/matches/by-tournament-code/{tournamentCode}/ids" + ApiString());

					/// <summary>Get match by match ID and tournament code.</summary>
					/// <param name="tournamentCode">The tournament code.</param>
					/// <param name="matchId">The match ID.</param>
					internal static string GetMatchByIdAndTournamentCode(string tournamentCode, long matchId) => GET(ServerString() + $"/lol/match/v4/matches/{matchId}/by-tournament-code/{tournamentCode}" + ApiString());
				}

				internal static class Spectator // v4
				{
					/// <summary>Get current game information for the given summoner ID</summary>
					/// <param name="encryptedSummonerId">The ID of the summoner.</param>
					internal static string GetCurrentGameInfo(string encryptedSummonerId) => GET(ServerString() + $"/lol/spectator/v4/active-games/by-summoner/{encryptedSummonerId}" + ApiString());

					/// <summary>Get list of featured games.</summary>
					internal static string GetFeaturedGames() => GET(ServerString() + "/lol/spectator/v4/featured-games" + ApiString());
				}

				internal static class Summoner // v4
				{
					/// <summary>Get a summoner by account ID.</summary>
					internal static string GetSummonerByAccountId(string encryptedAccountId) => GET(ServerString() + $"/lol/summoner/v4/summoners/by-account/{encryptedAccountId}" + ApiString());

					/// <summary>Get a summoner by summoner name.</summary>
					/// <param name="summonerName">Summoner Name.</param>
					internal static string GetSummonerByName(string summonerName) => GET(ServerString() + $"/lol/summoner/v4/summoners/by-name/{summonerName}" + ApiString());

					/// <summary>Get a summoner by PUUID.</summary>
					/// <param name="encryptedPUUID">Summoner ID.</param>
					internal static string GetSummonerByPuuid(string encryptedPUUID) => GET(ServerString() + $"/lol/summoner/v4/summoners/by-puuid/{encryptedPUUID}" + ApiString());

					/// <summary>Get a summoner by summoner ID.</summary>
					/// <param name="encryptedSummonerId">Summoner ID.</param>
					internal static string GetSummonerBySummonerId(string encryptedSummonerId) => GET(ServerString() + $"/lol/summoner/v4/summoners/{encryptedSummonerId}" + ApiString());
				}

				internal static class TftLeague // v1
				{
					/// <summary>Get the challenger league.</summary>
					internal static string GetChallengerEntries() => GET(ServerString() + "/tft/league/v1/challenger" + ApiString());

					/// <summary>Get league entries for a given summoner ID.</summary>
					internal static string GetSummonerLeagues(string encryptedSummonerId) => GET(ServerString() + $"/tft/league/v1/entries/by-summoner/{encryptedSummonerId}" + ApiString());

					/// <summary>Get all the league entries.</summary>
					/// <param name="page">Starts with page 1.</param>
					internal static string GetLeagueEntries(Tiers tier, Divisions division, int? page)
					{
						string request = ServerString() + $"/tft/league/v1/entries/{tier}/{division}" + ApiString();

						if (page != null) request += "&page=" + page;

						return request;
					}

					/// <summary>Get the grandmaster league.</summary>
					internal static string GetGrandmasterEntries() => GET(ServerString() + "/tft/league/v1/grandmaster" + ApiString());

					/// <summary>Get league with given ID, including inactive entries.</summary>
					/// <param name="leagueId">The UUID of the league.</param>
					internal static string GetLeagueById(int leagueId) => GET(ServerString() + $"/tft/league/v1/leagues/{leagueId}" + ApiString());

					/// <summary>Get the master league.</summary>
					internal static string GetMasterEntries() => GET(ServerString() + "/tft/league/v1/master" + ApiString());
				}

				internal static class TftMatch // v1
				{
					/// <summary>Get a list of match ids by PUUID.</summary>
					internal static string GetMatchIds(string encryptedPUUID) => GET(ServerString() + $"/tft/match/v1/matches/by-puuid/{encryptedPUUID}/ids" + ApiString());

					/// <summary>Get a match by match id.</summary>
					internal static string GetMatchById(string matchId) => GET(ServerString() + $"/tft/match/v1/matches/{matchId}" + ApiString());
				}

				internal static class TftSummoner // v1
				{
					/// <summary>Get a summoner by account ID.</summary>
					internal static string GetSummonerByAccountId(string encryptedAccountId) => GET(ServerString() + $"/tft/summoner/v1/summoners/by-account/{encryptedAccountId}" + ApiString());

					/// <summary>Get a summoner by summoner name.</summary>
					/// <param name="summonerName">Summoner Name.</param>
					internal static string GetSummonerByName(string summonerName) => GET(ServerString() + $"/tft/summoner/v1/summoners/by-name/{summonerName}" + ApiString());

					/// <summary>Get a summoner by PUUID.</summary>
					/// <param name="encryptedPUUID">Summoner ID.</param>
					internal static string GetSummonerByPuuid(string encryptedPUUID) => GET(ServerString() + $"/tft/summoner/v1/summoners/by-puuid/{encryptedPUUID}" + ApiString());

					/// <summary>Get a summoner by summoner ID.</summary>
					/// <param name="encryptedSummonerId">Summoner ID.</param>
					internal static string GetSummonerBySummonerId(string encryptedSummonerId) => GET(ServerString() + $"/tft/summoner/v1/summoners/{encryptedSummonerId}" + ApiString());
				}
			}
		}
	}