using System;
using System.Threading.Tasks;
using Touride.IdentityPlatform.Data.Common;
using Touride.IdentityPlatform.Data.Entities;

namespace Touride.IdentityPlatform.Data.Repositories.Interfaces
{
    public interface ILogRepository
    {
        Task<PagedList<Log>> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);

        bool AutoSaveChanges { get; set; }
    }
}