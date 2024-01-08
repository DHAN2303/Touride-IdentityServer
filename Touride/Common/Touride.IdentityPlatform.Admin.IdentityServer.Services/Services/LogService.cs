using Skoruba.AuditLogging.Services;
using System;
using System.Threading.Tasks;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Logdtos;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.LogEvents;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Mappers;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Services.Interfaces;
using Touride.IdentityPlatform.Data.Repositories.Interfaces;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Services
{
    public class LogService : ILogService
    {
        protected readonly ILogRepository Repository;
        protected readonly IAuditEventLogger AuditEventLogger;

        public LogService(ILogRepository repository, IAuditEventLogger auditEventLogger)
        {
            Repository = repository;
            AuditEventLogger = auditEventLogger;
        }

        public virtual async Task<LogsDto> GetLogsAsync(string search, int page = 1, int pageSize = 10)
        {
            var pagedList = await Repository.GetLogsAsync(search, page, pageSize);
            var logs = pagedList.ToModel();

            await AuditEventLogger.LogEventAsync(new LogsRequestedEvent());

            return logs;
        }

        public virtual async Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan)
        {
            await Repository.DeleteLogsOlderThanAsync(deleteOlderThan);

            await AuditEventLogger.LogEventAsync(new LogsDeletedEvent(deleteOlderThan));
        }
    }
}
