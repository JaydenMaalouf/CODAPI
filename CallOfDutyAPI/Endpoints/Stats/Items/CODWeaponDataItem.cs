using Newtonsoft.Json;

namespace CallOfDutyAPI.Endpoints.Stats.Items
{
    public class CODWeaponDataItem
    {
        internal CODWeaponDataItem() { }

        [JsonProperty]
        public string Identifier { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; }

        [JsonProperty]
        public int Kills { get; internal set; }

        [JsonProperty("backstabber_kill")]
        public int Backstabs { get; internal set; }

        [JsonProperty]
        public int Deaths { get; internal set; }

        [JsonProperty]
        public int TimesUsed { get; internal set; }

        [JsonProperty]
        public int Used { get; internal set; }

        [JsonProperty]
        public int DeathsDuringUse { get; internal set; }

        [JsonProperty]
        public int Hits { get; internal set; }

        [JsonProperty]
        public int EKIA { get; internal set; }

        [JsonProperty]
        public int Destroyed { get; internal set; }

        [JsonProperty]
        public int Headshots { get; internal set; }

        [JsonProperty]
        public int Shots { get; internal set; }

        [JsonProperty]
        public int Assists { get; internal set; }

        [JsonProperty]
        public int DamageDone { get; internal set; }
    }
}
