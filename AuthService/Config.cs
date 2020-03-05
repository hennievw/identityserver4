using IdentityServer4.Models;
using System.Collections.Generic;

namespace AuthService
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiResource> Apis =>
            new List<ApiResource>
            { 
                new ApiResource("api.accounts", "Accounts API")
            };
        
        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "17316D20-4E64-4269-BF58-E54F6D5DB315",
                    ClientName = "Some service based client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("top secret value".Sha256())
                    },
                    AllowedScopes = { "api.accounts" }
                }
            };
        
    }
}