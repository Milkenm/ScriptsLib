using System.Collections.Generic;

namespace ScriptsLibR.APIs.RiotAPI
{
    /// LoL Tournament Stub - v4
    public partial class RiotAPI
    {
        /// <summary>Create a mock tournament code for the given tournament.</summary>
        /// <param name="parameters">Metadata for the generated code</param>
        public List<string> CreateMockTournamentCodeForGivenTournament(Region region, TournamentCodeParameters parameters)
        {
            return this.MakePOSTRequest<List<string>>(region, "/lol/tournament-stub/v4/codes", $"{{\"allowedSummonerIds\":\"{{{parameters.AllowedSummonerIds}}},\"mapType\":\"{parameters.Map}\",\"metadata\":\"{parameters.Metadata}\",\"pickType\":\"{parameters.PickType}\",\"spectatorType\":\"{parameters.SpectatorType}\",\"teamSize\":{parameters.TeamSize}}}");
        }

        /// <summary>Gets a mock list of lobby events by tournament code.</summary>
        public LobbyEventDTOWrapper GetMockListOfLobbyEventsByTournamentCode(Region region, string tournamentCode)
        {
            return this.MakeGETRequest<LobbyEventDTOWrapper>(region, $"/lol/tournament-stub/v4/lobby-events/by-code/{tournamentCode}");
        }

        /// <summary>Creates a mock tournament provider and returns its ID.</summary>
        /// <param name="parameters">The provider definition.</param>
        public int CreateMockTournamentProvider(Region region, ProviderRegistrationParameters parameters)
        {
            return this.MakePOSTRequest<int>(region, "/lol/tournament-stub/v4/providers", $"{{\"region\":\"{parameters.Region}\",\"url\":\"{parameters.Url}\"}}");
        }

        /// <summary>Creates a mock tournament and returns its ID</summary>
        public int CreateMockTournament(Region region, TournamentRegistrationParameters parameters)
        {
            return this.MakePOSTRequest<int>(region, "/lol/tournament-stub/v4/tournaments", $"{{\"name\":\"{parameters.Name}\",\"providerId\":{parameters.ProviderId}}}");
        }
    }
}
