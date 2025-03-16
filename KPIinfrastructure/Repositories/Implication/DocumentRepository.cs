using KPIdomain.Entities.Models;
using KPIinfrastructure.Persistence;

namespace KPIinfrastructure.Repositories.Implication
{
    public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
    {
        private readonly ApplicationDbContext _context;
        public DocumentRepository(ApplicationDbContext dataBaseContext) : base(dataBaseContext)
        { 
            _context = dataBaseContext;
        }

        public Task<List<Document>> GetAllDoc(int doc_id)
        {
            var list = _context.Documents.Where(x => x.DocumentTypeId == doc_id).ToList();
            return Task.FromResult(list);
        }
    }
}
