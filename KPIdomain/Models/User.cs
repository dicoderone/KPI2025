using KPIdomain.Models.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string PasportCode { get; set; }

        public UserRole Role { get; set; }

        public User() { }


    }
}
