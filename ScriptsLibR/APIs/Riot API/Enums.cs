namespace ScriptsLibR.APIs.RiotAPI
{
    public partial class RiotAPI
    {
        public enum Region
        {
            RU,
            KR,
            BR1,
            OC1,
            JP1,
            NA1,
            EUN1,
            EUW1,
            TR1,
            LA1,
            LA2,
        }

        public enum Queue
        {
            RANKED_SOLO_5x5,
            RANKED_TFT,
            RANKED_FLEX_SR,
            RANKED_FLEX_TT,
        }

        public enum Tier
        {
            IRON,
            BRONZE,
            SILVER,
            GOLD,
            PLATINUM,
            DIAMOND,
            MASTER,
            GRANDMASTER,
            CHALLENGER,
        }

        public enum Division
        {
            I,
            II,
            III,
            IV,
        }

        public enum ResponseCode
        {
            BadRequest = 400,
            Unauthorized = 401,
            Forbidden = 403,
            DataNotFound = 404,
            MethodNotAllowed = 405,
            UnsupportedMediaType = 415,
            RateLimitExceeded = 429,
            InternalServerError = 500,
            BadGateway = 502,
            ServiceUnavailable = 503,
            GatewayTimeout = 504,
        }

        public enum Event
        {
            CHAMPION_KILL,
            WARD_PLACED,
            WARD_KILL,
            BUILDING_KILL,
            ELITE_MONSTER_KILL,
            ITEM_PURCHASED,
            ITEM_SOLD,
            ITEM_DESTROYED,
            ITEM_UNDO,
            SKILL_LEVEL_UP,
            ASCENDED_EVENT,
            CAPTURE_POINT,
            PORO_KING_SUMMON,
        }

        public enum SpectatorType
        {
            NONE,
            LOBBYONLY,
            ALL,
        }

        public enum PickType
        {
            BLIND_PICK,
            DRAFT_MODE,
            ALL_RANDOM,
            TOURNAMENT_DRAFT,
        }

        public enum Map
        {
            SUMMONERS_RIFT,
            TWISTED_TREELINE,
            HOWLING_ABYSS,
        }
    }
}
