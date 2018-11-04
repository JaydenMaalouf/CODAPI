using Newtonsoft.Json;

namespace CallOfDutyAPI.Endpoints.Stats.Items
{
    public class CODStatsUserItem
    {
        internal CODStatsUserItem() { }

        [JsonProperty("id")]
        [JsonConverter(typeof(UIDConverter))]
        public UID UserId { get; internal set; }

        [JsonProperty]
        public string Username { get; internal set; }

        [JsonProperty]
        public PlatformType Platform { get; internal set; }

        [JsonProperty("title")]
        public GameType Game { get; internal set; }

        [JsonProperty]
        public string Avatar { get; internal set; }
    }
}
