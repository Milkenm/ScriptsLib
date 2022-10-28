namespace ScriptsLibR.APIs.RiotAPI
{
    /// LoL Summoner - v4
    public partial class RiotAPI
    {
        /// <summary>Get a summoner by account ID.</summary>
        public SummonerDTO LoL_GetSummonerByAccountId(Region region, string encryptedAccountId)
        {
            return this.MakeGETRequest<SummonerDTO>(region, $"/lol/summoner/v4/summoners/by-account/{encryptedAccountId}");
        }

        /// <summary>Get a summoner by summoner name.</summary>
        /// <param name="summonerName">Summoner Name.</param>
        public SummonerDTO LoL_GetSummonerByName(Region region, string summonerName)
        {
            return this.MakeGETRequest<SummonerDTO>(region, $"/lol/summoner/v4/summoners/by-name/{summonerName}");
        }

        /// <summary>Get a summoner by PUUID.</summary>
        /// <param name="encryptedPUUID">Summoner ID.</param>
        public SummonerDTO LoL_GetSummonerByPuuid(Region region, string encryptedPUUID)
        {
            return this.MakeGETRequest<SummonerDTO>(region, $"/lol/summoner/v4/summoners/by-puuid/{encryptedPUUID}");
        }

        /// <summary>Get a summoner by summoner ID.</summary>
        /// <param name="encryptedSummonerId">Summoner ID.</param>
        public SummonerDTO LoL_GetSummonerBySummonerId(Region region, string encryptedSummonerId)
        {
            return this.MakeGETRequest<SummonerDTO>(region, $"/lol/summoner/v4/summoners/{encryptedSummonerId}");
        }
    }
}
