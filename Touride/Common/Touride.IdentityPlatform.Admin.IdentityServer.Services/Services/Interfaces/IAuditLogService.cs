using System;
using System.Threading.Tasks;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Logdtos;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Services.Interfaces
{
    public interface IAuditLogService
    {
        Task<AuditLogsDto> GetAsync(AuditLogFilterDto filters);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}
