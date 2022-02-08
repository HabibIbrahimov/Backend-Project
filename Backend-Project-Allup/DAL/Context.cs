﻿using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.DAL
{
    public class Context:IdentityDbContext<AppUser>
    {
        public Context(DbContextOptions<Context>options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDesc> SliderDescs { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BrandSlider> BrandSliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutDesc> AboutDescs { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TestimonialDesc> TestimonialDescs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
