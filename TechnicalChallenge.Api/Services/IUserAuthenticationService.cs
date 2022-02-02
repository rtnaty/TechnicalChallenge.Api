using System.Threading.Tasks;
using TechnicalChallenge.Api.Controllers.Authentication;

namespace TechnicalChallenge.Api.Services
{

    /// <summary>
    /// User authentication interface
    /// </summary>
    public interface IUserAuthenticationService
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);
    }
}