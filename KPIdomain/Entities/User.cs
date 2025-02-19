using KPIdomain.Role;

namespace KPIdomain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime Birthday { get; set; }

        public string Passwordhash { get; set; }

        public UserRole Role { get; set; }

        public User() { }


    }
}
