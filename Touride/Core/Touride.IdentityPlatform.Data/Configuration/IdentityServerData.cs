using IdentityServer4.Models;
using System.Collections.Generic;
using Client = Touride.IdentityPlatform.Data.Configuration.IdentityServer.Client;

namespace Touride.IdentityPlatform.Data.Configuration.Configuration
{
    public class IdentityServerData
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<IdentityResource> IdentityResources { get; set; } = new List<IdentityResource>();
        public List<ApiResource> ApiResources { get; set; } = new List<ApiResource>();
        public List<ApiScope> ApiScopes { get; set; } = new List<ApiScope>();
    }
}
