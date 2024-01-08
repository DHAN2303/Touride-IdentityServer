using Skoruba.AuditLogging.Events;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Events.Identity
{
    public class UserClaimRequestedEvent<TUserClaimsDto> : AuditEvent
    {
        public TUserClaimsDto UserClaims { get; set; }

        public UserClaimRequestedEvent(TUserClaimsDto userClaims)
        {
            UserClaims = userClaims;
        }
    }
}