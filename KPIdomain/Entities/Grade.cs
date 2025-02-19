namespace KPIdomain.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Value { get; set; } // Grade value (2, 3, 4, 5)
        public Student? Student { get; set; }
        public Subject? Subject { get; set; }
    }

    public class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplex { get; set; } // Indicates if the subject is complex (e.g., math, physics)
    }
}
