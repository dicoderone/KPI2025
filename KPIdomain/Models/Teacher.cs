using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Subject { get; set; } = ""; // O'qitadigan fanlari
        public int YearsOfExperience { get; set; } // Ish tajribasi (yillarda)

        public string Degree { get; set; } = ""; // Ilmiy darajasi (masalan, bakalavr, magistr)
        public IFormFile Certifications { get; set; }   // Sertifikatlar (vergul bilan ajratilgan ro'yxat)

        public DateTime HireDate { get; set; } // Ishga kirgan sana

        public bool IsActive { get; set; } // O'qituvchi faol yoki faol emasligini ko'rsatadi

        public Teacher(){}

    }
}
