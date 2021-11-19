using DashboardProject.Interface;
using DashboardProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Areas.Admin.Controllers
{
    public class LoginControllers : Controller
    {
        [Area("Admin")]
        public class LoginController : Controller
        {
            private readonly IUser _Iuser;
            public LoginController(IUser Iuser)
            {
                this._Iuser = Iuser;
            }

            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }

            [HttpGet]
            public IActionResult LogOut()
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login", "Admin");
            }

            [HttpPost]
            public IActionResult Index(UserModel a)
            {
                var data = _Iuser.Login(a);

                if (data != null)
                {
                    HttpContext.Session.SetString("user", data.userName);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }

        }
    }
}
