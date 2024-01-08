using Skoruba.AuditLogging.Events;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Configuration;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.IdentityResource
{
    public class IdentityResourcesRequestedEvent : AuditEvent
    {
        public IdentityResourcesDto IdentityResources { get; }

        public IdentityResourcesRequestedEvent(IdentityResourcesDto identityResources)
        {
            IdentityResources = identityResources;
        }
    }
}