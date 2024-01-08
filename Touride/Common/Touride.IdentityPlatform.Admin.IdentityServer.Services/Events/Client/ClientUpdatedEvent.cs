using Skoruba.AuditLogging.Events;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Configuration;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.Client
{
    public class ClientUpdatedEvent : AuditEvent
    {
        public ClientDto OriginalClient { get; set; }
        public ClientDto Client { get; set; }

        public ClientUpdatedEvent(ClientDto originalClient, ClientDto client)
        {
            OriginalClient = originalClient;
            Client = client;
        }
    }
}