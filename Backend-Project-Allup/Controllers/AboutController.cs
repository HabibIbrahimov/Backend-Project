using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Backend_Project_Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Controllers
{
    public class AboutController : Controller
    {
        private readonly Context _context;
        public AboutController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            About about = _context.Abouts.FirstOrDefault();
            AboutDesc aboutDesc = _context.AboutDescs.FirstOrDefault();
            AboutVM aboutVm = new AboutVM();
            aboutVm.About = about;
            aboutVm.AboutDesc = aboutDesc;
            return View(aboutVm);
        }
    }
}
