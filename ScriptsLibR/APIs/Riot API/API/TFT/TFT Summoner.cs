namespace ScriptsLibR.APIs.RiotAPI
{
    /// TFT Summoner - v1
    public partial class RiotAPI
    {
        /// <summary>Get a summoner by account ID.</summary>
        public SummonerDTO GetSummonerByAccountId(Region region, string encryptedAccountId)
        {
            return this.MakeGETRequest<SummonerDTO>(region, $"/tft/summoner/v1/summoners/by-account/{encryptedAccountId}");
        }

        /// <summary>Get a summoner by summoner name.</summary>
        /// <param name="summonerName">Summoner Name.</param>
        public SummonerDTO GetSummonerByName(Region region, string summonerName)
        {
            return this.MakeGETRequest<SummonerDTO>(region, $"/tft/summoner/v1/summoners/by-name/{summonerName}");
        }

        /// <summary>Get a summoner by PUUID.</summary>
        /// <param name="encryptedPUUID">Summoner ID.</param>
        public SummonerDTO GetSummonerByPuuid(Region region, string encryptedPUUID)
        {
            return this.MakeGETRequest<SummonerDTO>(region, $"/tft/summoner/v1/summoners/by-puuid/{encryptedPUUID}");
        }

        /// <summary>Get a summoner by summoner ID.</summary>
        /// <param name="encryptedSummonerId">Summoner ID.</param>
        public SummonerDTO GetSummonerBySummonerId(Region region, string encryptedSummonerId)
        {
            return this.MakeGETRequest<SummonerDTO>(region, $"/tft/summoner/v1/summoners/{encryptedSummonerId}");
        }
    }
}
