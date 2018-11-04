using System.Threading.Tasks;

using CallOfDutyAPI.Endpoints.Stats.Items;

namespace CallOfDutyAPI.Endpoints.Stats.Interfaces
{
    public interface IStatsEndpoint
    {
        Task<CODStats> GetStatsAsync();
        Task<CODStats> GetStatsAsync(GameType gameType, PlatformType platformType);
    }
}
