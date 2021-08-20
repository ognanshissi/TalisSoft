using System;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;

namespace TalisSoft.Client
{
  class Program
  {
    private static async Task Main(string[] args)
    {
      var client = new HttpClient();
      var disco = await client.GetDiscoveryDocumentAsync("https://localhost:4343");
      if ( disco.IsError )
      {
        Console.WriteLine(disco.Error);
        return;
      }
      Console.WriteLine(disco.TokenEndpoint);
      
      // request token
      var tokenResponse = await client.RequestClientCredentialsTokenAsync(
        new ClientCredentialsTokenRequest()
        {
          Address = disco.TokenEndpoint,
          ClientId = "octopusweb",
          ClientSecret = "secret",
          Scope = "openid"
        });

      if (tokenResponse.IsError)
      {
        Console.WriteLine(tokenResponse.Error);
        return;
      }
      Console.WriteLine(tokenResponse.Json);
      Console.WriteLine("\n\n");
      // Console.WriteLine("Hello World!");

    }
  }
}