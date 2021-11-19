using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IFormFile ProfileImage { get; set; }
        public bool IsActive { get; set; }
        public DateTime Entrydate { get; set; }
       // public string publish { get; set; }
        public int MetaDescp { get; set; }
        public int MetaKey { get; set; }


    }
}
