using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using static ScriptsLib.Network.Requests;

namespace ScriptsLib.APIs
{
	public partial class LeagueOfLegendsAPI
	{
		public class TournamentStub // v4
		{
			/// <summary>Create a mock tournament code for the given tournament.</summary>
			/// <param name="parameters">Metadata for the generated code</param>
			public List<string> CreateMockTournamentCodeForGivenTournament(Regions region, TournamentCodeParameters parameters)
			{
				string json = $"{{\"allowedSummonerIds\":\"{{{parameters.allowedSummonerIds}}},\"mapType\":\"{parameters.mapType}\",\"metadata\":\"{parameters.mapType}\",\"pickType\":\"{parameters.pickType}\",\"spectatorType\":\"{parameters.spectatorType}\",\"teamSize\":{parameters.teamSize}}}";

				string request = POST(ServerString(region) + "/lol/tournament-stub/v4/codes" + ApiString(), json);

				return JsonConvert.DeserializeObject<List<string>>(request);
			}

			/// <summary>Gets a mock list of lobby events by tournament code.</summary>
			public LobbyEventDTOWrapper GetMockListOfLobbyEventsByTournamentCode(Regions region, string tournamentCode)
			{
				string request = GET(ServerString(region) + $"/lol/tournament-stub/v4/lobby-events/by-code/{tournamentCode}" + ApiString());
				return JsonConvert.DeserializeObject<LobbyEventDTOWrapper>(request);
			}

			/// <summary>Creates a mock tournament provider and returns its ID.</summary>
			/// <param name="parameters">The provider definition.</param>
			public int CreateMockTournamentProvider(Regions region, ProviderRegistrationParameters parameters)
			{
				string json = $"{{\"region\":\"{parameters.region}\",\"url\":\"{parameters.url}\"}}";
				return Convert.ToInt32(POST(ServerString(region) + "/lol/tournament-stub/v4/providers" + ApiString(), json));
			}

			/// <summary>Creates a mock tournament and returns its ID</summary>
			public int CreateMockTournament(Regions region, TournamentRegistrationParameters parameters)
			{
				string json = $"{{\"name\":\"{parameters.name}\",\"providerId\":{parameters.providerId}}}";
				return Convert.ToInt32(POST(ServerString(region) + "/lol/tournament-stub/v4/tournaments" + ApiString(), json));
			}
		}
	}
}
