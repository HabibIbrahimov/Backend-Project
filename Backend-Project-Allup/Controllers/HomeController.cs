using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Backend_Project_Allup.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context =context;
        }
        public IActionResult Index()
        {
            HttpContext.Session.SetString("person", "lorem");
            List<Slider> sliders = _context.Sliders.ToList();
            SliderDesc sliderDesc = _context.SliderDescs.FirstOrDefault();
            List<Banner> banners = _context.Banners.ToList();
            List<BrandSlider> brandSliders = _context.BrandSliders.ToList();
            List<Blog> blogs = _context.Blogs.ToList();
            Subscribe subscribe = _context.Subscribes.FirstOrDefault();
            List<Testimonial> testimonials = _context.Testimonials.ToList();
            List<TestimonialDesc> testimonialDescs = _context.TestimonialDescs.ToList();
            List<Service> services = _context.Services.ToList();
            List<Category> categories = _context.Categories.Where(c => c.IsMain == true).ToList();
            List<Product> products = _context.Products.Include(p => p.Campaign).Include(p => p.productPhotos).Include(p => p.Brand).ToList();
            HomeVM homeVm = new HomeVM();
            ViewBag.newarrive = products.OrderByDescending(p => p.Id).Take(14).ToList();
            homeVm.Sliders = sliders;
            homeVm.SliderDesc = sliderDesc;
            homeVm.Banners = banners;
            homeVm.BrandSliders = brandSliders;
            homeVm.Blogs = blogs;
            homeVm.Subscribe = subscribe;
            homeVm.Testimonials = testimonials;
            homeVm.TestimonialDesc = testimonialDescs;
            homeVm.services = services;
            homeVm.Categories = categories;
            homeVm.products = products;
            ViewBag.FeatCategories = categories.Where(c => c.IsFeature == true);
            return View(homeVm);
        }

        public IActionResult GetSession()
        {
            string session = HttpContext.Session.GetString("person");
            return Content(session);
        }
    }
}
