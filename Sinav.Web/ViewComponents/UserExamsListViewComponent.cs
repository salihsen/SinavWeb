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
    public class UserExamsListViewComponent : ViewComponent
    {
        private IUserExamsService _userExamsService;
        public UserExamsListViewComponent(IUserExamsService userExamsService)
        {
            _userExamsService = userExamsService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new UserExamsListViewModel
            {
                UserExams = _userExamsService.GetAll()
            };
            return View(model);
        }
    }
}
