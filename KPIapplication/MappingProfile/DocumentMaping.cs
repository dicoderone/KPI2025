using AutoMapper;
using KPIapplication.Models.Document;
using KPIdomain.Entities.Models;

namespace KPIapplication.MappingProfile
{
    public class DocumentMaping : Profile
    {
        public DocumentMaping()
        {
            CreateMap<CreateDocumentModel, Document>();

            CreateMap<UpdateDocumentModel, Document>().ReverseMap();

            CreateMap<Document, DocumentResponseModel>();

            CreateMap<KPIapplication.Models.Document.DocumentType, KPIdomain.Entities.Models.DocumentType>();

        }
    }
}
