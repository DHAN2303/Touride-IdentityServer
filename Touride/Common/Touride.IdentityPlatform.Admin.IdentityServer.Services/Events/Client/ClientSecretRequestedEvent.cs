﻿using Skoruba.AuditLogging.Events;
using System;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.Client
{
    public class ClientSecretRequestedEvent : AuditEvent
    {
        public int ClientId { get; set; }

        public int ClientSecretId { get; set; }

        public string Type { get; set; }

        public DateTime? Expiration { get; set; }

        public ClientSecretRequestedEvent(int clientId, int clientSecretId, string type, DateTime? expiration)
        {
            ClientId = clientId;
            ClientSecretId = clientSecretId;
            Type = type;
            Expiration = expiration;
        }
    }
}