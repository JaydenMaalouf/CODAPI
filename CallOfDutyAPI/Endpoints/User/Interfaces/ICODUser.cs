using CallOfDutyAPI.Endpoints.Stats.Interfaces;

namespace CallOfDutyAPI.Endpoints.User.Interfaces
{
    public interface ICODUser
    {
        string Username { get; }
        UID UserId { get; }

        GameType Game { get; }
        PlatformType Platform { get; }

        IStatsEndpoint Stats { get; }
    }
}
