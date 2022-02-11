﻿using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Backend_Project_Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
            HomeVM homeVm = new HomeVM();
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
            ViewBag.FeatCategories = categories.Where(c => c.IsFeature == true);
            return View(homeVm);
        }
    }
}
