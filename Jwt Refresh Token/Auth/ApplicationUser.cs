using Microsoft.AspNetCore.Identity;

namespace Jwt_Refresh_Token.Auth
{
   
        public class ApplicationUser : IdentityUser
        {
            public string? RefreshToken { get; set; }
            public DateTime RefreshTokenExpiryTime { get; set; }
        }
    
}
