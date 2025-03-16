using KPIdomain.Entities.Extensions;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static KPIapplication.Models.Document.DocumentResponseModel;

namespace KPIapplication.Models.Document
{
    public class CreateDocumentModel
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;


        public string? Comment { get; set; }
        public DocumentType? DocumentType { get; set; }

        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".pdf" })]
        [MaxFileSize(3 * 1024 * 1024)]
        public IFormFile? UploadDocument { get; set; }
        [Column(TypeName = "bytea")] // Postgres uchun
        public byte[]? FileData { get; set; }
        public string? DocumentUrl { get; set; }
        public string? FileName { get; set; }
        public string? ContentType { get; set; }
        public DocumentStatus Status { get; set; } = DocumentStatus.Save;

        public int UserId { get; set; }
    }

    public class CreateDocumentResponseModel : BaseResponseModel { }
}

