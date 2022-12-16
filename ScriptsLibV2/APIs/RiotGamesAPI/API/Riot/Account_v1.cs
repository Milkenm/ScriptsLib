using Newtonsoft.Json;

namespace ScriptsLibV2.APIs.RiotGames
{
	public partial class RiotGamesAPI
	{
		/// <summary>Get account by puuid.</summary>
		public AccountDTO Riot_GetAccountByPuuid(LoLRegion region, string puuid)
		{
			return MakeGETRequest<AccountDTO>(region, $"/riot/account/v1/accounts/by-puuid/{puuid}");
		}

		/// <summary>Get account by riot id.</summary>
		public AccountDTO Riot_GetAccountByRiotId(LoLRegion region, string gameName, string tagLine)
		{
			return MakeGETRequest<AccountDTO>(region, $"/riot/account/v1/accounts/by-riot-id/{gameName}/{tagLine}");
		}

		/// <summary>Get account by access token.</summary>
		public AccountDTO Riot_GetAccountByAccessToken(LoLRegion region)
		{
			return MakeGETRequest<AccountDTO>(region, "/riot/account/v1/accounts/me");
		}

		/// <summary>Get active shard for a player.</summary>
		public ActiveShardDTO Riot_GetPlayerActiveShard(AccountRegion region, GameAccount game, string puuid)
		{
			return MakeGETRequest<ActiveShardDTO>(region, $"/riot/account/v1/active-shards/by-game/{game.ToString().ToLower()}/by-puuid/{puuid}");
		}
	}

	public class AccountDTO
	{
		[JsonProperty("puuid")] public string PUUID;
		/// <summary>This field may be excluded from the response if the account doesn't have a gameName.</summary>
		[JsonProperty("gameName")] public string GameName;
		/// <summary>This field may be excluded from the response if the account doesn't have a tagLine.</summary>
		[JsonProperty("tagLine")] public string TagLine;
	}

	public class ActiveShardDTO
	{
		[JsonProperty("puuid")] public string PUUID;
		[JsonProperty("game")] public string Game;
		[JsonProperty("activeShard")] public string ActiveShard;
	}
}
