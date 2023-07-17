using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Sinav.Business.Abstract;
using Sinav.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav.Web.ViewComponents
{
    public class QuizzesListViewComponent : ViewComponent
    {
        private IQuizzesService _quizzesService;
        public QuizzesListViewComponent(IQuizzesService quizzesService)
        {
            _quizzesService = quizzesService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new QuizzesListViewModel
            {
                Quizzes = _quizzesService.GetAll()
            };
            return View(model);
        }
    }
}
