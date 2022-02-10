using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class BrandController : Controller
    {
        private readonly Context _context;

        public BrandController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Brand> brands = _context.Brands.Include(b => b.CategoryBrand).ThenInclude(c => c.Category).ToList();
            return View(brands);
        }
        public ActionResult Create()
        {
            ViewBag.IsMainCategory = _context.Categories.Where(c => c.IsMain == true).ToList();
            ViewBag.SubCategory = _context.Categories.Where(c => c.IsMain == false).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Brand brand, int[] subcategory)
        {
            bool isExist = _context.Brands.Any(c => c.Name.ToLower() == brand.Name.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Name", "This category is already exists");
                return RedirectToAction("Index");

            }
            if (subcategory != null)
            {
                Brand newBrand = new Brand();
                newBrand.Name = brand.Name;
                await _context.Brands.AddAsync(newBrand);
                await _context.SaveChangesAsync();

                foreach (var item in subcategory)
                {
                    CategoryBrand categoryBrands = new CategoryBrand();
                    categoryBrands.BrandId = newBrand.Id;
                    categoryBrands.CategoryId = item;
                    await _context.AddAsync(categoryBrands);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        public async Task<ActionResult> Delete(int? id)
        {
            Brand _brand = await _context.Brands.FirstOrDefaultAsync(x => x.Id == id);
            if (_brand == null) return RedirectToAction("Delete");
            return View(_brand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Brand brand)
        {
            Brand _brand = await _context.Brands.FirstOrDefaultAsync(x => x.Id == brand.Id);
            if (brand == null) return RedirectToAction("Delete");


            List<CategoryBrand> categoryBrand = await _context.CategoryBrands.ToListAsync();
            foreach (var item in categoryBrand)
            {

                _context.CategoryBrands.Remove(item);
                await _context.SaveChangesAsync();


            }
            _context.Brands.Remove(_brand);
            await _context.SaveChangesAsync();

            return View();
        }
    }
}
