using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace TalisSoft.Octopus.IDP
{
  public static class Config
  {

    public static List<TestUser> GetUsers()
    {
      return new List<TestUser>
      {
        new TestUser()
        {
          SubjectId = "ce04a25a-e6f7-11eb-ba80-0242ac130004",
          Username = "ognanshissi",
          Password = "password",
          
          Claims = new List<Claim>
          {
            new Claim("given_name", "Ambroise"),
            new Claim("family_name", "BAZIE"),
          }
        },
        new TestUser
        {
          SubjectId = "e281cfdc-324b-485f-b878-c56872fa7a7c",
          Username = "jason",
          Password = "password",
          
          Claims = new List<Claim>
          {
            new Claim("given_name", "Mike"),
            new Claim("family_name", "DOE"),
          }
        }
      };

    }


    public static IEnumerable<IdentityResource> GetIdentityResources()
    {
      return new List<IdentityResource>
      {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile()
      };
    }


    /// <summary>
    /// Get Clients Applications
    /// - web
    /// - desktop
    /// - mobile
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<Client> GetClients()
    {
      return new List<Client>
      {
        new Client
        {
          ClientName = "Octopus Web",
          ClientId = "octopusweb",
          AllowedGrantTypes = GrantTypes.Code,
          RedirectUris = new List<string>
          {
            "https://localhost:4343/signin-oidc"
          },
          ClientSecrets = { new Secret("secret".Sha256()) },
          AllowedScopes =
          {
            IdentityServerConstants.StandardScopes.OpenId,
            IdentityServerConstants.StandardScopes.Profile
          }
        }
      };
    }
    
  }
}