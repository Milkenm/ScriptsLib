namespace ScriptsLibR.APIs.RiotAPI
{
    public partial class RiotAPI
    {
        public RiotAPI(string apiKey)
        {
            this.APIKey = apiKey;
        }

        public const string RiotAPIOrigin = "https://{0}.api.riotgames.com";

        public string APIKey { get; private set; }

        private string GetAPIParameter()
        {
            return $"?api_key={this.APIKey}";
        }

        private string GetServerString(Region region)
        {
            return string.Format(RiotAPIOrigin, region);
        }

        /// <summary>Url is something like: $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}"</summary>
        private string MakeRequest(Region region, string url)
        {
            return GET(this.GetServerString(region) + url + this.GetAPIParameter());
        }
    }
}
