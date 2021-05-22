using System.Threading.Tasks;
using TalisSoft.Common.Application.Models.Authentication;

namespace TalisSoft.Common.Application.Contracts.Identity
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
    }
}
