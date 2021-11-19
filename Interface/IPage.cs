using DashboardProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Interface
{
  public interface IPage
    {
        PageModel InsertPage(PageModel pm);
        PageModel UpdatePage(PageModel pm);
        PageModel DeletePage(int Id);
        PageModel GetPageById(int Id);
        IList<PageModel> PageList();


    }
}
