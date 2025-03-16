using KPIapplication.Models.Document;
using KPIdomain.Entities.Models;

namespace KPIapplication.Services
{
    public interface IDocumentService
    {
        Task<List<Document?>> GetAllAsync();
        Task<int> CreateAsync(Document createTodoItemModel);

        Task<List<Document>> GetAllDoc(int doc_id);

        Task<bool> DeleteAsync(int id);

        Task<IEnumerable<Document>>
            GetAllByListIdAsync(int id);

        Task<Document> UpdateAsync(int id, Document updateTodoItemModel);
    }
}
