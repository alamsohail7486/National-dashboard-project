using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public bool IsActive { get; set; }
        public DateTime EntryDate { get; set; }
        
    }
}
