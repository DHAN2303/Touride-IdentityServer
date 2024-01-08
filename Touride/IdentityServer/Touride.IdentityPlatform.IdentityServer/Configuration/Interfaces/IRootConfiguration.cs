using Touride.IdentityPlatform.IdentityServer.Common.Configuration.Identity;

namespace Touride.IdentityPlatform.IdentityServer.Configuration.Interfaces
{
    public interface IRootConfiguration
    {
        AdminConfiguration AdminConfiguration { get; }

        RegisterConfiguration RegisterConfiguration { get; }
    }
}