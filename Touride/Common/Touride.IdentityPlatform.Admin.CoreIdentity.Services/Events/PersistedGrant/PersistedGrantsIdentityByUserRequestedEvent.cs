using Skoruba.AuditLogging.Events;
using Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Grant;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Events.PersistedGrant
{
    public class PersistedGrantsIdentityByUserRequestedEvent : AuditEvent
    {
        public PersistedGrantsDto PersistedGrants { get; set; }

        public PersistedGrantsIdentityByUserRequestedEvent(PersistedGrantsDto persistedGrants)
        {
            PersistedGrants = persistedGrants;
        }
    }
}