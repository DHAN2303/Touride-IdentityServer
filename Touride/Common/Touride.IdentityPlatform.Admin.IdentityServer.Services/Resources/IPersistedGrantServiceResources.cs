using Touride.IdentityPlatform.Admin.IdentityServer.Services.Helpers;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Resources
{
    public interface IPersistedGrantServiceResources
    {
        ResourceMessage PersistedGrantDoesNotExist();

        ResourceMessage PersistedGrantWithSubjectIdDoesNotExist();
    }
}
