using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.ViewComponents
{
    public class BrandSliderViewComponent : ViewComponent
    {
        private readonly Context _context;
        public BrandSliderViewComponent(Context context)
        {
            _context = context;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            List<BrandSlider> brandSliders = _context.BrandSliders.ToList();
            return View(await Task.FromResult(brandSliders));

        }
    }
}
