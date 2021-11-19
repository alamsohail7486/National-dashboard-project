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
    public class PageController : Controller
    {
        private readonly IPage _IPage;       /* here i call Interface  */

        private readonly IWebHostEnvironment webHostEnvironment;
        public PageController(IPage Ipage, IWebHostEnvironment hostEnvironment)    /* here i call parameterized constructor  */
        {
            //this._IPage = Ipage;

            _IPage = Ipage;

            webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewPage()
        {
            return View();
        }

        public IActionResult InsertPage(PageModel pm)
        {
            _IPage.InsertPage(pm);
            UploadedFile(pm);
            return RedirectToAction("Index", "Page");
        }
        public JsonResult PageList()
        {
            var plist = _IPage.PageList();
            return Json(plist);
        }
        public JsonResult GetPageById(int id)
        {
            var gpage = _IPage.GetPageById(id);
            return Json(gpage);
        }
        public IActionResult UpdatePage(PageModel pm)
        {
            string uniqueFileName = UploadedFile(pm);
            pm.Image = uniqueFileName;
            _IPage.UpdatePage(pm);
            return RedirectToAction("Index", "page");
        }
        //[HttpPost("UploadedFile")]
        //public IActionResult New(PageModel model)      /* here  image upload  code */
        //{
        //    string uniqueFileName = UploadedFile(model);
        //    model.Image = uniqueFileName;
        //    if (model.Id == 0)
        //    {
        //        _IPage.InsertPage(model);
        //    }
        //    else
        //    {
        //        _IPage.UpdatePage(model);
        //    }
        //    return RedirectToAction("Index", "page");
        //}        //[HttpPost("UploadedFile")]
        //public IActionResult New(PageModel model)      /* here  image upload  code */
        //{
        //    string uniqueFileName = UploadedFile(model);
        //    model.Image = uniqueFileName;
        //    if (model.Id == 0)
        //    {
        //        _IPage.InsertPage(model);
        //    }
        //    else
        //    {
        //        _IPage.UpdatePage(model);
        //    }
        //    return RedirectToAction("Index", "page");
        //}

        private string UploadedFile(PageModel model)
        {
            string uniqueFileName = null;
            if (model.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfileImage.CopyTo(fileStream);
                    using (FileStream fs = System.IO.File.Create(filePath + ".jpg"))
                    {
                        fileStream.CopyTo(fs);
                        fs.Flush();
                        fs.Dispose();
                    }
                }
            }
            return uniqueFileName;
        }

        public class img
        {
            public int id { get; set; }
            public string imgdel { get; set; }
        }
        public IActionResult DeletePage(img c)
        {
            PageModel a = _IPage.GetPageById(c.id);
            _IPage.DeletePage(c.id);

            a.Image = Path.Combine(webHostEnvironment.WebRootPath, "Images", a.Image);
            FileInfo f1 = new FileInfo(a.Image);
            if (f1 != null)
            {
                System.IO.File.Delete(a.Image);
            }
            return RedirectToAction("Index", "Page");
        }
    }
}
