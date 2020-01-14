#region Usings
using System.Collections.Generic;
#endregion Usings

	

namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		/// <summary>This object contains single Champion Mastery information for player and champion combination.</summary>
		public class ChampionMasteryDTO
		{
			/// <summary>Is chest granted for this champion or not in current season.</summary>
			public bool chestGranted;
			/// <summary>Champion level for specified player and champion combination.</summary>
			public int championLevel;
			/// <summary>Total number of champion points for this player and champion combination - they are used to determine championLevel.</summary>
			public int championPoints;
			/// <summary>Champion ID for this entry.</summary>
			public long championId;
			/// <summary>Number of points needed to achieve next level. Zero if player reached maximum champion level for this champion.</summary>
			public long championPointsUntilNextLevel;
			/// <summary>Last time this champion was played by this player - in Unix milliseconds time format.</summary>
			public long lastPlayTime;
			/// <summary>The token earned for this champion to levelup.</summary>
			public int tokensEarned;
			/// <summary>Number of points earned since current level has been achieved.</summary>
			public long championPointsSinceLastLevel;
			/// <summary>Summoner ID for this entry. (Encrypted)</summary>
			public string summonerId;
		}





		public class ChampionInfo
		{
			public List<int> freeChampionIdsForNewPlayers;
			public List<int> freeChampionIds;
			public int maxNewPlayerLevel;
		}





		public class LeagueEntryDTO
		{
			public string queueType;
			public string summonerName;
			public bool hotStreak;
			public MiniSeriesDTO miniSeries;
			/// <summary>Winning team on Summoners Rift. First placement in Teamfight Tactics.</summary>
			public int wins;
			public bool veteran;
			/// <summary>Losing team on Summoners Rift. Second through eighth placement in Teamfight Tactics.</summary>
			public int losses;
			public string rank;
			public string leagueId;
			public bool inactive;
			public bool freshBlood;
			public string tier;
			/// <summary>Player's summonerId (Encrypted)</summary>
			public string summonerId;
			public int leaguePoints;
		}



		public class LeagueListDTO
		{
			public string leagueId;
			public string tier;
			public List<LeagueItemDTO> entries;
			public string queue;
			public string name;
		}

		public class LeagueItemDTO
		{
			public string summonerName;
			public bool hotStreak;
			public MiniSeriesDTO miniSeries;
			/// <summary>Winning team on Summoners Rift. First placement in Teamfight Tactics.</summary>
			public int wins;
			public bool veteran;
			/// <summary>Losing team on Summoners Rift. Second through eighth placement in Teamfight Tactics.</summary>
			public int losses;
			public bool freshBlood;
			public bool inactive;
			public string rank;
			/// <summary>Player's summonerId (Encrypted)</summary>
			public string summonerId;
			public int leaguePoints;
		}




		public class MiniSeriesDTO
		{
			public string progress;
			public int losses;
			public int target;
			public int wins;
		}

		public class ShardStatus
		{
			public string name;
			public string region_tag;
			public string hostname;
			public List<Service> services;
			public string slug;
			public List<string> locales;
		}

		public class Service
		{
			public string status;
			public List<Incident> incidents;
			public string name;
			public string slug;
		}

		public class Incident
		{
			public bool active;
			public string created_at;
			public long id;
			public List<Message> updates;
		}

		public class Message
		{
			public string severity;
			public string author;
			public string created_at;
			public List<Translation> translations;
			public string updated_at;
			public string content;
			public string id;
		}

		public class Translation
		{
			public string locale;
			public string content;
			public string updated_at;
		}
		public class MatchDTO
		{
			/// <summary>Please refer to the Game Constants documentation.</summary>
			public int sessionId;
			/// <summary>Please refer to the Game Constants documentation.</summary>
			public int queueId;
			public long gameId;
			/// <summary>Participant identity information.</summary>
			public List<ParticipantIdentityDTO> participantIdentities;
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
			public List<TeamStatsDTO> teams;
			/// <summary>Participant information.</summary>
			public List<ParticipantDTO> participants;
			/// <summary>Match duration in seconds.</summary>
			public long gameDuration;
			/// <summary>Designates the timestamp when champion select ended and the loading screen appeared, NOT when the game timer was at 0:00.</summary>
			public long gameCreation;
		}

		public class ParticipantIdentityDTO
		{
			/// <summary>Player information.</summary>
			public PlayerDTO player;
			public int participantId;
		}

		public class PlayerDTO
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

		public class TeamStatsDTO
		{
			/// <summary>Flag indicating whether or not the team scored the first Dragon kill.</summary>
			public bool firstDragon;
			/// <summary>Flag indicating whether or not the team destroyed the first inhibitor.</summary>
			public bool firstInhibitor;
			/// <summary>If match queueId has a draft, contains banned champion data, otherwise empty.</summary>
			public List<TeamBansDTO> bans;
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

		public class TeamBansDTO
		{
			/// <summary>Turn during which the champion was banned.</summary>
			public int pickTurn;
			/// <summary>Banned championId.</summary>
			public int championId;
		}

		public class ParticipantDTO
		{
			/// <summary>Participant statistics.</summary>
			public ParticipantStatsDTO stats;
			public int participantId;
			/// <summary>List of legacy Rune information. Not included for matches played with Runes Reforged.</summary>
			public List<RuneDTO> runes;
			/// <summary>Participant timeline data.</summary>
			public ParticipantTimelineDTO timeline;
			/// <summary>100 for blue side. 200 for red side.</summary>
			public int teamId;
			/// <summary>Second Summoner Spell id.</summary>
			public int spell2Id;
			/// <summary>List of legacy Mastery information. Not included for matches played with Runes Reforged.</summary>
			public List<MasteryDTO> masteries;
			/// <summary>Highest ranked tier achieved for the previous season in a specific subset of queueIds, if any, otherwise null. Used to display border in game loading screen. Please refer to the Ranked Info documentation. (Legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE, UNRANKED)</summary>
			public string highestAchievedSeasonTier;
			/// <summary>First Summoner Spell id.</summary>
			public int spell1Id;
			public int championId;
		}

		public class ParticipantStatsDTO
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

		public class RuneDTO
		{
			public int runeId;
			public int rank;
		}

		public class ParticipantTimelineDTO
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

		public class MasteryDTO
		{
			public int masteryId;
			public int rank;
		}

		public class MatchlistDTO
		{
			public List<MatchReferenceDTO> matches;
			public int totalGames;
			public int startIndex;
			public int endIndex;
		}

		public class MatchReferenceDTO
		{
			public string lane;
			public long gameId;
			public int champion;
			public string platformId;
			public int season;
			public int queue;
			public string role;
			public long timestamp;
		}

		public class MatchTimelineDTO
		{
			public List<MatchFrameDTO> frames;
			public long frameInterval;
		}

		public class MatchFrameDTO
		{
			public long timestamp;
			public Dictionary<string, MatchParticipantFrameDTO> participantFrames;
			public List<MatchEventDTO> events;
		}

		public class MatchParticipantFrameDTO
		{
			public int totalGold;
			public int teamScore;
			public int participantId;
			public int level;
			public int currentGold;
			public int minionsKilled;
			public int dominionScore;
			public MatchPositionDTO position;
			public int xp;
			public int jungleMinionsKilled;
		}

		public class MatchPositionDTO
		{
			public int x;
			public int y;
		}

		public class MatchEventDTO
		{
			public string eventType;
			public string towerType;
			public int teamId;
			public string ascendedType;
			public int killerId;
			public string levelUpType;
			public string pointCaptured;
			public List<int> assistingParticipants;
			public string wardType;
			public string monsterType;
			/// <summary>(Legal values: CHAMPION_KILL, WARD_PLACED, WARD_KILL, BUILDING_KILL, ELITE_MONSTER_KILL, ITEM_PURCHASED, ITEM_SOLD, ITEM_DESTROYED, ITEM_UNDO, SKILL_LEVEL_UP, ASCENDED_EVENT, CAPTURE_POINT, PORO_KING_SUMMON)</summary>
			public string type;
			public int skillSlot;
			public int victimId;
			public long timestamp;
			public int afterId;
			public string monsterSubType;
			public string laneType;
			public int itemId;
			public int participantId;
			public string buildingType;
			public int creatorId;
			public MatchPositionDTO position;
			public int beforeId;
		}


		public class CurrentGameInfo
		{
			/// <summary>The ID of the game</summary>
			public long gameId;
			/// <summary>The game start time represented in epoch milliseconds</summary>
			public long gameStartTime;
			/// <summary>The ID of the platform on which the game is being played</summary>
			public string platformId;
			/// <summary>The game mode</summary>
			public string gameMode;
			/// <summary>The ID of the map</summary>
			public long mapId;
			/// <summary>The game type</summary>
			public string gameType;
			/// <summary>Banned champion information</summary>
			public List<BannedChampion> bannedChampions;
			/// <summary>The observer information</summary>
			public Observer observers;
			/// <summary>The participant information</summary>
			public List<CurrentGameParticipant> participants;
			/// <summary>The amount of time in seconds that has passed since the game started</summary>
			public long gameLength;
			/// <summary>The queue type (queue types are documented on the Game Constants page)</summary>
			public long gameQueueConfigId;
		}

		public class BannedChampion
		{
			/// <summary>The turn during which the champion was banned</summary>
			public int pickTurn;
			/// <summary>The ID of the banned champion</summary>
			public long championId;
			/// <summary>The ID of the team that banned the champion</summary>
			public long teamId;
		}

		public class Observer
		{
			/// <summary>Key used to decrypt the spectator grid game data for playback</summary>
			public string encryptionKey;
		}

		public class CurrentGameParticipant
		{
			/// <summary>The ID of the profile icon used by this participant</summary>
			public long profileIconId;
			/// <summary>The ID of the champion played by this participant</summary>
			public long championId;
			/// <summary>The summoner name of this participant</summary>
			public string summonerName;
			/// <summary>List of Game Customizations</summary>
			public List<GameCustomizationObject> gameCustomizationObjects;
			/// <summary>Flag indicating whether or not this participant is a bot</summary>
			public bool bot;
			/// <summary>Perks/Runes Reforged Information</summary>
			public Perks perks;
			/// <summary>The ID of the second summoner spell used by this participant</summary>
			public long spell2Id;
			/// <summary>The team ID of this participant, indicating the participant's team</summary>
			public long teamId;
			/// <summary>The ID of the first summoner spell used by this participant</summary>
			public long spell1Id;
			/// <summary>The encrypted summoner ID of this participant</summary>
			public string summonerId;
		}

		public class GameCustomizationObject
		{
			/// <summary>Category identifier for Game Customization</summary>
			public string category;
			/// <summary>Game Customization content</summary>
			public string content;
		}

		public class Perks
		{
			/// <summary>Primary runes path</summary>
			public long perkStyle;
			/// <summary>IDs of the perks/runes assigned.</summary>
			public List<long> perkIds;
			/// <summary>Secondary runes path</summary>
			public long perkSubStyle;
		}

		public class FeaturedGames
		{
			/// <summary>The suggested interval to wait before requesting FeaturedGames again</summary>
			public long clientRefreshInterval;
			/// <summary>The list of featured games</summary>
			public List<FeaturedGames> gameList;
		}

		public class SummonerDTO
		{
			/// <summary>ID of the summoner icon associated with the summoner.</summary>
			public string profileIconId;
			/// <summary>Summoner name.</summary>
			public string name;
			/// <summary>Encrypted PUUID. Exact length of 78 characters.</summary>
			public string puuid;
			/// <summary>Summoner level associated with the summoner.</summary>
			public string summonerLevel;
			/// <summary>Date summoner was last modified specified as epoch milliseconds. The following events will update this timestamp: profile icon change, playing the tutorial or advanced tutorial, finishing a game, summoner name change</summary>
			public string revisionDate;
			/// <summary>Encrypted summoner ID. Max length 63 characters.</summary>
			public string id;
			/// <summary>Encrypted account ID. Max length 56 characters.</summary>
			public string accountId;
		}
	}
}
