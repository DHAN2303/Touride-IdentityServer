using Skoruba.AuditLogging.Events;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.PersistedGrant
{
    public class PersistedGrantDeletedEvent : AuditEvent
    {
        public string PersistedGrantKey { get; set; }

        public PersistedGrantDeletedEvent(string persistedGrantKey)
        {
            PersistedGrantKey = persistedGrantKey;
        }
    }
}