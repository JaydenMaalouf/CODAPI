using Newtonsoft.Json;

namespace CallOfDutyAPI.Endpoints.Matches.Items
{
    public class MatchPlayerItem
    {
        internal MatchPlayerItem() { }

        [JsonProperty("uid")]
        [JsonConverter(typeof(UIDConverter))]
        public UID UserId { get; internal set; }

        [JsonProperty]
        public int Prestige { get; internal set; }

        [JsonProperty]
        public int Rank { get; internal set; }

        [JsonProperty]
        public int Team { get; internal set; }

        [JsonProperty]
        public int Position { get; internal set; }

        [JsonProperty]
        public int Kills { get; internal set; }

        [JsonProperty]
        public int Deaths { get; internal set; }

        [JsonProperty]
        public int EKIA { get; internal set; }

        [JsonProperty]
        public int HighestKillStreak { get; internal set; }

        [JsonProperty]
        public int Assists { get; internal set; }

        [JsonProperty]
        public int Headshots { get; internal set; }

        [JsonProperty]
        public int ShotsFired { get; internal set; }

        [JsonProperty]
        public int ShotsLanded { get; internal set; }

        [JsonProperty]
        public int ShotsMissed { get; internal set; }
    }
}
