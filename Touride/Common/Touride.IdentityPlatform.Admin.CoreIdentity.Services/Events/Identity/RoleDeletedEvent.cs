using Skoruba.AuditLogging.Events;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Events.Identity
{
    public class RoleDeletedEvent<TRoleDto> : AuditEvent
    {
        public TRoleDto Role { get; set; }

        public RoleDeletedEvent(TRoleDto role)
        {
            Role = role;
        }
    }
}