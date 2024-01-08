using System.Collections.Generic;
using Touride.IdentityPlatform.Admin.Common.Dtos.Common;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity.Interfaces
{
    public interface IUserRolesDto : IBaseUserRolesDto
    {
        string UserName { get; set; }
        List<SelectItemDto> RolesList { get; set; }
        List<IRoleDto> Roles { get; }
        int PageSize { get; set; }
        int TotalCount { get; set; }
    }
}
