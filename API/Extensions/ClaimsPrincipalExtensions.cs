using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            // get user's username from cliams rather than expecting using to send correct username 
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}