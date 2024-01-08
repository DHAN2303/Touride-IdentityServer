using Skoruba.AuditLogging.Events;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Grant;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.PersistedGrant
{
    public class PersistedGrantsByUserRequestedEvent : AuditEvent
    {
        public PersistedGrantsDto PersistedGrants { get; set; }

        public PersistedGrantsByUserRequestedEvent(PersistedGrantsDto persistedGrants)
        {
            PersistedGrants = persistedGrants;
        }
    }
}