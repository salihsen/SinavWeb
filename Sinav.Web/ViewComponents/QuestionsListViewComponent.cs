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
    public class QuestionsListViewComponent : ViewComponent
    {
        private IQuestionsService _questionsService;
        public QuestionsListViewComponent(IQuestionsService questionsService)
        {
            _questionsService= questionsService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new QuestionsListViewModel
            {
                Questions = _questionsService.GetAll()
            };
            return View(model);
        }
    }
}
