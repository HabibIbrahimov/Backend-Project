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
    public class AboutController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;

        public AboutController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public ActionResult Index()
        {
            About about = _context.Abouts.FirstOrDefault();
            return View(about);
        }

        public ActionResult Details(int id)
        {
            About about = _context.Abouts.FirstOrDefault(a => a.Id == id);
            return View(about);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            About dbAbout = await _context.Abouts.FindAsync(id);

            return View(dbAbout);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id, About about)
        {
            if (id == null) return NotFound();

            if (!ModelState.IsValid) return View();

            bool isExist = _context.Abouts.Any(s => s.Title.ToLower().Trim() == about.Title.ToLower().Trim());

            About isExistAbout = _context.Abouts.FirstOrDefault(s => s.Id == about.Id);

            if (isExist && !(isExistAbout.Title.ToLower() == about.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", "The about with this title already exists");
                View();
            };



            if (about.Image != null)
            {
                if (ModelState["Image"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    ModelState.AddModelError("Image", "Please, don't empty");
                }

                if (!about.Image.IsImage())
                {
                    ModelState.AddModelError("Photo", "just image");
                    return View();
                }
                if (about.Image.IsCorrectSize(400))
                {
                    ModelState.AddModelError("Photo", "Enter correct size");
                    return View();
                }
                About dbAbout = await _context.Abouts.FindAsync(id);
                string path = Path.Combine(_env.WebRootPath, "assets/images/", dbAbout.ImageUrl);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                string fileName = await about.Image.SaveImageAsync(_env.WebRootPath, "assets/images/");


                dbAbout.ImageUrl = fileName;
                dbAbout.Title = about.Title;
                dbAbout.Desc = about.Desc;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
