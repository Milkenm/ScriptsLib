using System.Collections.Generic;

namespace ScriptsLibV2.APIs.RiotGames
{
	public partial class RiotGamesAPI
	{
		/// <summary>Get players by summoner ID.</summary>
		public List<PlayerDTO> LoL_GetClashPlayersBySummnerId(LoLRegion region, string summonerId)
		{
			return MakeGETRequest<List<PlayerDTO>>(region, $"/lol/clash/v1/players/by-summoner/{summonerId}");
		}

		/// <summary>Get team by ID.</summary>
		public TournamentTeamDTO LoL_GetTeamById(LoLRegion region, string teamId)
		{
			return MakeGETRequest<TournamentTeamDTO>(region, $"/lol/clash/v1/teams/{teamId}");
		}

		/// <summary>Get all active or upcoming tournaments.</summary>
		public List<TournamentDTO> LoL_GetTournaments(LoLRegion region)
		{
			return MakeGETRequest<List<TournamentDTO>>(region, "/lol/clash/v1/tournaments");
		}

		/// <summary>Get tournament by team ID.</summary>
		public TournamentDTO LoL_GetTournamentByTeamId(LoLRegion region, string teamId)
		{
			return MakeGETRequest<TournamentDTO>(region, $"/lol/clash/v1/tournaments/by-team/{teamId}");
		}

		/// <summary>Get tournament by ID.</summary>
		public TournamentDTO LoL_GetTournamentById(LoLRegion region, int tournamentId)
		{
			return MakeGETRequest<TournamentDTO>(region, $"/lol/clash/v1/tournaments/{tournamentId}");
		}
	}
}
