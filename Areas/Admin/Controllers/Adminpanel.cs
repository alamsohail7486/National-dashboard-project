using DashboardProject.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Areas.Admin.Controllers
{
    public class Adminpanel : Controller
    {
        private readonly IUser _Iuser;
        public Adminpanel(IUser Iuser)
        {
            this._Iuser = Iuser;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
