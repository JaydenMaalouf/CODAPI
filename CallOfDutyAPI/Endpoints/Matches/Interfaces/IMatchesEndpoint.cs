using System.Threading.Tasks;
using System.Collections.Generic;

using CallOfDutyAPI.Endpoints.Matches.Items;

namespace CallOfDutyAPI.Endpoints.Matches.Interfaces
{
    public interface IMatchesEndpoint
    {
        Task<List<MatchItem>> GetRecentMatchesAsync(int entryCount = 100);
        Task<List<MatchItem>> GetMatchAsync(UID matchId);
    }
}
