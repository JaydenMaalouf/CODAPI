using System;
using System.Threading.Tasks;

using RestSharp;

using Newtonsoft.Json;

using CallOfDutyAPI.Endpoints.Stats.Items;
using CallOfDutyAPI.Endpoints.User.Interfaces;
using CallOfDutyAPI.Endpoints.Stats.Interfaces;

namespace CallOfDutyAPI.Endpoints.Stats
{
    public class StatsEndpoint : IStatsEndpoint
    {
        internal ICODUser User;

        internal StatsEndpoint(ICODUser _user)
        {
            User = _user;
        }

        public async Task<CODStats> GetStatsAsync() => await GetStatsAsync(User.Game, User.Platform);

        public async Task<CODStats> GetStatsAsync(GameType gameType, PlatformType platformType)
        {
            var request = new RestRequest("stats/{gameType}/{username}/{platformType}", Method.GET);
            request.AddUrlSegment("username", User.Username);
            request.AddUrlSegment("gameType", gameType.ToString().ToLower());
            request.AddUrlSegment("platformType", platformType.ToString().ToLower());
            request.AddParameter("u", User.UserId);

            IRestResponse response = await CODAPI.SendRestRequestAsync(request).ConfigureAwait(false);
            if (response.ResponseStatus != ResponseStatus.Completed || String.IsNullOrWhiteSpace(response.Content))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<CODStats>(response.Content); ;
        }
    }
}
