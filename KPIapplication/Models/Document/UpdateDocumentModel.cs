using KPIdomain.Entities.Extensions;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace KPIapplication.Models.Document
{
    public class UpdateDocumentModel
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime CreateDateOn { get; set; }

        public int DocumentTypeId { get; set; }
        public bool DocumentIsActive = true;
        public string? DocumentType { get; set; }

        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".pdf" })]
        [MaxFileSize(3 * 1024 * 1024)]
        public IFormFile? UploadDocument { get; set; }
        public Dictionary<string, byte[]> files { get; set; } = new();
        public List<string> DocumentUrl { get; set; } = new();
        public string[] deletedFiles { get; set; } = new string[] { };
        public int Status { get; set; }

        public Guid UserId { get; set; }
    }
    public class UpdateDocResponseMode : BaseResponseModel { }
}
