using ScriptsLibV2.Exceptions;

namespace ScriptsLibV2.APIs.RiotGames
{
	public partial class RiotGamesAPI
	{
		private static RiotGamesAPI Instance;
		public static RiotGamesAPI GetInstance()
		{
			if (Instance == null)
			{
				throw new NotInitializedException(Instance);
			}
			return Instance;
		}

		public static RiotGamesAPI GetInstance(string apiKey)
		{
			if (Instance == null)
			{
				return new RiotGamesAPI(apiKey);
			}
			return Instance;
		}

		public RiotGamesAPI(string apiKey)
		{
			APIKey = apiKey;
			Instance = this;
		}

		public const string RiotAPIOrigin = "https://{0}.api.riotgames.com";

		public string APIKey { get; private set; }

		private string GetAPIParameter()
		{
			return $"?api_key={APIKey}";
		}

		private string GetServerString(LoLRegion region)
		{
			return string.Format(RiotAPIOrigin, region);
		}

		/// <summary>URL is something like: $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}"</summary>
		private T MakeGETRequest<T>(AccountRegion accountRegion, string url)
		{
			return MakeGETRequest<T>(accountRegion.ToString().ToLower(), url);
		}

		/// <summary>URL is something like: $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}"</summary>
		private T MakeGETRequest<T>(LoLRegion region, string url)
		{
			return MakeGETRequest<T>(region.ToString().ToLower(), url);
		}

		/// <summary>URL is something like: $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}"</summary>
		private T MakeGETRequest<T>(string server, string url)
		{
			/*
            string response = GET(this.GetServerString(region) + url + this.GetAPIParameter());
            return JsonConvert.DeserializeObject<T>(response);
            */
			// TODO
			return MakeGETRequest<T>(server, url);
		}

		private T MakePOSTRequest<T>(LoLRegion region, string url, string json)
		{
			/*
            string request = POST(this.GetServerString(region) + "/lol/tournament-stub/v4/codes" + this.GetAPIParameter(), json);
            return JsonConvert.DeserializeObject<T>(request);
            */
			return MakePOSTRequest<T>(region, url, json);
		}
	}
}
