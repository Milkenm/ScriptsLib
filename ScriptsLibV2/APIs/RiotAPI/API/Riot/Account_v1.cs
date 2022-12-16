namespace ScriptsLibV2.APIs
{
	public partial class RiotAPI
	{
		/// <summary>Get account by puuid.</summary>
		public AccountDTO Riot_GetAccountByPuuid(Region region, string puuid)
		{
			return MakeGETRequest<AccountDTO>(region, $"/riot/account/v1/accounts/by-puuid/{puuid}");
		}

		/// <summary>Get account by riot id.</summary>
		public AccountDTO Riot_GetAccountByRiotId(Region region, string gameName, string tagLine)
		{
			return MakeGETRequest<AccountDTO>(region, $"/riot/account/v1/accounts/by-riot-id/{gameName}/{tagLine}");
		}

		/// <summary>Get account by access token.</summary>
		public AccountDTO Riot_GetAccountByAccessToken(Region region)
		{
			return MakeGETRequest<AccountDTO>(region, "/riot/account/v1/accounts/me");
		}

		/// <summary>Get active shard for a player.</summary>
		public AccountDTO Riot_GetPlayerActiveShard(Region region, string game, string puuid)
		{
			return MakeGETRequest<AccountDTO>(region, $"/riot/account/v1/active-shards/by-game/{game}/by-puuid/{puuid}");
		}
	}
}
