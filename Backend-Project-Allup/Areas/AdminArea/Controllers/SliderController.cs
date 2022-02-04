using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Extensions;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        public async Task<IActionResult> Remove(int? id)
        {
            if (id == null) return NotFound();
            Slider dbSlider = await _context.Sliders.FindAsync(id);
            if (dbSlider == null) return NotFound();
            return View(dbSlider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Remove")]
        public async Task<IActionResult> RemoveSlider(int? id)
        {
            if (id == null) return NotFound();
            Slider dbSlider = await _context.Sliders.FindAsync(id);
            if (dbSlider == null) return NotFound();

            string path = Path.Combine(_env.WebRootPath, "assets/images", dbSlider.ImageUrl);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Sliders.Remove(dbSlider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Slider dbSlider = await _context.Sliders.FindAsync(id);
            if (dbSlider == null) return NotFound();
            return View(dbSlider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slider)
        {
            if (id == null) return NotFound();
            if (slider.Photo != null)
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

                Slider dbSlider = await _context.Sliders.FindAsync(id);
                string path = Path.Combine(_env.WebRootPath, "assets/images", dbSlider.ImageUrl);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                string fileName = await slider.Photo.SaveImageAsync(_env.WebRootPath, "assets/images");
                dbSlider.ImageUrl = fileName;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
