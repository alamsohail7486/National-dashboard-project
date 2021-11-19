using DashboardProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Interface
{
   public interface IUser
    {
        UserModel Login(UserModel sa);
    }
}
