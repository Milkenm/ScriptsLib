namespace ScriptsLibR.APIs.RiotAPI
{
    /// LoL Third Party Code - v4
    public partial class RiotAPI
    {
        /// <summary>Get third party code for a given summoner ID.</summary>
        public string GetThirdPartyCodeBySummonerId(Region region, string encryptedSummonerId)
        {
            return this.MakeGETRequest<string>(region, $"/lol/platform/v4/third-party-code/by-summoner/{encryptedSummonerId}");
        }
    }
}
