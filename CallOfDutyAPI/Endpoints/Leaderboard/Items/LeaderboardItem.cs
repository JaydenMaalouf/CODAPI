using Newtonsoft.Json;

namespace CallOfDutyAPI.Endpoints.Leaderboard.Items
{
    public class LeaderboardItem
    {
        internal LeaderboardItem() { }

        [JsonProperty]
        public string Username { get; internal set; }

        [JsonProperty]
        public PlatformType Platform { get; internal set; }

        [JsonProperty]
        public LeaderboardLevelItem Level { get; internal set; }

        [JsonProperty]
        public LeaderboardLevelItem Prestige { get; internal set; }

        [JsonProperty]
        public int Kills { get; internal set; }

        [JsonProperty]
        public int Deaths { get; internal set; }

        [JsonProperty]
        public int EKIA { get; internal set; }

        [JsonProperty]
        public int Wins { get; internal set; }

        [JsonProperty]
        public int Losses { get; internal set; }

        [JsonProperty]
        public int GamesPlayed { get; internal set; }

        [JsonProperty]
        public int TimePlayed { get; internal set; }
    }

    public class LeaderboardLevelItem
    {
        internal LeaderboardLevelItem() { }

        [JsonProperty]
        public int Id { get; internal set; }

        [JsonProperty]
        public string Image { get; internal set; }
    }
}
