using DashboardProject.Interface;
using DashboardProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Controllers
{
    public class SliderController : Controller
    {
        private readonly ISlider _Islider;
        private readonly IWebHostEnvironment webHostEnvironment;
        public SliderController(ISlider Islider, IWebHostEnvironment hostEnvironment)
        {
            this._Islider = Islider;
            webHostEnvironment = hostEnvironment; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNewSlider()
        {
            return View();
        }
        public void insertSlider(SliderModel sm)
        {
            if (sm.Image != null)
            {
                sm.Image = UploadedFile(sm);
            }
            _Islider.insertSlider(sm);
        }

        public JsonResult GetSliderList()
        { 
            var list = _Islider.GetSliderList();
            return Json(list);
        }

        public JsonResult GetSliderById(int id)
        {
            var slide = _Islider.GetSliderById(id);
            return Json(slide);
        }

        public IActionResult updateSlider(SliderModel page)
        {
            string uniqueFileName = UploadedFile(page);
            page.Image = uniqueFileName;
            _Islider.updateSlider(page);
            return RedirectToAction("Index", "Page");
        }

        [HttpPost("UploadedFile")]
        public IActionResult New(SliderModel model)      /* here  image upload  code */
        {

            string uniqueFileName = UploadedFile(model);

            model.Image = uniqueFileName;
            if (model.Id == 0)
            {
                _Islider.insertSlider(model);
            }
            else
            {
                _Islider.updateSlider(model);

            }
            return RedirectToAction("Index", "Slider");
        }

        private string UploadedFile(SliderModel model)
        {
            string uniqueFileName = null;

            if (model.ProfileImage != null)
            {
                //foreach (var file in model.ProfileImage)

                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);


                //using thread
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfileImage.CopyTo(filestream);
                }
            }
            return uniqueFileName;
        }

        private void imgStreamer(string filepath, IFormFile prfimg)
        {

        }

        //here  deletePage code and also image delete code are written //
        public class img
        {
            public int id { get; set; }
            public string imgdel { get; set; }
        }
        public IActionResult deleteSlider(img a)
        {
            _Islider.deleteSlider(a.id);

            a.imgdel = Path.Combine(webHostEnvironment.WebRootPath, "Images", a.imgdel);
            FileInfo f1 = new FileInfo(a.imgdel);
            if (f1 != null)
            {
                System.IO.File.Delete(a.imgdel);
            }
            return RedirectToAction("Index", "Slider");
        }
    }
}
