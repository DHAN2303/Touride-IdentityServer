﻿using Skoruba.AuditLogging.Events;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.PersistedGrant
{
    public class PersistedGrantsDeletedEvent : AuditEvent
    {
        public string UserId { get; set; }

        public PersistedGrantsDeletedEvent(string userId)
        {
            UserId = userId;
        }
    }
}