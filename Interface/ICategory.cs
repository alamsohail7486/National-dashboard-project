using DashboardProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Interface
{
   public  interface ICategory 
    {
        Category insertCategory(Category cat);
        Category updateCategory(Category cat);
        Category deleteCategory( int id);
        IList<Category> GetAllList(string search);
        Category GetListById(int id);
   }
}
