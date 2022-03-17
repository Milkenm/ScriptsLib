using Newtonsoft.Json;

using ScriptsLibR.Exceptions;

namespace ScriptsLibR.APIs.RiotAPI
{
    public partial class RiotAPI
    {
        private static RiotAPI Instance;
        public RiotAPI GetInstance()
        {
            if (Instance == null)
            {
                throw new NotInitializedException(this);
            }
            return Instance;
        }

        public RiotAPI(string apiKey)
        {
            this.APIKey = apiKey;
            Instance = this;
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
        private T MakeGETRequest<T>(Region region, string url)
        {
            string response = GET(this.GetServerString(region) + url + this.GetAPIParameter());
            return JsonConvert.DeserializeObject<T>(response);
        }

        private T MakePOSTRequest<T>(Region region, string url, string? json)
        {
            string request = POST(this.GetServerString(region) + "/lol/tournament-stub/v4/codes" + this.GetAPIParameter(), json);
            return JsonConvert.DeserializeObject<T>(request);
        }
    }
}
