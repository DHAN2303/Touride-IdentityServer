using Skoruba.AuditLogging.Events;
using Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Grant;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Events.PersistedGrant
{
    public class PersistedGrantsIdentityByUsersRequestedEvent : AuditEvent
    {
        public PersistedGrantsDto PersistedGrants { get; set; }

        public PersistedGrantsIdentityByUsersRequestedEvent(PersistedGrantsDto persistedGrants)
        {
            PersistedGrants = persistedGrants;
        }
    }
}