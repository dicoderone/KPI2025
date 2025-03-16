using KPIapplication.Models.Document;
using KPIapplication.Services;
using KPIdomain.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace KPIEmployee.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IDocumentService _documentService;

        public HomeController(IDocumentService documentService, IWebHostEnvironment env)
        {
            _documentService = documentService;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateDoc(IFormCollection form)
        {
            string comment = "" + form["Comment"];
            var createDate = DateTime.Parse("" + form["CreateDate"]);
            int documentTypeId = int.Parse("" + form["DocumentTypeId"]);

            var file = form.Files["UploadDocument"];
            if (file == null || file.Length == 0)
            {
                TempData["errorMessage"] = "Fayl topilmadi!";
                return RedirectToAction("ImportDoc", "Home");
            }

            string uploadsFolder = Path.Combine(_env.WebRootPath, "Upload");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            var documentModel = new Document
            {
                Comment = comment,
                CreateDate = createDate,
                DocumentTypeId = documentTypeId,
                UploadDocument = file,
                Status = DocumentStatus.Save
            };

            var result = await _documentService.CreateAsync(documentModel);

            if (result > 0)
            {
                TempData["successMessage"] = "Hujjat muvaffaqiyatli yaratildi!";
                return RedirectToAction("ImportDoc", "Home");
            }

            TempData["errorMessage"] = "Hujjat yaratishda xatolik yuz berdi!";
            return RedirectToAction("ImportDoc", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDoc(int doc_id)
        {
            List<Document> doc = await _documentService.GetAllDoc(doc_id); 
            return Json(doc);
        }

        [HttpGet]
        public async Task<IActionResult> ImportDoc()
        {
            List<Document> list = await _documentService.GetAllAsync() ?? new List<Document>();
            return View(list);
        }
    }
}
