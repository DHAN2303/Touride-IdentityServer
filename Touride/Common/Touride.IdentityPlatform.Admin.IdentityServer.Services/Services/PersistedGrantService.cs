﻿using Skoruba.AuditLogging.Services;
using System.Threading.Tasks;
using Touride.IdentityPlatform.Admin.Common.ExceptionHandling;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Grant;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.PersistedGrant;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Mappers;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Resources;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Services.Interfaces;
using Touride.IdentityPlatform.Data.Repositories.Interfaces;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Services
{
    public class PersistedGrantService : IPersistedGrantService
    {
        protected readonly IPersistedGrantRepository PersistedGrantRepository;
        protected readonly IPersistedGrantServiceResources PersistedGrantServiceResources;
        protected readonly IAuditEventLogger AuditEventLogger;

        public PersistedGrantService(IPersistedGrantRepository persistedGrantRepository,
            IPersistedGrantServiceResources persistedGrantServiceResources,
            IAuditEventLogger auditEventLogger)
        {
            PersistedGrantRepository = persistedGrantRepository;
            PersistedGrantServiceResources = persistedGrantServiceResources;
            AuditEventLogger = auditEventLogger;
        }

        public virtual async Task<PersistedGrantsDto> GetPersistedGrantsByUsersAsync(string search, int page = 1, int pageSize = 10)
        {
            var pagedList = await PersistedGrantRepository.GetPersistedGrantsByUsersAsync(search, page, pageSize);
            var persistedGrantsDto = pagedList.ToModel();

            await AuditEventLogger.LogEventAsync(new PersistedGrantsByUsersRequestedEvent(persistedGrantsDto));

            return persistedGrantsDto;
        }

        public virtual async Task<PersistedGrantsDto> GetPersistedGrantsByUserAsync(string subjectId, int page = 1, int pageSize = 10)
        {
            var exists = await PersistedGrantRepository.ExistsPersistedGrantsAsync(subjectId);
            if (!exists) throw new UserFriendlyErrorPageException(string.Format(PersistedGrantServiceResources.PersistedGrantWithSubjectIdDoesNotExist().Description, subjectId), PersistedGrantServiceResources.PersistedGrantWithSubjectIdDoesNotExist().Description);

            var pagedList = await PersistedGrantRepository.GetPersistedGrantsByUserAsync(subjectId, page, pageSize);
            var persistedGrantsDto = pagedList.ToModel();

            await AuditEventLogger.LogEventAsync(new PersistedGrantsByUserRequestedEvent(persistedGrantsDto));

            return persistedGrantsDto;
        }

        public virtual async Task<PersistedGrantDto> GetPersistedGrantAsync(string key)
        {
            var persistedGrant = await PersistedGrantRepository.GetPersistedGrantAsync(key);
            if (persistedGrant == null) throw new UserFriendlyErrorPageException(string.Format(PersistedGrantServiceResources.PersistedGrantDoesNotExist().Description, key), PersistedGrantServiceResources.PersistedGrantDoesNotExist().Description);
            var persistedGrantDto = persistedGrant.ToModel();

            await AuditEventLogger.LogEventAsync(new PersistedGrantRequestedEvent(persistedGrantDto));

            return persistedGrantDto;
        }

        public virtual async Task<int> DeletePersistedGrantAsync(string key)
        {
            var deleted = await PersistedGrantRepository.DeletePersistedGrantAsync(key);

            await AuditEventLogger.LogEventAsync(new PersistedGrantDeletedEvent(key));

            return deleted;
        }

        public virtual async Task<int> DeletePersistedGrantsAsync(string userId)
        {
            var deleted = await PersistedGrantRepository.DeletePersistedGrantsAsync(userId);

            await AuditEventLogger.LogEventAsync(new PersistedGrantsDeletedEvent(userId));

            return deleted;
        }
    }
}
