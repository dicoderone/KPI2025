using KPIdomain.Entities.Models;

namespace KPIinfrastructure.Repositories
{
    public interface IDocumentRepository : IBaseRepository<Document>
    {
        Task<List<Document>> GetAllDoc(int doc_id);
    }
}
