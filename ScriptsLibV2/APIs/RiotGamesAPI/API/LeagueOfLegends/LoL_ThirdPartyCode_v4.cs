namespace ScriptsLibV2.APIs.RiotGames
{
    /// LoL Third Party Code - v4
    public partial class RiotGamesAPI
    {
        /// <summary>Get third party code for a given summoner ID.</summary>
        public string GetThirdPartyCodeBySummonerId(LoLRegion region, string encryptedSummonerId)
        {
            return this.MakeGETRequest<string>(region, $"/lol/platform/v4/third-party-code/by-summoner/{encryptedSummonerId}");
        }
    }
}
