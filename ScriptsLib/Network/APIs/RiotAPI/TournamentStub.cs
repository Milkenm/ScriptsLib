#region Usings
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Newtonsoft.Json;

using static ScriptsLib.Network.Requests;
#endregion Usings



namespace ScriptsLib.Network.APIs
{
	public static partial class RiotAPI
	{
		/// <summary>Create a mock tournament code for the given tournament.</summary>
		/// <param name="params">Metadata for the generated code</param>
		public static List<string> CreateMockTournamentCodeForGivenTournament([Optional] int count, long tournamentId, TournamentCodeParameters parameters)
		{
			string json = $"{{\"allowedSummonerIds\":\"{{{parameters.allowedSummonerIds}}},\"mapType\":\"{parameters.mapType}\",\"metadata\":\"{parameters.mapType}\",\"pickType\":\"{parameters.pickType}\",\"spectatorType\":\"{parameters.spectatorType}\",\"teamSize\":{parameters.teamSize}}}";

			string res = POST(ServerString() + "/lol/tournament-stub/v4/codes" + ApiString(), json);

			return JsonConvert.DeserializeObject<List<string>>(res);
		}

		/// <summary>Gets a mock list of lobby events by tournament code.</summary>
		public static dynamic GetMockListOfLobbyEventsByTournamentCode(string tournamentCode, bool getJsonObject = false)
		{
			string res = GET(ServerString() + $"/lol/tournament-stub/v4/lobby-events/by-code/{tournamentCode}" + ApiString());

			return ReturnResponse<LobbyEventDTOWrapper>(res, getJsonObject);
		}

		/// <summary>Creates a mock tournament provider and returns its ID.</summary>
		/// <param name="params">The provider definition.</param>
		public static int CreateMockTournamentProvider(ProviderRegistrationParameters parameters)
		{
			string json = $"{{\"region\":\"{parameters.region}\",\"url\":\"{parameters.url}\"}}";

			return Convert.ToInt32(POST(ServerString() + "/lol/tournament-stub/v4/providers" + ApiString(), json));
		}

		/// <summary>Creates a mock tournament and returns its ID</summary>
		public static int CreateMockTournament(TournamentRegistrationParameters parameters)
		{
			string json = $"{{\"name\":\"{parameters.name}\",\"providerId\":{parameters.providerId}}}";

			return Convert.ToInt32(POST(ServerString() + "/lol/tournament-stub/v4/tournaments" + ApiString(), json));
		}
	}
}
