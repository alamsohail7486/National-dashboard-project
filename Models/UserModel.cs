﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public DateTime entryDate { get; set; }
    }
}
