using System.Collections.Generic;

namespace ScriptsLibV2.APIs.RiotGames
{
    /// LoL Champion Mastery - v4
    public partial class RiotGamesAPI
    {
        /// <summary>Get all champion mastery entries sorted by number of champion points descending.</summary>
        /// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
        public List<ChampionMasteryDTO> LoL_GetChampionMasteryList(LoLRegion region, string encryptedSummonerId)
        {
            return this.MakeGETRequest<List<ChampionMasteryDTO>>(region, $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}");
        }

        /// <summary>Get a champion mastery by player ID and champion ID.</summary>
        /// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
        /// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
        public ChampionMasteryDTO LoL_GetMasteryByChampion(LoLRegion region, string encryptedSummonerId, long championId)
        {
            return this.MakeGETRequest<ChampionMasteryDTO>(region, $"/lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}/by-champion/{championId}");
        }

        /// <summary>Get a player's total champion mastery score, which is the sum of individual champion mastery levels.</summary>
        /// <param name="encryptedSummonerId">Summoner ID associated with the player.</param>
        public int LoL_GetTotalMasteryScore(LoLRegion region, string encryptedSummonerId)
        {
            return this.MakeGETRequest<int>(region, $"/lol/champion-mastery/v4/scores/by-summoner/{encryptedSummonerId}");
        }
    }
}
