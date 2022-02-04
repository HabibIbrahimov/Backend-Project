using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Extensions;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]

    public class SliderController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                ModelState.AddModelError("Photo", "Don't empty");
            }

            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "only image");
                return View();
            }
            if (slider.Photo.IsCorrectSize(500))
            {
                ModelState.AddModelError("Photo", "500-den yuxari ola bilmez!");
                return View();
            }


            Slider newSlider = new Slider();

            string fileName = await slider.Photo.SaveImageAsync(_env.WebRootPath, "assets/images");
            newSlider.ImageUrl = fileName;


            await _context.Sliders.AddAsync(newSlider);
            await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }

    }
}
