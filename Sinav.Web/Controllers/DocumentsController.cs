using Microsoft.AspNetCore.Mvc;
using Sinav.Business.Abstract;
using Sinav.Entities.Concrete;
using Sinav.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav.Web.Controllers
{
    public class DocumentsController : Controller
    {
        private IDocumentsService _documentsService;
        public DocumentsController(IDocumentsService documentsService)
        {
            _documentsService = documentsService;
        }
        public IActionResult Index()
        {
            var model = _documentsService.GetAll();
            DocumentsListViewModel documentsModel = new DocumentsListViewModel()
            {
                Documents = model
            };
            return View(documentsModel);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult AddDocuments(Documents documents)
        {
            _documentsService.Add(documents);
            return RedirectToAction("Add");
        }
        public ActionResult Update(int documentsID)
        {
            var Documents = _documentsService.GetByID(documentsID);
            return View(Documents);
        }
        [HttpPost]
        public ActionResult Update(Documents documents)
        {
            if (ModelState.IsValid)
            {
                _documentsService.Update(documents);
            }
            return RedirectToAction("Update");
        }
    }
}
