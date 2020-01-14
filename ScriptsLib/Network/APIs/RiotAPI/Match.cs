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
			#region JSON
			public class MatchDto
			{
				/// <summary>Please refer to the Game Constants documentation.</summary>
				public int sessionId;
				/// <summary>Please refer to the Game Constants documentation.</summary>
				public int queueId;
				public long gameId;
				/// <summary>Participant identity information.</summary>
				public List<ParticipantIdentityDto> participantIdentities;
				/// <summary>The major.minor version typically indicates the patch the match was played on.</summary>
				public string gameVersion;
				/// <summary>Platform where the match was played.</summary>
				public string platformId;
				/// <summary>Please refer to the Game Constants documentation.</summary>
				public string gameMode;
				/// <summary>Please refer to the Game Constants documentation.</summary>
				public int mapId;
				/// <summary>Please refer to the Game Constants documentation.</summary>
				public string gameType;
				/// <summary>Team information.</summary>
				public List<TeamStatsDto> teams;
				/// <summary>Participant information.</summary>
				public List<ParticipantDto> participants;
				/// <summary>Match duration in seconds.</summary>
				public long gameDuration;
				/// <summary>Designates the timestamp when champion select ended and the loading screen appeared, NOT when the game timer was at 0:00.</summary>
				public long gameCreation;
			}

			public class ParticipantIdentityDto
			{
				/// <summary>Player information.</summary>
				public PlayerDto player;
				public int participantId;
			}

			public class PlayerDto
			{
				public string currentPlatformId;
				public string summonerName;
				public string matchHistoryUri;
				/// <summary>Original platformId.</summary>
				public string platformId;
				/// <summary>Player's current accountId (Encrypted)</summary>
				public string currentAccountId;
				public int profileIcon;
				/// <summary>Player's summonerId (Encrypted)</summary>
				public string summonerId;
				/// <summary>Player's original accountId (Encrypted)</summary>
				public string accountId;
			}

			public class TeamStatsDto
			{
				/// <summary>Flag indicating whether or not the team scored the first Dragon kill.</summary>
				public bool firstDragon;
				/// <summary>Flag indicating whether or not the team destroyed the first inhibitor.</summary>
				public bool firstInhibitor;
				/// <summary>If match queueId has a draft, contains banned champion data, otherwise empty.</summary>
				public List<TeamBansDto> bans;
				/// <summary>Number of times the team killed Baron.</summary>
				public int baronKills;
				/// <summary>Flag indicating whether or not the team scored the first Rift Herald kill.</summary>
				public bool firstRiftHerald;
				/// <summary>Flag indicating whether or not the team scored the first Baron kill.</summary>
				public bool firstBaron;
				/// <summary>Number of times the team killed Rift Herald.</summary>
				public int riftHeraldKills;
				/// <summary>Flag indicating whether or not the team scored the first blood.</summary>
				public bool firstBlood;
				/// <summary>100 for blue side. 200 for red side.</summary>
				public int teamId;
				/// <summary>Flag indicating whether or not the team destroyed the first tower.</summary>
				public bool firstTower;
				/// <summary>Number of times the team killed Vilemaw.</summary>
				public int vilemawKills;
				/// <summary>Number of inhibitors the team destroyed.</summary>
				public int inhibitorKills;
				/// <summary>Number of towers the team destroyed.</summary>
				public int towerKills;
				/// <summary>For Dominion matches, specifies the points the team had at game end.</summary>
				public int dominionVictoryScore;
				/// <summary>String indicating whether or not the team won. There are only two values visibile in public match history. (Legal values: Fail, Win)</summary>
				public string win;
				/// <summary>Number of times the team killed Dragon.</summary>
				public int dragonKills;
			}

			public class TeamBansDto
			{
				/// <summary>Turn during which the champion was banned.</summary>
				public int pickTurn;
				/// <summary>Banned championId.</summary>
				public int championId;
			}

			public class ParticipantDto
			{
				/// <summary>Participant statistics.</summary>
				public ParticipantStatsDto stats;
				public int participantId;
				/// <summary>List of legacy Rune information. Not included for matches played with Runes Reforged.</summary>
				public List<RuneDto> runes;
				/// <summary>Participant timeline data.</summary>
				public ParticipantTimelineDto timeline;
				/// <summary>100 for blue side. 200 for red side.</summary>
				public int teamId;
				/// <summary>Second Summoner Spell id.</summary>
				public int spell2Id;
				/// <summary>List of legacy Mastery information. Not included for matches played with Runes Reforged.</summary>
				public List<MasteryDto> masteries;
				/// <summary>Highest ranked tier achieved for the previous season in a specific subset of queueIds, if any, otherwise null. Used to display border in game loading screen. Please refer to the Ranked Info documentation. (Legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE, UNRANKED)</summary>
				public string highestAchievedSeasonTier;
				/// <summary>First Summoner Spell id.</summary>
				public int spell1Id;
				public int championId;
			}

			public class ParticipantStatsDto
			{
				public bool firstBloodAssist;
				public long visionScore;
				public long magicDamageDealtToChampions;
				public long damageDealtToChampions;
				public int totalTimeCrowdControlDealt;
				public int longestTimeSpentLiving;
				/// <summary>Post game rune stats.</summary>
				public int perk1Var1;
				/// <summary>Post game rune stats.</summary>
				public int perk1Var3;
				/// <summary>Post game rune stats.</summary>
				public int perk1Var2;
				public int tripleKills;
				/// <summary>Post game rune stats.</summary>
				public int perk3Var3;
				public int nodeNeutralizeAssist;
				/// <summary>Post game rune stats.</summary>
				public int perk3Var2;
				public int playerScore9;
				public int playerScore8;
				public int kills;
				public int playerScore1;
				public int playerScore0;
				public int playerScore3;
				public int playerScore2;
				public int playerScore5;
				public int playerScore4;
				public int playerScore7;
				public int playerScore6;
				/// <summary>Post game rune stats.</summary>
				public int perk5Var1;
				/// <summary>Post game rune stats.</summary>
				public int perk5Var3;
				/// <summary>Post game rune stats.</summary>
				public int perk5Var2;
				public int totalScoreRank;
				public int neutralMinionsKilled;
				public long damageDealtToTurrets;
				public long physicalDamageDealtToChampions;
				public int nodeCapture;
				public int largestMultiKill;
				/// <summary>Post game rune stats.</summary>
				public int perk2Var2;
				/// <summary>Post game rune stats.</summary>
				public int perk2Var3;
				public int totalUnitsHealed;
				/// <summary>Post game rune stats.</summary>
				public int perk2Var1;
				/// <summary>Post game rune stats.</summary>
				public int perk4Var1;
				/// <summary>Post game rune stats.</summary>
				public int perk4Var2;
				/// <summary>Post game rune stats.</summary>
				public int perk4Var3;
				public int wardsKilled;
				public int largestCriticalStrike;
				public int largestKillingSpree;
				public int quadraKills;
				public int teamObjective;
				public long magicDamageDealt;
				public int item2;
				public int item3;
				public int item0;
				public int neutralMinionsKilledTeamJungle;
				public int item6;
				public int item4;
				public int item5;
				/// <summary>Primary path rune.</summary>
				public int perk1;
				/// <summary>Primary path keystone rune.</summary>
				public int perk0;
				/// <summary>Primary path rune.</summary>
				public int perk3;
				/// <summary>Primary path rune.</summary>
				public int perk2;
				/// <summary>Secondary path rune.</summary>
				public int perk5;
				/// <summary>Secondary path rune.</summary>
				public int perk4;
				/// <summary>Post game rune stats.</summary>
				public int perk3Var1;
				public long damageSelfMitigated;
				public long magicalDamageTaken;
				public bool firstInhibitorKill;
				public long trueDamageTaken;
				public int nodeNeutralize;
				public int assists;
				public int combatPlayerScore;
				/// <summary>Primary rune path</summary>
				public int perkPrimaryStyle;
				public int goldSpent;
				public long trueDamageDealt;
				public int participantId;
				public long totalDamageTaken;
				public long physicalDamageDealt;
				public int sightWardsBoughtInGame;
				public long totalDamageDealtToChampions;
				public long physicalDamageTaken;
				public int totalPlayerScore;
				public bool win;
				public int objectivePlayerScore;
				public long totalDamageDealt;
				public int item1;
				public int neutralMinionsKilledEnemyJungle;
				public int deaths;
				public int wardsPlaced;
				/// <summary>Secondary rune path</summary>
				public int perkSubStyle;
				public int turretKills;
				public bool firstBloodKill;
				public long trueDamageDealtToChampions;
				public int goldEarned;
				public int killingSprees;
				public int unrealKills;
				public int altarsCaptured;
				public bool firstTowerAssist;
				public bool firstTowerKill;
				public int champLevel;
				public int doubleKills;
				public int nodeCaptureAssist;
				public int inhibitorKills;
				public bool firstInhibitorAssist;
				/// <summary>Post game rune stats.</summary>
				public int perk0Var1;
				/// <summary>Post game rune stats.</summary>
				public int perk0Var2;
				/// <summary>Post game rune stats.</summary>
				public int perk0Var3;
				public int visionWardsBoughtInGame;
				public int altarsNeutralized;
				public int pentaKills;
				public long totalHeal;
				public int totalMinionsKilled;
				public long timeCCingOthers;
			}

			public class RuneDto
			{
				public int runeId;
				public int rank;
			}

			public class ParticipantTimelineDto
			{
				public string lane;
				public int participantId;
				public Dictionary<string, double> csDiffPerMinDeltas;
				public Dictionary<string, double> goldPerMinDeltas;
				public Dictionary<string, double> xpDiffPerMinDeltas;
				public Dictionary<string, double> creepsPerMinDeltas;
				public Dictionary<string, double> xpPerMinDeltas;
				public string role;
				public Dictionary<string, double> damageTakenDiffPerMinDeltas;
				public Dictionary<string, double> damageTakenPerMinDeltas;
			}

			public class MasteryDto
			{
				public int masteryId;
				public int rank;
			}
			#endregion JSON





			/// <summary>Get match by match ID.</summary>
			public static string GetMatchById(long matchId)
			{
				return GET(ServerString() + $"/lol/match/v4/matches/{matchId}" + ApiString());
			}

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

				if (champion != null)
				{
					foreach (int cid in champion)
					{
						request += "&champion=" + cid;
					}
				}

				if (queue != null)
				{
					foreach (int qid in queue)
					{
						request += "&queue=" + qid;
					}
				}

				if (endTime != null)
				{
					request += "&endTime=" + endTime;
				}

				if (beginTime != null)
				{
					request += "&beginTime=" + beginTime;
				}

				if (endIndex != null)
				{
					request += "&endIndex=" + endIndex;
				}

				if (beginIndex != null)
				{
					request += "&beginIndex=" + beginIndex;
				}

				return GET(request);
			}

			/// <summary>Get match timeline by match ID.</summary>
			/// <param name="matchId">The match ID.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetMatchTimeline(long matchId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/match/v4/timelines/by-match/{matchId}" + ApiString());

				if (getJsonObject)
				{
					return JsonConvert.DeserializeObject<MatchDto>(request);
				}
				return request;
			}

			/// <summary>Get match IDs by tournament code.</summary>
			/// <param name="tournamentCode">The tournament code.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetMatchIdByTournamentCode(string tournamentCode, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/match/v4/matches/by-tournament-code/{tournamentCode}/ids" + ApiString());

				if (getJsonObject)
				{
					return JsonConvert.DeserializeObject<MatchDto>(request);
				}
				return request;
			}

			/// <summary>Get match by match ID and tournament code.</summary>
			/// <param name="tournamentCode">The tournament code.</param>
			/// <param name="matchId">The match ID.</param>
			/// <param name="getJsonObject">If true, it will return an object containing the request.</param>
			public static dynamic GetMatchByIdAndTournamentCode(string tournamentCode, long matchId, bool getJsonObject = false)
			{
				string request = GET(ServerString() + $"/lol/match/v4/matches/{matchId}/by-tournament-code/{tournamentCode}" + ApiString());

				if (getJsonObject)
				{
					return JsonConvert.DeserializeObject<MatchDto>(request);
				}
				return request;
			}
		}
	}
}
