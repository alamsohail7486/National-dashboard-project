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
    public class AllPostController : Controller
    {
        private readonly IPost _IPost;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AllPostController(IPost Ipost, IWebHostEnvironment hostEnvironment)
        {
            this._IPost = Ipost;
            webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewPost()
        {
            return View();
        }
        public IActionResult InsertPost(Post pst)
        {
            _IPost.InsertPost(pst);
            return RedirectToAction("Index","AllPost");
        }

        public JsonResult getPostList()
        {
            var list = _IPost.getPostList();
            return Json(list);
        }

        public JsonResult getPostById(int id)
        {
            var post = _IPost.getPostById(id);
            return Json(post);
        }

        public IActionResult updatePost(Post pst)
        {
            string uniqueFileName = UploadedFile(pst);
            pst.Image = uniqueFileName;
            _IPost.updatePost(pst);
            return RedirectToAction("Index", "AllPost");
        }

        [HttpPost]
        public IActionResult New(Post pst)      /* here  image upload  code */
        {
            string uniqueFileName = UploadedFile(pst);
            pst.Image = uniqueFileName;
            if (pst.Id == 0)
            {
                _IPost.InsertPost(pst);
            }
            else
            {
                _IPost.updatePost(pst);
            }
            return RedirectToAction("Index", "AllPost");
        }

        private string UploadedFile(Post pst)
        {
            string uniqueFileName = null;
            if (pst.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + pst.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    pst.ProfileImage.CopyTo(fileStream);
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
        //here  deletePage code and also image delete code are written //

        public class img
        {
            public int id { get; set; }
            public string imgdel { get; set; }
        }

        public IActionResult deletePost(img c)
        {
            Post a = _IPost.getPostById(c.id);

            _IPost.deletePost(c.id);
            a.Image = Path.Combine(webHostEnvironment.WebRootPath, "Images", a.Image);
            FileInfo f1 = new FileInfo(a.Image);
            if (f1 != null)
            {
                System.IO.File.Delete(a.Image);
            }
            return RedirectToAction("Index", "AllPost");
        }






        public IActionResult profile()
        {
            return View();
        }

        public IActionResult Password()
        {
            return View();
        }
    }
}
