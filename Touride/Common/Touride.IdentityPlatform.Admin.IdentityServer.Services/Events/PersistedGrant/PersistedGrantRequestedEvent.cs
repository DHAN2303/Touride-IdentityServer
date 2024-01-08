using Skoruba.AuditLogging.Events;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Grant;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.PersistedGrant
{
    public class PersistedGrantRequestedEvent : AuditEvent
    {
        public PersistedGrantDto PersistedGrant { get; set; }

        public PersistedGrantRequestedEvent(PersistedGrantDto persistedGrant)
        {
            PersistedGrant = persistedGrant;
        }
    }
}