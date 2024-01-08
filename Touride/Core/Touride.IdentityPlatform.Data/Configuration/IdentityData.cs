using System.Collections.Generic;
using Touride.IdentityPlatform.Data.Configuration.Identity;

namespace Touride.IdentityPlatform.Data.Configuration.Configuration
{
    public class IdentityData
    {
        public List<Role> Roles { get; set; }
        public List<User> Users { get; set; }
    }
}
