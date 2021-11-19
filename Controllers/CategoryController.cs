using DashboardProject.Interface;
using DashboardProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory _Icategory;

        public CategoryController(ICategory Icategory)    /* here i call parameterized constructor  */
        {
            this._Icategory = Icategory;
        }


        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult insertCategory(Category cat)
        {
            _Icategory.insertCategory(cat);
            return RedirectToAction("Index", "Category");
        }

        public JsonResult GetAllList(string search)
        {
            var cate = _Icategory.GetAllList(search==null?"":search);
            return Json(cate);
        }
        public JsonResult GetListById(int id)
        {
            var cate = _Icategory.GetListById(id);
            return Json(cate);
        }
        public IActionResult updateCategory(Category cat)
        {

            _Icategory.updateCategory(cat);
            return RedirectToAction("Index");
        }
      
        public IActionResult deleteCategory(int id ) 
        {
            _Icategory.deleteCategory(id);
            return RedirectToAction("Index", "Category");
        }


        
        public IActionResult Test()
        {
            return View();
        }

    }
}
