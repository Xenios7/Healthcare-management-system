using System;

namespace EHRNurse.Api.Dto
{
    public class LoginResponse
    {
        public string Token { get; set; } = default!;
        public DateTime? ExpiresAt { get; set; }   
        public string Email { get; set; } = default!;
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Role { get; set; } = "";
    }
}
