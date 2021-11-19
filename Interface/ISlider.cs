using DashboardProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardProject.Interface
{
    public interface ISlider
    {
        SliderModel insertSlider(SliderModel pm);
        SliderModel updateSlider(SliderModel pm);
        SliderModel deleteSlider(int Id);
        SliderModel GetSliderById(int Id);
        IList<SliderModel> GetSliderList();


    }
}
