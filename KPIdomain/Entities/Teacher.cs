using KPIdomain.Role;

namespace KPIdomain.Models
{
    public class Teacher
    {
        public int Id { get; set; } // O'qituvchi identifikatori
        public string FirstName { get; set; } = ""; // Ismi
        public string LastName { get; set; } = ""; // Familiyasi

        public DateTime DateOfBirth { get; set; } // Tug'ilgan sanasi

        public string Email { get; set; } // Email manzili
        public string PhoneNumber { get; set; } = ""; // Telefon raqami

        public string Address { get; set; } = ""; // Manzili
        public string Nationality { get; set; } = ""; // Millati

        public Subject Subject { get; set; } // O'qitadigan fanlari
        public int YearsOfExperience { get; set; } // Ish tajribasi (yillarda)

        public string Degree { get; set; } = ""; // Ilmiy darajasi (masalan, bakalavr, magistr)

        public DateTime HireDate { get; set; } // Ishga kirgan sana

        public bool IsActive { get; set; } // O'qituvchi faol yoki faol emasligini ko'rsatadi
        public UserRole Role { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();

        public Teacher()
        {
            Students = new List<Student>();
            Subject = new Subject();
        }

    }
}
