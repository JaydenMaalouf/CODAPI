using System.Collections.Generic;

using Newtonsoft.Json;

namespace CallOfDutyAPI.Endpoints.Stats.Items
{
    public class CODStats
    {
        internal CODStats() { }

        [JsonProperty]
        public CODStatsUserItem User { get; internal set; }

        [JsonProperty]
        public CODStatsItem Stats { get; internal set; }

        [JsonProperty]
        public List<CODMatchesItem> Matches { get; internal set; }

        [JsonProperty]
        public CODMatchesItem LastMatch { get; internal set; }

        [JsonProperty]
        public List<CODWeaponDataItem> WeaponData { get; internal set; }
    }
}
