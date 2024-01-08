using Skoruba.AuditLogging.EntityFramework.Entities;
using System;
using System.Threading.Tasks;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Logdtos;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Mappers;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Services.Interfaces;
using Touride.IdentityPlatform.Data.Repositories.Interfaces;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Services
{
    public class AuditLogService<TAuditLog> : IAuditLogService
        where TAuditLog : AuditLog
    {
        protected readonly IAuditLogRepository<TAuditLog> AuditLogRepository;

        public AuditLogService(IAuditLogRepository<TAuditLog> auditLogRepository)
        {
            AuditLogRepository = auditLogRepository;
        }

        public async Task<AuditLogsDto> GetAsync(AuditLogFilterDto filters)
        {
            var pagedList = await AuditLogRepository.GetAsync(filters.Event, filters.Source, filters.Category, filters.Created, filters.SubjectIdentifier, filters.SubjectName, filters.Page, filters.PageSize);
            var auditLogsDto = pagedList.ToModel();

            return auditLogsDto;
        }

        public virtual async Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan)
        {
            await AuditLogRepository.DeleteLogsOlderThanAsync(deleteOlderThan);
        }
    }
}
