using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;
using TechnicalChallenge.Api.Controllers.Authentication;
using TechnicalChallenge.Api.Controllers.Authentication.Helper;
using TechnicalChallenge.Api.Repository;

namespace TechnicalChallenge.Api.Services
{
    /// <summary>
    /// user authentication implementation
    /// User sevice help query login and validate user
    /// </summary>
    public class UserService : IUserAuthenticationService
    {
        private readonly DataBaseContext _dataBaseContext;

        private readonly IConfiguration _config;

        public UserService(DataBaseContext dataBaseContext, IConfiguration config)
        {
            _dataBaseContext = dataBaseContext;
            _config = config;
        }

        /// <summary>
        /// Log user with jwt
        /// </summary>
        /// <param name="loginRequest">login request is the user id</param>
        /// <returns></returns>
        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            var user = _dataBaseContext.Users.SingleOrDefault(user => user.Id == loginRequest.Id);

            if (user == null)
            {
                return null;
            }

            var token = await Task.Run(() => TokenHelper.GenerateToken(user, _config));

            return new LoginResponse { Id = user.Id, FullName = user.FullName, Token = token };
        }

    }
}
