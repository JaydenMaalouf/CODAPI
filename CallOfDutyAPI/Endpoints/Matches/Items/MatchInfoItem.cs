using Newtonsoft.Json;

namespace CallOfDutyAPI.Endpoints.Matches.Items
{
    public class MatchInfoItem
    {
        internal MatchInfoItem() { }

        [JsonProperty]
        public int MatchDuration { get; internal set; }

        [JsonProperty]
        public string MatchType { get; internal set; }

        [JsonProperty]
        public string MatchMapId { get; internal set; }

        [JsonProperty]
        public string MatchMode { get; internal set; }
    }
}
