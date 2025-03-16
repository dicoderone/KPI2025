using KPIapplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace KPIEmployee.Controllers
{
    public class DocumentController : Controller
    {
        private readonly IDocumentService _documentService;

        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
