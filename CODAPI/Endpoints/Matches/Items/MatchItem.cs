using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace CallOfDutyAPI.Endpoints.Matches.Items
{
    public class MatchItem
    {
        internal MatchItem() { }

        [JsonProperty("mid")]
        [JsonConverter(typeof(UIDConverter))]
        public UID MatchId { get; internal set; }

        [JsonProperty]
        public DateTime StartTime { get; internal set; }

        [JsonProperty]
        private long UTCStart { set { StartTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(value); } }

        [JsonProperty]
        public DateTime EndTime { get; internal set; }

        [JsonProperty]
        private long UTCEnd { set { EndTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(value); } }

        [JsonProperty]
        public MatchInfoItem MatchInfo { get; internal set; }

        [JsonProperty("teams")]
        public MatchTeamInfoItem TeamInfo { get; internal set; }

        [JsonProperty]
        public List<MatchPlayerItem> PlayerEntries { get; internal set; }
    }    
}
