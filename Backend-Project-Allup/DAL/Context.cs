using Backend_Project_Allup.Models;
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
    }
}
