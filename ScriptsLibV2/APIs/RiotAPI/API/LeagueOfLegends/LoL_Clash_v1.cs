using System.Collections.Generic;

namespace ScriptsLibV2.APIs
{
	public partial class RiotAPI
	{
		/// <summary>Get players by summoner ID.</summary>
		public List<PlayerDTO> LoL_GetClashPlayersBySummnerId(Region region, string summonerId)
		{
			return MakeGETRequest<List<PlayerDTO>>(region, $"/lol/clash/v1/players/by-summoner/{summonerId}");
		}

		/// <summary>Get team by ID.</summary>
		public TournamentTeamDTO LoL_GetTeamById(Region region, string teamId)
		{
			return MakeGETRequest<TournamentTeamDTO>(region, $"/lol/clash/v1/teams/{teamId}");
		}

		/// <summary>Get all active or upcoming tournaments.</summary>
		public List<TournamentDTO> LoL_GetTournaments(Region region)
		{
			return MakeGETRequest<List<TournamentDTO>>(region, "/lol/clash/v1/tournaments");
		}

		/// <summary>Get tournament by team ID.</summary>
		public TournamentDTO LoL_GetTournamentByTeamId(Region region, string teamId)
		{
			return MakeGETRequest<TournamentDTO>(region, $"/lol/clash/v1/tournaments/by-team/{teamId}");
		}

		/// <summary>Get tournament by ID.</summary>
		public TournamentDTO LoL_GetTournamentById(Region region, int tournamentId)
		{
			return MakeGETRequest<TournamentDTO>(region, $"/lol/clash/v1/tournaments/{tournamentId}");
		}
	}
}
