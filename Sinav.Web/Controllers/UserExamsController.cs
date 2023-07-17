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
    public class UserExamsController : Controller
    {
        private IUserExamsService _userExamsService;
        public UserExamsController(IUserExamsService userExamsService)
        {
            _userExamsService = userExamsService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Atama(UserExams userExams)
        {
            _userExamsService.Add(userExams);
            return RedirectToAction("Index");
        }
        public IActionResult List()
        {
            var model = _userExamsService.GetAll();
            UserExamsListViewModel userExams = new UserExamsListViewModel()
            {
                UserExams = model
            };
            return View(userExams);
        }
    }
}
