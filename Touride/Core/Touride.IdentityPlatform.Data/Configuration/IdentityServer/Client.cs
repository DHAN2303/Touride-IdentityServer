using System.Collections.Generic;
using Touride.IdentityPlatform.Data.Configuration.Identity;

namespace Touride.IdentityPlatform.Data.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}
