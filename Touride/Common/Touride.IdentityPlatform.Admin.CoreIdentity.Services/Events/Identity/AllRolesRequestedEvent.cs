﻿using Skoruba.AuditLogging.Events;
using System.Collections.Generic;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Events.Identity
{
    public class AllRolesRequestedEvent<TRoleDto> : AuditEvent
    {
        public List<TRoleDto> Roles { get; set; }

        public AllRolesRequestedEvent(List<TRoleDto> roles)
        {
            Roles = roles;
        }
    }
}