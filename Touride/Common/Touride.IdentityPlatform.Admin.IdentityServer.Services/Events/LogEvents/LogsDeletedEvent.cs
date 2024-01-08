using Skoruba.AuditLogging.Events;
using System;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Events.LogEvents
{
    public class LogsDeletedEvent : AuditEvent
    {
        public DateTime DeleteOlderThan { get; set; }

        public LogsDeletedEvent(DateTime deleteOlderThan)
        {
            DeleteOlderThan = deleteOlderThan;
        }
    }
}