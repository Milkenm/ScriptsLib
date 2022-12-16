using System.Collections.Generic;

using Newtonsoft.Json;

namespace ScriptsLibV2.APIs
{
	/// <summary>This object contains single Champion Mastery information for player and champion combination.</summary>
	public class ChampionMasteryDTO
	{
		/// <summary>Is chest granted for this champion or not in current season.</summary>
		[JsonProperty("chestGranted")] public bool IsChestGranted;

		/// <summary>Champion level for specified player and champion combination.</summary>
		[JsonProperty("championLevel")] public int ChampionLevel;

		/// <summary>Total number of champion points for this player and champion combination - they are used to determine championLevel.</summary>
		[JsonProperty("championPoints")] public int ChampionPoints;

		/// <summary>Champion ID for this entry.</summary>
		[JsonProperty("championId")] public long ChampionId;

		/// <summary>Number of points needed to achieve next level. Zero if player reached maximum champion level for this champion.</summary>
		[JsonProperty("championPointsUntilNextLevel")] public long ChampionPointsUntilNextLevel;

		/// <summary>Last time this champion was played by this player - in Unix milliseconds time format.</summary>
		[JsonProperty("lastPlayTime")] public long LastPlayTime;

		/// <summary>The token earned for this champion to levelup.</summary>
		[JsonProperty("tokensEarned")] public int TokensEarned;

		/// <summary>Number of points earned since current level has been achieved.</summary>
		[JsonProperty("championPointsSinceLastLevel")] public long ChampionPointsSinceLastLevel;

		/// <summary>Summoner ID for this entry. (Encrypted)</summary>
		[JsonProperty("summonerId")] public string SummonerId;
	}

	public class ChampionInfo
	{
		[JsonProperty("freeChampionIdsForNewPlayers")] public List<int> FreeChampionIdsForNewPlayersList;
		[JsonProperty("freeChampionIds")] public List<int> FreeChampionIdsList;
		[JsonProperty("maxNewPlayerLevel")] public int MaxNewPlayerLevel;
	}

	public class LeagueEntryDTO
	{
		[JsonProperty("queueType")] public string QueueType;
		[JsonProperty("summonerName")] public string SummonerName;
		[JsonProperty("hotStreak")] public bool IsHotStreak;
		[JsonProperty("miniSeries")] public MiniSeriesDTO MiniSeries;

		/// <summary>Winning team on Summoners Rift. First placement in Teamfight Tactics.</summary>
		[JsonProperty("wins")] public int Wins;

		[JsonProperty("veteran")] public bool IsVeteran;

		/// <summary>Losing team on Summoners Rift. Second through eighth placement in Teamfight Tactics.</summary>
		[JsonProperty("losses")] public int Losses;

		[JsonProperty("rank")] public string Rank;
		[JsonProperty("leagueId")] public string LeagueId;
		[JsonProperty("inactive")] public bool IsInactive;
		[JsonProperty("freshBlood")] public bool IsFreshBlood;
		[JsonProperty("tier")] public string Tier;

		/// <summary>Player's summonerId (Encrypted)</summary>
		[JsonProperty("summonerId")] public string SummonerId;

		[JsonProperty("leaguePoints")] public int LeaguePoints;
	}

	public class LeagueListDTO
	{
		[JsonProperty("leagueId")] public string LeagueId;
		[JsonProperty("tier")] public string Tier;
		[JsonProperty("entries")] public List<LeagueItemDTO> EntriesList;
		[JsonProperty("queue")] public string Queue;
		[JsonProperty("name")] public string Name;
	}

	public class LeagueItemDTO
	{
		[JsonProperty("summonerName")] public string SummonerName;
		[JsonProperty("hotStreak")] public bool IsHotStreak;
		[JsonProperty("miniSeries")] public MiniSeriesDTO MiniSeries;

		/// <summary>Winning team on Summoners Rift. First placement in Teamfight Tactics.</summary>
		[JsonProperty("wins")] public int Wins;

		[JsonProperty("veteran")] public bool IsVeteran;

		/// <summary>Losing team on Summoners Rift. Second through eighth placement in Teamfight Tactics.</summary>
		[JsonProperty("losses")] public int Losses;

		[JsonProperty("freshBlood")] public bool IsFreshBlood;
		[JsonProperty("inactive")] public bool Inactive;
		[JsonProperty("rank")] public string Rank;

		/// <summary>Player's summonerId (Encrypted)</summary>
		[JsonProperty("summonerId")] public string SummonerId;

		[JsonProperty("leaguePoints")] public int LeaguePoints;
	}

	public class MiniSeriesDTO
	{
		[JsonProperty("progress")] public string Progress;
		[JsonProperty("losses")] public int Losses;
		[JsonProperty("target")] public int Target;
		[JsonProperty("wins")] public int Wins;
	}

	public class ShardStatus
	{
		[JsonProperty("name")] public string Name;
		[JsonProperty("region_tag")] public string RegionTag;
		[JsonProperty("hostname")] public string Hostname;
		[JsonProperty("services")] public List<Service> ServicesList;
		[JsonProperty("slug")] public string Slug;
		[JsonProperty("locales")] public List<string> LocalesList;
	}

	public class Service
	{
		[JsonProperty("status")] public string Status;
		[JsonProperty("incidents")] public List<Incident> IncidentsList;
		[JsonProperty("name")] public string Name;
		[JsonProperty("slug")] public string Slug;
	}

	public class Incident
	{
		[JsonProperty("active")] public bool IsActive;
		[JsonProperty("created_at")] public string CreatedAt;
		[JsonProperty("id")] public long Id;
		[JsonProperty("updates")] public List<Message> UpdatesList;
	}

	public class Message
	{
		[JsonProperty("severity")] public string Severity;
		[JsonProperty("author")] public string Author;
		[JsonProperty("created_at")] public string CreatedAt;
		[JsonProperty("translations")] public List<Translation> TranslationsList;
		[JsonProperty("updated_at")] public string UpdatedAt;
		[JsonProperty("content")] public string Content;
		[JsonProperty("id")] public string Id;
	}

	public class Translation
	{
		[JsonProperty("locale")] public string Locale;
		[JsonProperty("content")] public string Content;
		[JsonProperty("updated_at")] public string UpdatedAt;
	}

	public class MatchDTO_v5
	{
		/// <summary>Match metadata.</summary>
		[JsonProperty("metadata")] public MetadataDTO Metadata;
		/// <summary>Match info.</summary>
		[JsonProperty("info")] public InfoDTO Info;
	}

	public class MetadataDTO
	{
		/// <summary>Match data version.</summary>
		[JsonProperty("dataVersion")] public string DataVersion;
		/// <summary>Match id.</summary>
		[JsonProperty("matchId")] public string MatchID;
		/// <summary>A list of participant PUUIDs.</summary>
		[JsonProperty("participants")] public List<string> Participants;
	}

	public class InfoDTO
	{
		/// <summary>Unix timestamp for when the game is created on the game server (i.e., the loading screen).</summary>
		[JsonProperty("gameCreation")] public long GameCreation;
		/// <summary>Prior to patch 11.20, this field returns the game length in milliseconds calculated from gameEndTimestamp - gameStartTimestamp. Post patch 11.20, this field returns the max timePlayed of any participant in the game in seconds, which makes the behavior of this field consistent with that of match-v4. The best way to handling the change in this field is to treat the value as milliseconds if the gameEndTimestamp field isn't in the response and to treat the value as seconds if gameEndTimestamp is in the response.</summary>
		[JsonProperty("gameDuration")] public long GameDuration;
		/// <summary>Unix timestamp for when match ends on the game server. This timestamp can occasionally be significantly longer than when the match "ends". The most reliable way of determining the timestamp for the end of the match would be to add the max time played of any participant to the gameStartTimestamp. This field was added to match-v5 in patch 11.20 on Oct 5th, 2021.</summary>
		[JsonProperty("gameEndTimestamp")] public long GameEndTimestamp;
		[JsonProperty("gameId")] public long GameID;
		/// <summary>Refer to the Game Constants documentation.</summary>
		[JsonProperty("gameMode")] public string GameMode;
		[JsonProperty("gameName")] public string GameName;
		/// <summary>Unix timestamp for when match starts on the game server.</summary>
		[JsonProperty("gameStartTimestamp")] public long GameStartTimestamp;
		[JsonProperty("gameType")] public string GameType;
		/// <summary>The first two parts can be used to determine the patch a game was played on.</summary>
		[JsonProperty("gameVersion")] public string GameVersion;
		/// <summary>Refer to the Game Constants documentation.</summary>
		[JsonProperty("mapId")] public int MapID;
		[JsonProperty("participants")] public List<ParticipantDTO> Participants;
		/// <summary>Platform where the match was played.</summary>
		[JsonProperty("platformId")] public string PlatformID;
		/// <summary>Refer to the Game Constants documentation.</summary>
		[JsonProperty("queueId")] public int QueueID;
		[JsonProperty("teams")] public List<TeamDTO> Teams;
		/// <summary>Tournament code used to generate the match. This field was added to match-v5 in patch 11.13 on June 23rd, 2021.</summary>
		[JsonProperty("tournamentCode")] public string TournamentCode;
	}

	public class ParticipantDTO
	{
		// TODO
	}

	public class ParticipantIdentityDTO
	{
		/// <summary>Player information.</summary>
		[JsonProperty("player")] public PlayerDTO Player;

		[JsonProperty("participantId")] public int ParticipantId;
	}

	public class PlayerDTO
	{
		[JsonProperty("currentPlatformId")] public string CurrentPlatformId;
		[JsonProperty("summonerName")] public string SummonerName;
		[JsonProperty("matchHistoryUri")] public string MatchHistoryUri;

		/// <summary>Original platformId.</summary>
		[JsonProperty("platformId")] public string PlatformId;

		/// <summary>Player's current accountId (Encrypted)</summary>
		[JsonProperty("currentAccountId")] public string CurrentAccountId;

		[JsonProperty("profileIcon")] public int ProfileIcon;

		/// <summary>Player's summonerId (Encrypted)</summary>
		[JsonProperty("summonerId")] public string SummonerId;

		/// <summary>Player's original accountId (Encrypted)</summary>
		[JsonProperty("accountId")] public string AccountId;
	}

	public class TeamStatsDTO
	{
		/// <summary>Flag indicating whether or not the team scored the first Dragon kill.</summary>
		[JsonProperty("firstDragon")] public bool HadFirstDragon;

		/// <summary>Flag indicating whether or not the team destroyed the first inhibitor.</summary>
		[JsonProperty("firstInhibitor")] public bool HadFirstInhibitor;

		/// <summary>If match queueId has a draft, contains banned champion data, otherwise empty.</summary>
		[JsonProperty("bans")] public List<TeamBansDTO> BansList;

		/// <summary>Number of times the team killed Baron.</summary>
		[JsonProperty("baronKills")] public int BaronsKilled;

		/// <summary>Flag indicating whether or not the team scored the first Rift Herald kill.</summary>
		[JsonProperty("firstRiftHerald")] public bool HadFirstRiftHerald;

		/// <summary>Flag indicating whether or not the team scored the first Baron kill.</summary>
		[JsonProperty("firstBaron")] public bool HadFirstBaron;

		/// <summary>Number of times the team killed Rift Herald.</summary>
		[JsonProperty("riftHeraldKills")] public int RiftHeraldsKilled;

		/// <summary>Flag indicating whether or not the team scored the first blood.</summary>
		[JsonProperty("firstBlood")] public bool HadFirstBlood;

		/// <summary>100 for blue side. 200 for red side.</summary>
		[JsonProperty("teamId")] public int TeamId;

		/// <summary>Flag indicating whether or not the team destroyed the first tower.</summary>
		[JsonProperty("firstTower")] public bool HadFirstTower;

		/// <summary>Number of times the team killed Vilemaw.</summary>
		[JsonProperty("vilemawKills")] public int VilemawsKilled;

		/// <summary>Number of inhibitors the team destroyed.</summary>
		[JsonProperty("inhibitorKills")] public int InhibitorsDestroyed;

		/// <summary>Number of towers the team destroyed.</summary>
		[JsonProperty("towerKills")] public int TowersDestroyed;

		/// <summary>For Dominion matches, specifies the points the team had at game end.</summary>
		[JsonProperty("dominionVictoryScore")] public int DominionVictoryScore;

		/// <summary>String indicating whether or not the team won. There are only two values visibile in public match history. (Legal values: Fail, Win)</summary>
		[JsonProperty("win")] public string Win;

		/// <summary>Number of times the team killed Dragon.</summary>
		[JsonProperty("dragonKills")] public int DragonsKilled;
	}

	public class TeamBansDTO
	{
		/// <summary>Turn during which the champion was banned.</summary>
		[JsonProperty("pickTurn")] public int PickTurn;

		/// <summary>Banned championId.</summary>
		[JsonProperty("championId")] public int ChampionId;
	}

	public class ParticipantStatsDTO
	{
		[JsonProperty("firstBloodAssist")] public bool HadFirstBloodAssist;
		[JsonProperty("visionScore")] public long VisionScore;
		[JsonProperty("magicDamageDealtToChampions")] public long MagicDamageDealtToChampions;
		[JsonProperty("damageDealtToChampions")] public long DamageDealtToChampions;
		[JsonProperty("totalTimeCrowdControlDealt")] public int TotalTimeCrowdControlDealt;
		[JsonProperty("longestTimeSpentLiving")] public int LongestTimeSpentLiving;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk1Var1")] public int Perk1Var1;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk1Var3")] public int Perk1Var3;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk1Var2")] public int Perk1Var2;

		[JsonProperty("tripleKills")] public int TripleKills;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk3Var3")] public int Perk3Var3;

		[JsonProperty("nodeNeutralizeAssist")] public int NodeNeutralizeAssist;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk3Var2")] public int Perk3Var2;

		[JsonProperty("playerScore9")] public int PlayerScore9;
		[JsonProperty("playerScore8")] public int PlayerScore8;
		[JsonProperty("kills")] public int Kills;
		[JsonProperty("playerScore1")] public int PlayerScore1;
		[JsonProperty("playerScore0")] public int PlayerScore0;
		[JsonProperty("playerScore3")] public int PlayerScore3;
		[JsonProperty("playerScore2")] public int PlayerScore2;
		[JsonProperty("playerScore5")] public int PlayerScore5;
		[JsonProperty("playerScore4")] public int PlayerScore4;
		[JsonProperty("playerScore7")] public int PlayerScore7;
		[JsonProperty("playerScore6")] public int PlayerScore6;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk5Var1")] public int Perk5Var1;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk5Var3")] public int Perk5Var3;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk5Var2")] public int Perk5Var2;

		[JsonProperty("totalScoreRank")] public int TotalScoreRank;
		[JsonProperty("neutralMinionsKilled")] public int NeutralMinionsKilled;
		[JsonProperty("damageDealtToTurrets")] public long DamageDealtToTurrets;
		[JsonProperty("physicalDamageDealtToChampions")] public long PhysicalDamageDealtToChampions;
		[JsonProperty("nodeCapture")] public int NodeCapture;
		[JsonProperty("largestMultiKill")] public int LargestMultiKill;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk2Var2")] public int Perk2Var2;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk2Var3")] public int Perk2Var3;

		[JsonProperty("totalUnitsHealed")] public int TotalUnitsHealed;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk2Var1")] public int Perk2Var1;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk4Var1")] public int Perk4Var1;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk4Var2")] public int Perk4Var2;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk4Var3")] public int Perk4Var3;

		[JsonProperty("wardsKilled")] public int WardsKilled;
		[JsonProperty("largestCriticalStrike")] public int LargestCriticalStrike;
		[JsonProperty("largestKillingSpree")] public int LargestKillingSpree;
		[JsonProperty("quadraKills")] public int QuadraKills;
		[JsonProperty("teamObjective")] public int TeamObjective;
		[JsonProperty("magicDamageDealt")] public long MagicDamageDealt;
		[JsonProperty("item2")] public int Item2;
		[JsonProperty("item3")] public int Item3;
		[JsonProperty("item0")] public int Item0;
		[JsonProperty("neutralMinionsKilledTeamJungle")] public int NeutralMinionsKilledTeamJungle;
		[JsonProperty("item6")] public int Item6;
		[JsonProperty("item4")] public int Item4;
		[JsonProperty("item5")] public int Item5;

		/// <summary>Primary path rune.</summary>
		[JsonProperty("perk1")] public int Perk1;

		/// <summary>Primary path keystone rune.</summary>
		[JsonProperty("perk0")] public int Perk0;

		/// <summary>Primary path rune.</summary>
		[JsonProperty("perk3")] public int Perk3;

		/// <summary>Primary path rune.</summary>
		[JsonProperty("perk2")] public int Perk2;

		/// <summary>Secondary path rune.</summary>
		[JsonProperty("perk5")] public int Perk5;

		/// <summary>Secondary path rune.</summary>
		[JsonProperty("perk4")] public int Perk4;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk3Var1")] public int Perk3Var1;

		[JsonProperty("damageSelfMitigated")] public long SelfMitigatedDamage;
		[JsonProperty("magicalDamageTaken")] public long MagicalDamageTaken;
		[JsonProperty("firstInhibitorKill")] public bool HadFirstInhibitorKill;
		[JsonProperty("trueDamageTaken")] public long TrueDamageTaken;
		[JsonProperty("nodeNeutralize")] public int NodeNeutralize;
		[JsonProperty("assists")] public int Assists;
		[JsonProperty("combatPlayerScore")] public int CombatPlayerScore;

		/// <summary>Primary rune path</summary>
		[JsonProperty("perkPrimaryStyle")] public int PerkPrimaryStyle;

		[JsonProperty("goldSpent")] public int GoldSpent;
		[JsonProperty("trueDamageDealt")] public long TrueDamageDealt;
		[JsonProperty("participantId")] public int ParticipantId;
		[JsonProperty("totalDamageTaken")] public long TotalDamageTaken;
		[JsonProperty("physicalDamageDealt")] public long PhysicalDamageDealt;
		[JsonProperty("sightWardsBoughtInGame")] public int SightWardsBoughtInGame;
		[JsonProperty("totalDamageDealtToChampions")] public long TotalDamageDealtToChampions;
		[JsonProperty("physicalDamageTaken")] public long PhysicalDamageTaken;
		[JsonProperty("totalPlayerScore")] public int TotalPlayerScore;
		[JsonProperty("win")] public bool IsWin;
		[JsonProperty("objectivePlayerScore")] public int ObjectivePlayerScore;
		[JsonProperty("totalDamageDealt")] public long TotalDamageDealt;
		[JsonProperty("item1")] public int Item1;
		[JsonProperty("neutralMinionsKilledEnemyJungle")] public int NeutralMinionsKilledEnemyJungle;
		[JsonProperty("deaths")] public int Deaths;
		[JsonProperty("wardsPlaced")] public int WardsPlaced;

		/// <summary>Secondary rune path</summary>
		[JsonProperty("perkSubStyle")] public int PerkSubStyle;

		[JsonProperty("turretKills")] public int TurretKills;
		[JsonProperty("firstBloodKill")] public bool WasFirstBloodKill;
		[JsonProperty("trueDamageDealtToChampions")] public long TrueDamageDealtToChampions;
		[JsonProperty("goldEarned")] public int GoldEarned;
		[JsonProperty("killingSprees")] public int KillingSprees;
		[JsonProperty("unrealKills")] public int UnrealKills;
		[JsonProperty("altarsCaptured")] public int AltarsCaptured;
		[JsonProperty("firstTowerAssist")] public bool HadFirstTowerAssist;
		[JsonProperty("firstTowerKill")] public bool HadFirstTowerKill;
		[JsonProperty("champLevel")] public int ChampionLevel;
		[JsonProperty("doubleKills")] public int DoubleKills;
		[JsonProperty("nodeCaptureAssist")] public int NodeCaptureAssist;
		[JsonProperty("inhibitorKills")] public int InhibitorKills;
		[JsonProperty("firstInhibitorAssist")] public bool HadFirstInhibitorAssist;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk0Var1")] public int Perk0Var1;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk0Var2")] public int Perk0Var2;

		/// <summary>Post game rune stats.</summary>
		[JsonProperty("perk0Var3")] public int Perk0Var3;

		[JsonProperty("visionWardsBoughtInGame")] public int VisionWardsBoughtInGame;
		[JsonProperty("altarsNeutralized")] public int AltarsNeutralized;
		[JsonProperty("pentaKills")] public int PentaKills;
		[JsonProperty("totalHeal")] public long TotalHeal;
		[JsonProperty("totalMinionsKilled")] public int TotalMinionsKilled;
		[JsonProperty("timeCCingOthers")] public long TimeCCingOthers;
	}

	public class RuneDTO
	{
		[JsonProperty("runeId")] public int RuneId;
		[JsonProperty("rank")] public int Rank;
	}

	public class ParticipantTimelineDTO
	{
		[JsonProperty("lane")] public string Lane;
		[JsonProperty("participantId")] public int ParticipantId;
		[JsonProperty("csDiffPerMinDeltas")] public Dictionary<string, double> CreepsDifferencePerMinuteDeltas;
		[JsonProperty("goldPerMinDeltas")] public Dictionary<string, double> GoldPerMinuteDeltas;
		[JsonProperty("xpDiffPerMinDeltas")] public Dictionary<string, double> XpDifferencePerMinuteDeltas;
		[JsonProperty("creepsPerMinDeltas")] public Dictionary<string, double> CreepsPerMinuteDeltas;
		[JsonProperty("xpPerMinDeltas")] public Dictionary<string, double> XpPerMinuteDeltas;
		[JsonProperty("role")] public string Role;
		[JsonProperty("damageTakenDiffPerMinDeltas")] public Dictionary<string, double> DamageTakenDifferencePerMinuteDeltas;
		[JsonProperty("damageTakenPerMinDeltas")] public Dictionary<string, double> DamageTakenPerMinuteDeltas;
	}

	public class MasteryDTO
	{
		[JsonProperty("masteryId")] public int MasteryId;
		[JsonProperty("rank")] public int Rank;
	}

	public class MatchlistDTO
	{
		[JsonProperty("matches")] public List<MatchReferenceDTO> MatchesList;
		[JsonProperty("totalGames")] public int TotalGames;
		[JsonProperty("startIndex")] public int StartIndex;
		[JsonProperty("endIndex")] public int EndIndex;
	}

	public class MatchReferenceDTO
	{
		[JsonProperty("lane")] public string Lane;
		[JsonProperty("gameId")] public long GameId;
		[JsonProperty("champion")] public int ChampionId;
		[JsonProperty("platformId")] public string PlatformId;
		[JsonProperty("season")] public int Season;
		[JsonProperty("queue")] public int Queue;
		[JsonProperty("role")] public string Role;
		[JsonProperty("timestamp")] public long Timestamp;
	}

	public class MatchTimelineDTO
	{
		[JsonProperty("frames")] public List<MatchFrameDTO> FramesList;
		[JsonProperty("frameInterval")] public long FrameInterval;
	}

	public class MatchFrameDTO
	{
		[JsonProperty("timestamp")] public long timestamp;
		[JsonProperty("participantFrames")] public Dictionary<string, MatchParticipantFrameDTO> ParticipantFrames;
		[JsonProperty("events")] public List<MatchEventDTO> EventsList;
	}

	public class MatchParticipantFrameDTO
	{
		[JsonProperty("totalGold")] public int TotalGold;
		[JsonProperty("teamScore")] public int TeamScore;
		[JsonProperty("participantId")] public int ParticipantId;
		[JsonProperty("level")] public int Level;
		[JsonProperty("currentGold")] public int CurrentGold;
		[JsonProperty("minionsKilled")] public int MinionsKilled;
		[JsonProperty("dominionScore")] public int DominionScore;
		[JsonProperty("position")] public MatchPositionDTO Position;
		[JsonProperty("xp")] public int Xp;
		[JsonProperty("jungleMinionsKilled")] public int JungleMinionsKilled;
	}

	public class MatchPositionDTO
	{
		[JsonProperty("x")] public int X;
		[JsonProperty("y")] public int Y;
	}

	public class MatchEventDTO
	{
		[JsonProperty("eventType")] public string EventType;
		[JsonProperty("towerType")] public string TowerType;
		[JsonProperty("teamId")] public int TeamId;
		[JsonProperty("ascendedType")] public string AscendedType;
		[JsonProperty("killerId")] public int KillerId;
		[JsonProperty("levelUpType")] public string LevelUpType;
		[JsonProperty("pointCaptured")] public string PointCaptured;
		[JsonProperty("assistingParticipants")] public List<int> AssistingParticipantsList;
		[JsonProperty("wardType")] public string WardType;
		[JsonProperty("monsterType")] public string MonsterType;

		/// <summary>(Legal values: CHAMPION_KILL, WARD_PLACED, WARD_KILL, BUILDING_KILL, ELITE_MONSTER_KILL, ITEM_PURCHASED, ITEM_SOLD, ITEM_DESTROYED, ITEM_UNDO, SKILL_LEVEL_UP, ASCENDED_EVENT, CAPTURE_POINT, PORO_KING_SUMMON)</summary>
		[JsonProperty("type")] public string Type;

		[JsonProperty("skillSlot")] public int SkillSlot;
		[JsonProperty("victimId")] public int VictimId;
		[JsonProperty("timestamp")] public long Timestamp;
		[JsonProperty("afterId")] public int AfterId;
		[JsonProperty("monsterSubType")] public string MonsterSubType;
		[JsonProperty("laneType")] public string LaneType;
		[JsonProperty("itemId")] public int ItemId;
		[JsonProperty("participantId")] public int ParticipantId;
		[JsonProperty("buildingType")] public string BuildingType;
		[JsonProperty("creatorId")] public int CreatorId;
		[JsonProperty("position")] public MatchPositionDTO Position;
		[JsonProperty("beforeId")] public int BeforeId;
	}

	public class CurrentGameInfo
	{
		/// <summary>The ID of the game</summary>
		[JsonProperty("gameId")] public long GameId;

		/// <summary>The game start time represented in epoch milliseconds</summary>
		[JsonProperty("gameStartTime")] public long GameStartTime;

		/// <summary>The ID of the platform on which the game is being played</summary>
		[JsonProperty("platformId")] public string PlatformId;

		/// <summary>The game mode</summary>
		[JsonProperty("gameMode")] public string GameMode;

		/// <summary>The ID of the map</summary>
		[JsonProperty("mapId")] public long MapId;

		/// <summary>The game type</summary>
		[JsonProperty("gameType")] public string GameType;

		/// <summary>Banned champion information</summary>
		[JsonProperty("bannedChampions")] public List<BannedChampion> BannedChampionsList;

		/// <summary>The observer information</summary>
		[JsonProperty("observers")] public Observer Observers;

		/// <summary>The participant information</summary>
		[JsonProperty("participants")] public List<CurrentGameParticipant> ParticipantsList;

		/// <summary>The amount of time in seconds that has passed since the game started</summary>
		[JsonProperty("gameLength")] public long GameLength;

		/// <summary>The queue type (queue types are documented on the Game Constants page)</summary>
		[JsonProperty("gameQueueConfigId")] public long GameQueueConfigId;
	}

	public class BannedChampion
	{
		/// <summary>The turn during which the champion was banned</summary>
		[JsonProperty("pickTurn")] public int PickTurn;

		/// <summary>The ID of the banned champion</summary>
		[JsonProperty("championId")] public long ChampionId;

		/// <summary>The ID of the team that banned the champion</summary>
		[JsonProperty("teamId")] public long TeamId;
	}

	public class Observer
	{
		/// <summary>Key used to decrypt the spectator grid game data for playback</summary>
		[JsonProperty("encryptionKey")] public string EncryptionKey;
	}

	public class CurrentGameParticipant
	{
		/// <summary>The ID of the profile icon used by this participant</summary>
		[JsonProperty("profileIconId")] public long ProfileIconId;

		/// <summary>The ID of the champion played by this participant</summary>
		[JsonProperty("championId")] public long ChampionId;

		/// <summary>The summoner name of this participant</summary>
		[JsonProperty("summonerName")] public string SummonerName;

		/// <summary>List of Game Customizations</summary>
		[JsonProperty("gameCustomizationObjects")] public List<GameCustomizationObject> GameCustomizationObjectsList;

		/// <summary>Flag indicating whether or not this participant is a bot</summary>
		[JsonProperty("bot")] public bool IsBot;

		/// <summary>Perks/Runes Reforged Information</summary>
		[JsonProperty("perks")] public Perks Perks;

		/// <summary>The ID of the second summoner spell used by this participant</summary>
		[JsonProperty("spell2Id")] public long Spell2Id;

		/// <summary>The team ID of this participant, indicating the participant's team</summary>
		[JsonProperty("teamId")] public long TeamId;

		/// <summary>The ID of the first summoner spell used by this participant</summary>
		[JsonProperty("spell1Id")] public long Spell1Id;

		/// <summary>The encrypted summoner ID of this participant</summary>
		[JsonProperty("summonerId")] public string SummonerId;
	}

	public class GameCustomizationObject
	{
		/// <summary>Category identifier for Game Customization</summary>
		[JsonProperty("category")] public string Category;

		/// <summary>Game Customization content</summary>
		[JsonProperty("content")] public string Content;
	}

	public class Perks
	{
		/// <summary>Primary runes path</summary>
		[JsonProperty("perkStyle")] public long PerkStyle;

		/// <summary>IDs of the perks/runes assigned.</summary>
		[JsonProperty("perkIds")] public List<long> PerkIdsList;

		/// <summary>Secondary runes path</summary>
		[JsonProperty("perkSubStyle")] public long PerkSubStyle;
	}

	public class FeaturedGames
	{
		/// <summary>The suggested interval to wait before requesting FeaturedGames again</summary>
		[JsonProperty("clientRefreshInterval")] public long ClientRefreshInterval;

		/// <summary>The list of featured games</summary>
		[JsonProperty("gameList")] public List<FeaturedGames> FeaturedGamesList;
	}

	public class SummonerDTO
	{
		/// <summary>ID of the summoner icon associated with the summoner.</summary>
		[JsonProperty("profileIconId")] public string ProfileIconId;

		/// <summary>Summoner name.</summary>
		[JsonProperty("name")] public string Name;

		/// <summary>Encrypted PUUID. Exact length of 78 characters.</summary>
		[JsonProperty("puuid")] public string PUUID;

		/// <summary>Summoner level associated with the summoner.</summary>
		[JsonProperty("summonerLevel")] public string SummonerLevel;

		/// <summary>Date summoner was last modified specified as epoch milliseconds. The following events will update this timestamp: profile icon change, playing the tutorial or advanced tutorial, finishing a game, summoner name change</summary>
		[JsonProperty("revisionDate")] public string RevisionDate;

		/// <summary>Encrypted summoner ID. Max length 63 characters.</summary>
		[JsonProperty("id")] public string Id;

		/// <summary>Encrypted account ID. Max length 56 characters.</summary>
		[JsonProperty("accountId")] public string AccountId;
	}

	public class TournamentCodeParameters
	{
		/// <summary>The spectator type of the game. (Legal values: NONE, LOBBYONLY, ALL)</summary>
		[JsonProperty("spectatorType")] public string SpectatorType;

		/// <summary>The team size of the game. Valid values are 1-5.</summary>
		[JsonProperty("teamSize")] public int TeamSize;

		/// <summary>The pick type of the game. (Legal values: BLIND_PICK, DRAFT_MODE, ALL_RANDOM, TOURNAMENT_DRAFT)</summary>
		[JsonProperty("pickType")] public string PickType;

		/// <summary>Optional list of encrypted summonerIds in order to validate the players eligible to join the lobby. NOTE: We currently do not enforce participants at the team level, but rather the aggregate of teamOne and teamTwo. We may add the ability to enforce at the team level in the future.</summary>
		[JsonProperty("allowedSummonerIds")] public HashSet<string> AllowedSummonerIds;

		/// <summary>The map type of the game. (Legal values: SUMMONERS_RIFT, TWISTED_TREELINE, HOWLING_ABYSS)</summary>
		[JsonProperty("mapType")] public string Map;

		/// <summary>Optional string that may contain any data in any format, if specified at all. Used to denote any custom information about the game.</summary>
		[JsonProperty("metadata")] public string Metadata;
	}

	public class LobbyEventDTOWrapper
	{
		[JsonProperty("eventList")] public List<LobbyEventDTO> EventList;
	}

	public class LobbyEventDTO
	{
		/// <summary>The type of event that was triggered</summary>
		[JsonProperty("eventType")] public string EventType;

		/// <summary>The summonerId that triggered the event (Encrypted)</summary>
		[JsonProperty("summonerId")] public string SummonerId;

		/// <summary>Timestamp from the event</summary>
		[JsonProperty("timestamp")] public string Timestamp;
	}

	public class ProviderRegistrationParameters
	{
		/// <summary>The provider's callback URL to which tournament game results in this region should be posted. The URL must be well-formed, use the http or https protocol, and use the default port for the protocol (http URLs must use port 80, https URLs must use port 443).</summary>
		[JsonProperty("url")] public string Url;

		/// <summary>The region in which the provider will be running tournaments. (Legal values: BR, EUNE, EUW, JP, LAN, LAS, NA, OCE, PBE, RU, TR)</summary>
		[JsonProperty("region")] public string Region;
	}

	public class TournamentRegistrationParameters
	{
		/// <summary>The provider ID to specify the regional registered provider data to associate this tournament.</summary>
		[JsonProperty("providerId")] public int ProviderId;

		/// <summary>The optional name of the tournament.</summary>
		[JsonProperty("name")] public string Name;
	}

	public class ChallengeConfigInfoDTO
	{
		[JsonProperty("id")] public string Id;
		[JsonProperty("localizedNames")] private readonly Dictionary<string, Dictionary<string, string>> LocalizedNames;
		[JsonProperty("state")] public string State;
		[JsonProperty("tracking")] public string Tracking;
		[JsonProperty("startTimestamp")] public long StartTimestamp;
		[JsonProperty("endTimestamp")] public long EndTimestamp;
		[JsonProperty("leaderboard")] public bool Leaderboard;
		[JsonProperty("thresholds")] public Dictionary<string, double> Thresholds;
	}

	public class ApexPlayerInfoDTO
	{
		[JsonProperty("puuid")] public string PUUID;
		[JsonProperty("value")] public double Value;
		[JsonProperty("position")] public int Position;
	}

	public class AccountDTO
	{
		[JsonProperty("puuid")] public string PUUID;
		/// <summary>This field may be excluded from the response if the account doesn't have a gameName.</summary>
		[JsonProperty("gameName")] public string GameName;
		/// <summary>This field may be excluded from the response if the account doesn't have a tagLine.</summary>
		[JsonProperty("tagLine")] public string TagLine;
	}

	public class TeamDTO
	{
		[JsonProperty("id")] public string ID;
		[JsonProperty("tournamentId")] public int TournamentID;
		[JsonProperty("name")] public string Name;
		[JsonProperty("iconId")] public int IconID;
		[JsonProperty("tier")] public int Tier;
		/// <summary>Summoner ID of the team captain.</summary>
		[JsonProperty("captain")] public string Captain;
		[JsonProperty("abbreviation")] public string Abbreviation;
		/// <summary>Team members.</summary>
		[JsonProperty("players")] public List<PlayerDTO> Players;
	}

	public class TournamentDTO
	{
		[JsonProperty("id")] public int ID;
		[JsonProperty("themeId")] public int ThemeID;
		[JsonProperty("nameKey")] public string NameKey;
		[JsonProperty("nameKeySecondary")] public string NameKeySecondary;
		/// <summary>Tournament phase.</summary>
		[JsonProperty("schedule")] public List<TournamentPhaseDTO> Schedule;
	}

	public class TournamentPhaseDTO
	{
		[JsonProperty("id")] public int ID;
		[JsonProperty("registrationTime")] public long RegistrationTime;
		[JsonProperty("startTime")] public long StartTime;
		[JsonProperty("cancelled")] public bool Cancelled;
	}
}
