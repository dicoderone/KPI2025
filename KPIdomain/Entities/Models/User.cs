using KPIdomain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KPIdomain.Entities.Models
{
    public class User : BaseEntity, IAuditedEntity
    {
        public enum UserRole
        {
            SuperAdmin = 0,
            Admin = 1,
            Psychologist = 2,
            Librarian,
            Pedogok
        }

        public enum UserStatus
        {
            New = 1,
            Active,
            Inactive,
            Deleted
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public UserRole Role { get; set; }
        public UserStatus Status { get; set; } = UserStatus.Inactive;
        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpireDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? Email { get; set; }
        public int TotalScore { get; set; } = 0;
        public string FullName { get; set; } = null!;
        public string Lastname { get; set; } = null!;

        public string Firstname { get; set; } = null!;
        public string? PhoneNumber { get; set; }

        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}
