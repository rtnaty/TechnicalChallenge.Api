namespace TechnicalChallenge.Api.Controllers.Authentication
{
    /// <summary>
    /// Login response
    /// Return token for test purpose only
    /// </summary>
    public class LoginResponse
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Token { get; set; }

    }
}