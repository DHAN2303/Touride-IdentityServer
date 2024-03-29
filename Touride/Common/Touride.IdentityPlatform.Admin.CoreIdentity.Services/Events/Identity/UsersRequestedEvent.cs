﻿using Skoruba.AuditLogging.Events;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Events.Identity
{
    public class UsersRequestedEvent<TUsersDto> : AuditEvent
    {
        public TUsersDto Users { get; set; }

        public UsersRequestedEvent(TUsersDto users)
        {
            Users = users;
        }
    }
}