using KPIdomain.Role;
using System.ComponentModel.DataAnnotations;

namespace KPIapplication.ModelDTO
{
    public class CreateUserModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string Password { get; set; } = "";
        public DateTime Birthday { get; set; }
        public UserRole Role { get; set; }
    }
}
