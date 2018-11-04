using System.Threading.Tasks;
using System.Collections.Generic;

using CallOfDutyAPI.Endpoints.Leaderboard.Items;

namespace CallOfDutyAPI.Endpoints.Leaderboard.Interfaces
{
    public interface ILeaderboardEndpoint
    {
        Task<List<LeaderboardItem>> GetLeaderboardAsync(GameType gameType, LeaderboardPlatformType platformType = LeaderboardPlatformType.ALL, LeaderboardType leaderboardType = LeaderboardType.WINS, int entryCount = 100);
    }
}
