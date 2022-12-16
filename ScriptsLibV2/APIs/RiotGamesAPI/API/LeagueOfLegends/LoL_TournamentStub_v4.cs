using System.Collections.Generic;

namespace ScriptsLibV2.APIs.RiotGames
{
    /// LoL Tournament Stub - v4
    public partial class RiotGamesAPI
    {
        /// <summary>Create a mock tournament code for the given tournament.</summary>
        /// <param name="parameters">Metadata for the generated code</param>
        public List<string> CreateMockTournamentCodeForGivenTournament(LoLRegion region, TournamentCodeParameters parameters)
        {
            return this.MakePOSTRequest<List<string>>(region, "/lol/tournament-stub/v4/codes", $"{{\"allowedSummonerIds\":\"{{{parameters.AllowedSummonerIds}}},\"mapType\":\"{parameters.Map}\",\"metadata\":\"{parameters.Metadata}\",\"pickType\":\"{parameters.PickType}\",\"spectatorType\":\"{parameters.SpectatorType}\",\"teamSize\":{parameters.TeamSize}}}");
        }

        /// <summary>Gets a mock list of lobby events by tournament code.</summary>
        public LobbyEventDTOWrapper GetMockListOfLobbyEventsByTournamentCode(LoLRegion region, string tournamentCode)
        {
            return this.MakeGETRequest<LobbyEventDTOWrapper>(region, $"/lol/tournament-stub/v4/lobby-events/by-code/{tournamentCode}");
        }

        /// <summary>Creates a mock tournament provider and returns its ID.</summary>
        /// <param name="parameters">The provider definition.</param>
        public int CreateMockTournamentProvider(LoLRegion region, ProviderRegistrationParameters parameters)
        {
            return this.MakePOSTRequest<int>(region, "/lol/tournament-stub/v4/providers", $"{{\"region\":\"{parameters.Region}\",\"url\":\"{parameters.Url}\"}}");
        }

        /// <summary>Creates a mock tournament and returns its ID</summary>
        public int CreateMockTournament(LoLRegion region, TournamentRegistrationParameters parameters)
        {
            return this.MakePOSTRequest<int>(region, "/lol/tournament-stub/v4/tournaments", $"{{\"name\":\"{parameters.Name}\",\"providerId\":{parameters.ProviderId}}}");
        }
    }
}
