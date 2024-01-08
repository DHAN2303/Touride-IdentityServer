using Touride.IdentityPlatform.Admin.CoreIdentity.Services.Helpers;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Resources
{
    public interface IPersistedGrantAspNetIdentityServiceResources
    {
        ResourceMessage PersistedGrantDoesNotExist();

        ResourceMessage PersistedGrantWithSubjectIdDoesNotExist();
    }
}
