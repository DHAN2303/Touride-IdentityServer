﻿using System.ComponentModel.DataAnnotations;
using Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity.Base;
using Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity.Interfaces;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity
{
    public class RoleClaimDto<TKey> : BaseRoleClaimDto<TKey>, IRoleClaimDto
    {
        [Required]
        public string ClaimType { get; set; }


        [Required]
        public string ClaimValue { get; set; }
    }
}
