using Skoruba.AuditLogging.Events;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Events.PersistedGrant
{
    public class PersistedGrantIdentityDeletedEvent : AuditEvent
    {
        public string Key { get; set; }

        public PersistedGrantIdentityDeletedEvent(string key)
        {
            Key = key;
        }
    }
}