using Skoruba.AuditLogging.Events;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Configuration;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.Client
{
    public class ClientPropertyRequestedEvent : AuditEvent
    {
        public ClientPropertiesDto ClientProperties { get; set; }

        public ClientPropertyRequestedEvent(ClientPropertiesDto clientProperties)
        {
            ClientProperties = clientProperties;
        }
    }
}