using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Sinav.Business.Abstract;
using Sinav.Entities.Concrete;
using Sinav.Entities.DTOs;
using Sinav.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Sinav.MvcWebUI.Controllers
{
    public class LoginController : Controller
    {
        private IAuthService _authService;

        public LoginController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IsLogin(UserForLoginDto userForLoginDto)
        {
             var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                if (userToLogin.Data.IsAdmin == true)
                {
                    return RedirectToAction("Index", "Admin");
                }
                return RedirectToAction("Index", "Login");
            }



            //return BadRequest(result.Message);

            //if (LoginUser(loginViewModel.UserName, loginViewModel.Password))
            //{
            //    var claims = new List<Claim>
            //    {
            //        new Claim(ClaimTypes.Name, loginViewModel.UserName)
            //    };

            //    var userIdentity = new ClaimsIdentity(claims, "Login");

            //    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            //    await HttpContext.SignInAsync(principal);

            //    //Just redirect to our index after logging in. 
            //    return RedirectToAction("Index", "Admin");
            //}

        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login/Index");
        }
        private bool LoginUser(string username, string password)
        {
            if (username == "salih" && password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
