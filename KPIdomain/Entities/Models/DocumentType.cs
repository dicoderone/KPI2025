using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static KPIdomain.Entities.Models.User;

namespace KPIdomain.Entities.Models
{
    public class DocumentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? DocumentName { get; set; }
        public UserRole userRole { get; set; }

        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }

    public enum DocumentStatus
    {
        Save = 0,
        Pending,   // Ko‘rib chiqilmoqda
        Approved,  // Tasdiqlandi
        Rejected   // Rad etildi
    }
}
