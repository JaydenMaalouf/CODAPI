using Newtonsoft.Json;

namespace CallOfDutyAPI.Endpoints.Stats.Items
{
    public class CODStatsItem
    {
        internal CODStatsItem() { }

        [JsonProperty]
        public int Level { get; internal set; }

        [JsonProperty]
        public bool MaxLevel { get; internal set; }

        [JsonProperty]
        public int Prestige { get; internal set; }

        [JsonProperty]
        public int PrestigeId { get; internal set; }

        [JsonProperty]
        public bool MaxPrestige { get; internal set; }

        [JsonProperty]
        public int Kills { get; internal set; }

        [JsonProperty]
        public int KillsConfirmed { get; internal set; }

        [JsonProperty]
        public int Deaths { get; internal set; }

        [JsonProperty]
        public int GamesPlayed { get; internal set; }

        [JsonProperty]
        public int Wins { get; internal set; }

        [JsonProperty]
        public int Losses { get; internal set; }

        [JsonProperty("melee")]
        public int Melees { get; internal set; }

        [JsonProperty]
        public int Hits { get; internal set; }

        [JsonProperty]
        public int Misses { get; internal set; }

        [JsonProperty]
        public int RankXP { get; internal set; }

        [JsonProperty]
        public int CareerScore { get; internal set; }

        [JsonProperty]
        public int TotalHeals { get; internal set; }

        [JsonProperty]
        public int EKIA { get; internal set; }

        [JsonProperty]
        public int LongestKillstreak { get; internal set; }

        [JsonProperty("curwinstreak")]
        public int CurrentWinstreak { get; internal set; }

        [JsonProperty]
        public int TotalShots { get; internal set; }

        [JsonProperty]
        public int TeamKills { get; internal set; }

        [JsonProperty]
        public int Suicides { get; internal set; }

        [JsonProperty]
        public int Offends { get; internal set; }

        [JsonProperty]
        public int KillsDenied { get; internal set; }

        [JsonProperty]
        public int Captures { get; internal set; }

        [JsonProperty]
        public int Defends { get; internal set; }

        [JsonProperty]
        public int TimePlayed { get; internal set; }
    }
}
