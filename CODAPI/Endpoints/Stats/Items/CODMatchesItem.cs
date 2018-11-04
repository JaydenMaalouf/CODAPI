using Newtonsoft.Json;

namespace CallOfDutyAPI.Endpoints.Stats.Items
{
    public class CODMatchesItem
    {
        internal CODMatchesItem() { }

        [JsonProperty]
        public string Identifier { get; internal set; }

        [JsonProperty]
        public int Kills { get; internal set; }

        [JsonProperty]
        public int Deaths { get; internal set; }

        [JsonProperty]
        public int EKIA { get; internal set; }

        [JsonProperty]
        public int GamesPlayed { get; internal set; }

        [JsonProperty]
        public int Wins { get; internal set; }

        [JsonProperty]
        public int Losses { get; internal set; }

        [JsonProperty]
        public int TotalShots { get; internal set; }

        [JsonProperty]
        public int Captures { get; internal set; }

        [JsonProperty]
        public int Defends { get; internal set; }

        [JsonProperty]
        public int CareerScore { get; internal set; }

        [JsonProperty]
        public int TimePlayed { get; internal set; }

        [JsonProperty]
        public int RankXP { get; internal set; }

        [JsonProperty]
        public int Time { get; internal set; }
    }
}
