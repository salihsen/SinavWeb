using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Sinav.Business.Abstract;
using Sinav.Entities.Concrete;
using Sinav.Web.Models;
using Sinav.Web.SessionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav.Web.Controllers
{
    public class ExamsController : Controller
    {
        //private IQuizzesSessionHelper _IQuizzesSessionHelper;
        private readonly IQuizzesService _quizzesService;
        private IQuestionsService _questionService;
        private IStylishService _stylishService;
        public ExamsController(IQuizzesService quizzesService, IQuestionsService questionsService, IStylishService stylishService)
        {
            _quizzesService = quizzesService;
            //_IQuizzesSessionHelper = IquizzesSessionHelper;
            _questionService = questionsService;
            _stylishService = stylishService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExam(Quizzes quizzes)
        {
            _quizzesService.Add(quizzes);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult AddQuestions(Questions questions)
        {
            _questionService.Add(questions);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult AddStylish(Stylish stylish)
        {
            _stylishService.Add(stylish);
            return RedirectToAction("Index");
        }
        public IActionResult List()
        {
            var model = _quizzesService.GetAll();
            QuizzesListViewModel quizzesModel = new QuizzesListViewModel()
            {
                Quizzes = model
            };
            return View(quizzesModel);
        }
        public JsonResult List2(int sinavid)
        {
            var model = _questionService.GetAll(sinavid);
            return Json(model);
        }
        public ActionResult Update(int quizzesID)
        {
            var Quizzes = _quizzesService.GetById(quizzesID);
            return View(Quizzes);
        }
        [HttpPost]
        public ActionResult Update(Quizzes quizzes)
        {
            if (ModelState.IsValid)
            {
                _quizzesService.Update(quizzes);
            }
            return RedirectToAction("Update");
        }
    }
}
