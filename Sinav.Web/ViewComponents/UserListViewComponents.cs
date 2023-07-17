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
    public class UserListViewComponent : ViewComponent
    {
        private IUserService _userService;
        public UserListViewComponent(IUserService userService)
        {
            _userService= userService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new UserListViewModel
            {
                Users = _userService.GetAll()
            };
            return View(model);
        }
    }
}
