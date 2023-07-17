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
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
                var model = _userService.GetAll();
                UserListViewModel userModel = new UserListViewModel()
                {
                    Users = model
                };
                return View(userModel);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userService.Add(user);
            return RedirectToAction("Add");
        }
        public ActionResult Update(int userID)
        {
            var User = _userService.GetByID(userID);

            return View(User);
        }
        [HttpPost]
        public ActionResult Update(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Update(user);
            }
            return RedirectToAction("Update");
        }
    }
}
