using System;

using RestSharp;

using Newtonsoft.Json;

using CallOfDutyAPI.Endpoints.Stats;
using CallOfDutyAPI.Endpoints.User.Interfaces;
using CallOfDutyAPI.Endpoints.Stats.Interfaces;

namespace CallOfDutyAPI.Endpoints.User
{
    public class CODUser : ICODUser
    {
        [JsonProperty]
        public string Username { get; internal set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(UIDConverter))]
        public UID UserId { get; internal set; }

        [JsonProperty]
        [JsonConverter(typeof(UIDConverter))]
        private UID UID { set { UserId = value; } }

        [JsonProperty]
        public GameType Game { get; internal set; }

        [JsonProperty]
        public PlatformType Platform { get; internal set; }

        public IStatsEndpoint Stats => new StatsEndpoint(this);

        internal CODUser() { }

        public CODUser(string username, GameType gameType, PlatformType platformType)
        {
            var request = new RestRequest("validate/{gameType}/{username}/{platformType}", Method.GET);
            request.AddUrlSegment("username", username);
            request.AddUrlSegment("gameType", gameType.ToString().ToLower());
            request.AddUrlSegment("platformType", platformType.ToString().ToLower());
            IRestResponse response = CODAPI.SendRestRequest(request);
            if (response.ResponseStatus != ResponseStatus.Completed || String.IsNullOrWhiteSpace(response.Content))
            {
                return;
            }

            Game = gameType;
            Platform = platformType;

            JsonConvert.PopulateObject(response.Content, this);
        }

        public CODUser(UID UniqueId)
        {
            var request = new RestRequest("users/ids", Method.GET);
            request.AddParameter("id", UniqueId.ToString());
            IRestResponse response = CODAPI.SendRestRequest(request);
            if (response.ResponseStatus != ResponseStatus.Completed || String.IsNullOrWhiteSpace(response.Content))
            {
                return;
            }
            JsonConvert.PopulateObject(response.Content, this);
        }

        public bool IsValid()
        {
            return (UserId != null && !String.IsNullOrWhiteSpace(UserId.ToString()) && !String.IsNullOrWhiteSpace(Username));
        }
    }
}
