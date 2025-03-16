using KPIdomain.Entities.Extensions;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using static KPIdomain.Entities.Models.User;

namespace KPIapplication.Models.Document
{
    public class DocumentResponseModel : BaseResponseModel
    {
        public enum DocumentStatus
        {
            Save = 0,
            Pending,   // Ko‘rib chiqilmoqda
            Approved,  // Tasdiqlandi
            Rejected   // Rad etildi
        }
        public int Score { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime CreateDateOn { get; set; }

        public bool DocumentIsActive = true;
        public string? Comment { get; set; }
        public DocumentType? DocumentType { get; set; }

        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".pdf" })]
        [MaxFileSize(3 * 1024 * 1024)]
        public IFormFile? UploadDocument { get; set; }
        public Dictionary<string, byte[]> files { get; set; } = new();
        public string DocumentUrl { get; set; }
        public string[] deletedFiles { get; set; } = new string[] { };
        public DocumentStatus Status { get; set; } = DocumentStatus.Save;


        public int UserId { get; set; }
    }
    public class DocumentType
    {
        public int Id { get; set; }
        public string? DocumentName { get; set; }
        public UserRole userRole { get; set; }
    }
}

