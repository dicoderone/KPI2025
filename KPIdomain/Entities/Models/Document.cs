using KPIdomain.Common;
using KPIdomain.Entities.Extensions;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KPIdomain.Entities.Models
{
    public class Document : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public int Score { get; set; } = 0;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string? Comment { get; set; }

        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".pdf" })]
        [MaxFileSize(3 * 1024 * 1024)]
        [NotMapped]
        public IFormFile? UploadDocument { get; set; }
        public string? FilePath { get; set; }
        public DocumentStatus Status { get; set; } = DocumentStatus.Save;

        public int? DocumentTypeId { get; set; }

    }
}
