using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using RestSharp;

using Newtonsoft.Json.Linq;

using CallOfDutyAPI.Endpoints.Matches.Items;
using CallOfDutyAPI.Endpoints.Matches.Interfaces;

namespace CallOfDutyAPI.Endpoints.Matches
{
    class MatchesEndpoint : IMatchesEndpoint
    {
        internal MatchesEndpoint() { }

        public async Task<List<MatchItem>> GetRecentMatchesAsync(int entryCount = 100)
        {
            if (entryCount > 0 && entryCount <= 100)
            {
                var request = new RestRequest("matches/recent", Method.GET);
                request.AddParameter("rows", entryCount);
                IRestResponse response = await CODAPI.SendRestRequestAsync(request).ConfigureAwait(false);
                if (response.ResponseStatus != ResponseStatus.Completed || String.IsNullOrWhiteSpace(response.Content))
                {
                    return null;
                }

                return JObject.Parse(response.Content)["entries"].ToObject<List<MatchItem>>();
            }
            return null;
        }

        public async Task<List<MatchItem>> GetMatchAsync(UID matchId)
        {
            var request = new RestRequest("matches/get", Method.GET);
            request.AddParameter("id", matchId.ToString());
            IRestResponse response = await CODAPI.SendRestRequestAsync(request).ConfigureAwait(false);
            if (response.ResponseStatus != ResponseStatus.Completed || String.IsNullOrWhiteSpace(response.Content))
            {
                return null;
            }

            return JObject.Parse(response.Content)["entry"].ToObject<List<MatchItem>>();
        }
    }
}
