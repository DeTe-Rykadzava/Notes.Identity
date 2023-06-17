using System.Collections.Generic;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4;

namespace Notes.Identity;

public class Configuration
{
    public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>()
        {
            new ApiScope("NotesWebAPI","Web API")
        };

    public static IEnumerable<IdentityResource> IdentityResources =>
        new List<IdentityResource>()
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };

    public static IEnumerable<ApiResource> ApiResources =>
        new List<ApiResource>()
        {
            new ApiResource("NotesWebAPI","Web API",new [] { JwtClaimTypes.Name })
                { Scopes = { "NotesWebAPI" } }
        };

    public static IEnumerable<Client> Clients =>
        new List<Client>()
        {
            new Client()
            {
              ClientId  = "notes-web-api",
              ClientName = "Notes Web",
              AllowedGrantTypes = GrantTypes.Code,
              RequirePkce = true,
              RequireClientSecret = false,
              RedirectUris =
              {
                  "http://.../signin-oidc"
              },
              AllowedCorsOrigins =
              {
                  "http://..."
              },
              PostLogoutRedirectUris =
              {
                  "http://.../signout-oidc"
              },
              AllowedScopes =
              {
                  IdentityServerConstants.StandardScopes.OpenId,
                  IdentityServerConstants.StandardScopes.Profile,
                  "NotesWebAPI"
              },
              AllowAccessTokensViaBrowser = true
            }
        };

}