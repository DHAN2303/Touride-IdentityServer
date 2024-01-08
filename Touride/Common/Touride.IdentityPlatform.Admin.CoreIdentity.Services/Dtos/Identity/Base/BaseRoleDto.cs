using System.Collections.Generic;
using Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity.Interfaces;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity.Base
{
    public class BaseRoleDto<TRoleId> : IBaseRoleDto
    {
        public TRoleId Id { get; set; }

        public bool IsDefaultId() => EqualityComparer<TRoleId>.Default.Equals(Id, default(TRoleId));

        object IBaseRoleDto.Id => Id;
    }
}