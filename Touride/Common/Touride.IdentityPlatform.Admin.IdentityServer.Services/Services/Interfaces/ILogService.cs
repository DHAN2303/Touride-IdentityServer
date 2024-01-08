using System;
using System.Threading.Tasks;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Logdtos;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Services.Interfaces
{
    public interface ILogService
    {
        Task<LogsDto> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}