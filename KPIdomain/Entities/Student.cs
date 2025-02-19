namespace KPIdomain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int TeacherId { get; set; } // O‘qituvchi bilan bog‘lanish
        public Teacher? Teacher { get; set; }
        public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
