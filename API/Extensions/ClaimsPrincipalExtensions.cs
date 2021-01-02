using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            // get user's username from cliams rather than expecting using to send correct username 
            // ClaimTypes.Name is actually UniqueName in relation to 
            // new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName) in TokenService.cs
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

        public static int GetUserId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}