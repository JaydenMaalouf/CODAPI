using System.Threading.Tasks;

using RestSharp;

using CallOfDutyAPI.Interfaces;
using CallOfDutyAPI.Endpoints.User;
using CallOfDutyAPI.Endpoints.Matches;
using CallOfDutyAPI.Endpoints.Leaderboard;
using CallOfDutyAPI.Endpoints.Matches.Interfaces;
using CallOfDutyAPI.Endpoints.Leaderboard.Interfaces;

namespace CallOfDutyAPI
{
    public class CODAPI : ICODAPI
    {
        private static RestClient restClient = new RestClient("https://cod-api.theapinetwork.com/api/");

        public ILeaderboardEndpoint Leaderboard => new LeaderboardEndpoint();
        public IMatchesEndpoint Matches => new MatchesEndpoint();
        
        public CODUser GetUser(string username, GameType gameType, PlatformType platformType)
        {
            return new CODUser(username, gameType, platformType);
        }

        public CODUser GetUser(UID UniqueId)
        {
            return new CODUser(UniqueId);
        }

        internal static async Task<IRestResponse> SendRestRequestAsync(RestRequest request)
        {
            return await restClient.ExecuteTaskAsync(request).ConfigureAwait(false);
        }
    }
}
