using AutoMapper;
using KPIapplication.Models.Document;
using KPIdomain.Entities.Models;
using KPIinfrastructure.Repositories;

namespace KPIapplication.Services.Implication
{
    public class DocumentService : IDocumentService
    {
        private readonly IMapper _mapper;
        private readonly IDocumentRepository _repository;

        public DocumentService(IDocumentRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<Document>> GetAllDoc(int doc_id)
        {
            var result = await _repository.GetAllDoc(doc_id);
            if(result.Count >= 1)
            {
                return result;
            }
            return new();
        }

        public async Task<List<Document>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            var mapper = _mapper.Map<List<Document>>(result);

            return mapper;
        }

        public async Task<int> CreateAsync(Document createTodoItemModel)
        {
            var result = await _repository.AddIntAsync(createTodoItemModel);
            if (result > 0)
            {
                return result;
            }
            return 0;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Document>> GetAllByListIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Document> UpdateAsync(int id, Document updateTodoItemModel)
        {
            throw new NotImplementedException();
        }
    }
}
