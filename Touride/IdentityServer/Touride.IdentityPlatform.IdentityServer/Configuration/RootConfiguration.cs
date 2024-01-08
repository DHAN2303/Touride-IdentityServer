
using Touride.IdentityPlatform.IdentityServer.Common.Configuration.Identity;
using Touride.IdentityPlatform.IdentityServer.Configuration;
using Touride.IdentityPlatform.IdentityServer.Configuration.Interfaces;

namespace Touride.IdentityPlatform.IdentityServer.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}