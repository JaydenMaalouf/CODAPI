using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using RestSharp;

using Newtonsoft.Json.Linq;

using CallOfDutyAPI.Endpoints.Leaderboard.Items;
using CallOfDutyAPI.Endpoints.Leaderboard.Interfaces;

namespace CallOfDutyAPI.Endpoints.Leaderboard
{
    public class LeaderboardEndpoint : ILeaderboardEndpoint
    {
        internal LeaderboardEndpoint() { }

        public async Task<List<LeaderboardItem>> GetLeaderboardAsync(GameType gameType, LeaderboardPlatformType platformType = LeaderboardPlatformType.ALL, LeaderboardType leaderboardType = LeaderboardType.WINS, int entryCount = 100)
        {
            if (entryCount > 0 && entryCount <= 100)
            {
                var request = new RestRequest("leaderboard/{gameType}/{platformType}/{leaderboardType}", Method.GET);
                request.AddUrlSegment("gameType", gameType.ToString().ToLower());
                request.AddUrlSegment("platformType", platformType.ToString().ToLower());
                request.AddUrlSegment("leaderboardType", leaderboardType.ToString().ToLower());
                request.AddParameter("rows", entryCount);
                IRestResponse response = await CODAPI.SendRestRequestAsync(request).ConfigureAwait(false);
                if (response.ResponseStatus != ResponseStatus.Completed || String.IsNullOrWhiteSpace(response.Content))
                {
                    return null;
                }

                return JObject.Parse(response.Content)["entries"].ToObject<List<LeaderboardItem>>();
            }
            return null;
        }
    }
}
