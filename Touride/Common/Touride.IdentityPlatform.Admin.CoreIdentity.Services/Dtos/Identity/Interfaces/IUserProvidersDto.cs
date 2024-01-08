using System.Collections.Generic;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity.Interfaces
{
    public interface IUserProvidersDto : IUserProviderDto
    {
        List<IUserProviderDto> Providers { get; }
    }
}
