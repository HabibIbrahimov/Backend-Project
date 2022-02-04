﻿using Backend_Project_Allup.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDesc> SliderDescs { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BrandSlider> BrandSliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
