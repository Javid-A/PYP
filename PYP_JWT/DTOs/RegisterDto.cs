using System.ComponentModel.DataAnnotations;

namespace PYP_JWT.DTOs
{
    public class RegisterDto
    {
        public string UserName { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
