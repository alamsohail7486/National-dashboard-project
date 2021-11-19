using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Models
{
    public class SliderModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public IFormFile ProfileImage { get; set; }
        public bool IsActive { get; set; }
    }
}
