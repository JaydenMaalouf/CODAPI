using System.Collections.Generic;

using Newtonsoft.Json;

namespace CallOfDutyAPI.Endpoints.Matches.Items
{
    public class MatchTeamInfoItem
    {
        internal MatchTeamInfoItem() { }

        [JsonProperty]
        public Dictionary<string, int> TeamScore { get; internal set; }

        [JsonProperty]
        public int WinningTeam { get; internal set; }
    }
}
