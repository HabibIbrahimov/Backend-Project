using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Extensions;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class CategoryController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Context _context;

        public CategoryController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public ActionResult Index()
        {
            List<Category> categories = _context.Categories.Include(x => x.CategoryBrand).ThenInclude(x => x.Brand).ToList();

            return View(categories);
        }
      

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Category dbCategory = await _context.Categories.FindAsync(id);
            if (dbCategory == null) return NotFound();
            return View(dbCategory);
        }

        public ActionResult Create()
        {
            List<Category> MainCategory = _context.Categories.Where(x => x.IsMain == true && x.IsDeleted == false).ToList();
            ViewBag.Category = MainCategory;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Category category)
        {
            bool isExist = _context.Categories.Any(c => c.Name.ToLower() == category.Name.ToLower().Trim());

            if (isExist)
            {
                ModelState.AddModelError("Name", "This category is already exists");
                return RedirectToAction("Index");

            }
            if (!category.IsMain)
            {
                Category subCategory = new Category();
                List<Category> db = _context.Categories.Where(c => c.Id == category.MainCategory.Id).ToList();


                subCategory.MainCategory = db.FirstOrDefault();
                subCategory.Name = category.Name;

                if (subCategory.MainCategory == null)
                {

                    return NotFound();

                }
                await _context.Categories.AddAsync(subCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                ModelState.AddModelError("Photo", "Do not empty");
            }

            if (!category.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "only image");
                return RedirectToAction("Index");

            }
            if (category.Photo.IsCorrectSize(300))
            {
                ModelState.AddModelError("Photo", "please enter photo under 300kb");
                return RedirectToAction("Index");

            }



            string fileName = await category.Photo.SaveImageAsync(_env.WebRootPath, "assets/images/");
            Category mainCategory = new Category
            {
                Name = category.Name,
                IsMain = category.IsMain,
                IsFeature = category.IsFeature,
                PhotoUrl = fileName,
            };

            await _context.Categories.AddAsync(mainCategory);
            await _context.SaveChangesAsync();



            return RedirectToAction("Index");

        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Category dbCategory = await _context.Categories.FindAsync(id);
            if (dbCategory == null) return NotFound();

            List<Category> MainCategory = _context.Categories.Where(x => x.IsMain == true && x.IsDeleted == false).ToList();
            ViewBag.Category = MainCategory;

            return View(dbCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id, Category category)
        {
            bool isExist = _context.Categories.Any(c => c.Name.ToLower() == category.Name.ToLower().Trim());
            Category newCategory = await _context.Categories.FindAsync(id);

            if (isExist && !(newCategory.Name.ToLower() == category.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", "Bu adla Category var");
                return View();
            };

            if (!category.IsMain)
            {

                newCategory.MainCategory = await _context.Categories.FindAsync(category.MainCategory.Id);
                newCategory.Name = category.Name;
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");

            }
            if (category.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    ModelState.AddModelError("Photo", "Do not empty");
                }

                if (!category.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "only image");
                    return View();
                }
                if (category.Photo.IsCorrectSize(300))
                {
                    ModelState.AddModelError("Photo", "300den yuxari ola bilmez");
                    return View();
                }
                string path = Path.Combine(_env.WebRootPath, "img", newCategory.PhotoUrl);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                string fileName = await category.Photo.SaveImageAsync(_env.WebRootPath, "assets/images/");
                newCategory.PhotoUrl = fileName;

            }
            newCategory.Name = category.Name;
            newCategory.IsFeature = category.IsFeature;


            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Category dbCategory = await _context.Categories.FindAsync(id);
            if (dbCategory == null) return NotFound();
            return View(dbCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id, Category category)
        {
            if (id == null) return NotFound();
            Category dbCategory = await _context.Categories.FindAsync(id);
            if (dbCategory == null) return NotFound();
            if (dbCategory.IsMain)
            {
                bool isSubcategory = _context.Categories.Any(c => c.MainCategory.Id == category.Id);
                if (isSubcategory)
                {
                    dbCategory.IsDeleted = true;
                }
                else
                {
                    string path = Path.Combine(_env.WebRootPath, "assets/images/", dbCategory.PhotoUrl);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    _context.Categories.Remove(dbCategory);

                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }


            _context.Categories.Remove(dbCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
