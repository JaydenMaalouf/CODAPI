using System;
using System.Threading.Tasks;

using RestSharp;

using Newtonsoft.Json;

using CallOfDutyAPI.Classes;
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

        public async Task<CODStats> GetStatsAsync() => await GetStatsAsync(User.Game, User.Platform).ConfigureAwait(false);

        public async Task<CODStats> GetStatsAsync(GameType gameType, PlatformType platformType)
        {
            var request = new RestRequest("stats/{gameType}/{username}/{platformType}", Method.GET);
            request.AddUrlSegment("username", User.Username);
            request.AddUrlSegment("gameType", gameType.GetQueryName());
            request.AddUrlSegment("platformType", platformType.ToString().ToLower());

            switch (gameType)
            {
                case GameType.BO4BO:
                    request.AddParameter("type", "blackout");
                    break;
                case GameType.BO4:
                case GameType.BO4MP:
                    request.AddParameter("type", "multiplayer");
                    break;
                case GameType.BO4Z:
                    request.AddParameter("type", "zombies");
                    break;
            }

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
