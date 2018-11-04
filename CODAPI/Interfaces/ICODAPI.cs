using CallOfDutyAPI.Endpoints.Matches.Interfaces;
using CallOfDutyAPI.Endpoints.Leaderboard.Interfaces;

namespace CallOfDutyAPI.Interfaces
{
    public interface ICODAPI
    {
        ILeaderboardEndpoint Leaderboard { get; }
        IMatchesEndpoint Matches { get; }
    }
}
